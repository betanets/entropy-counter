using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entropy
{
    public partial class MainForm : Form
    {
        private TextKeeper keeper;
        private Analyzer analyzer;

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
            analyzer.initEntropy();
            analyzer.analyze(keeper);
            chart_current_entropy.DataSource = analyzer.getEntropy();
            chart_current_entropy.Series[0].XValueMember = "Key";
            chart_current_entropy.Series[0].YValueMembers = "Value";
            chart_current_entropy.DataBind();
            chart_current_entropy.ChartAreas["EntropyArea"].AxisX.Interval = 1;

            loadStats();
        }

        private void loadStats()
        {
            foreach (KeyValuePair<String, Int32> pair in analyzer.getEntropy())
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

            foreach (KeyValuePair<String, Int32> pair in analyzer.getEntropy())
            {
                dataGridView_stats.Rows[0].Cells[pair.Key].Value = String.Format("{0:0.00%}", ((Double)pair.Value / keeper.textLength));
            }
        }
    }
}
