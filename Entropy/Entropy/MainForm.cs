using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Entropy
{
    public partial class MainForm : Form
    {
        private TextKeeper keeper;
        private Analyzer analyzer;
        private Int32 selectedLanguageId;

        public MainForm()
        {
            InitializeComponent();
            keeper = new TextKeeper();
            analyzer = new Analyzer();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_file.Text = "Файл выбран: " + openFileDialog.FileName;
                try
                {
                    if (openFileDialog.OpenFile() != null)
                    {
                        keeper.clearText();
                        StreamReader sr;
                        using (sr = new StreamReader(openFileDialog.FileName))
                        {
                            Int64 length = 0;
                            String line;
                            while (sr.Peek() >= 0)
                            {
                                line = sr.ReadLine();
                                keeper.addLine(line);
                                length += line.Length;
                            }
                            sr.Close();
                            keeper.textLength = length;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось прочитать файл. Подробная информация об ошибке: " + ex.Message);
                }
                button_analyze.Enabled = true;
            }
        }

        private void button_analyze_Click(object sender, EventArgs e)
        {
            analyzer.initAbsoluteFrequencies(selectedLanguageId);
            analyzer.initConditionalFrequencies(selectedLanguageId);
            analyzer.initPartialFrequencies();
            analyzer.entropy = 0;

            analyzer.analyze(keeper);
            analyzer.analyzeConditional(keeper, selectedLanguageId);
            analyzer.analyzePartial(keeper, selectedLanguageId);
            chart_current_entropy.DataSource = analyzer.getAbsoluteFrequencies();
            chart_current_entropy.Series[0].XValueMember = "Key";
            chart_current_entropy.Series[0].YValueMembers = "Value";
            chart_current_entropy.DataBind();
            chart_current_entropy.ChartAreas["EntropyArea"].AxisX.Interval = 1;

            analyzer.countEntropy(keeper);
            analyzer.countPerformance(keeper);

            loadStats();

            условныеЧастотыToolStripMenuItem.Enabled = true;
        }

        private void loadStats()
        {
            this.label_entropy.Text = "Значение энтропии: " + String.Format("{0:0.000}", analyzer.entropy);
            this.label_performance.Text = "Производительность марковского источника: " + String.Format("{0:0.000}", analyzer.performance);

            dataGridView_stats.Rows.Clear();
            dataGridView_stats.Columns.Clear();

            foreach (KeyValuePair<String, Int32> pair in analyzer.getAbsoluteFrequencies())
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
                dataGridViewColumn.HeaderText = pair.Key;
                dataGridViewColumn.Name = pair.Key;
                dataGridViewColumn.Width = 50;
                dataGridView_stats.Columns.Add(dataGridViewColumn);
            }

            if (dataGridView_stats.Columns.Count > 0)
            {
                dataGridView_stats.Rows.Add(1);
            }
            else return;

            foreach (KeyValuePair<String, Int32> pair in analyzer.getAbsoluteFrequencies())
            {
                dataGridView_stats.Rows[0].Cells[pair.Key].Value = String.Format("{0:0.00%}", ((Double)pair.Value / keeper.textLength));
            }
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentItem = sender as ToolStripMenuItem;
            switch (currentItem.Text)
            {
                case "Русский":
                    selectedLanguageId = 0;
                    break;
                case "Английский":
                    selectedLanguageId = 1;
                    break;
            }

            if (currentItem != null)
            {
                ((ToolStripMenuItem)currentItem.OwnerItem)
                    .DropDownItems
                    .OfType<ToolStripMenuItem>().ToList()
                    .ForEach(item => { item.Checked = false; });

                currentItem.Checked = true;
            }
        }

        private void условныеЧастотыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConditionalFrequenciesForm conditionalFrequenciesForm = new ConditionalFrequenciesForm(analyzer, selectedLanguageId);
            conditionalFrequenciesForm.ShowDialog();
        }
    }
}
