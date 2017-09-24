using System;
using System.Windows.Forms;

namespace Entropy
{
    public partial class ConditionalFrequenciesForm : Form
    {
        private Analyzer analyzer;
        private Int32 languageId;
        private Double controlSum = 0;

        public ConditionalFrequenciesForm(Analyzer analyzer, Int32 languageId)
        {
            InitializeComponent();
            this.analyzer = analyzer;
            this.languageId = languageId;
        }

        private void ConditionalFrequenciesForm_Load(object sender, EventArgs e)
        {
            dataGridView_conditionalFrequencies.Rows.Clear();
            dataGridView_conditionalFrequencies.Columns.Clear();

            Int32 arrayLength = analyzer.getConditionalFrequencies().GetLength(0);

            for (int i = 0; i < arrayLength; i++)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = Helper.getCharByIndex(i, languageId).ToString(),
                    Name = Helper.getCharByIndex(i, languageId).ToString(),
                    Width = 50
                };
                dataGridView_conditionalFrequencies.Columns.Add(dataGridViewColumn);
            }

            if (dataGridView_conditionalFrequencies.Columns.Count > 0)
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.HeaderCell.Value = Helper.getCharByIndex(i, languageId).ToString();
                    dataGridView_conditionalFrequencies.Rows.Add(dataGridViewRow);
                }
            }
            else return;

            for(int i = 0; i < arrayLength; i++)
            {
                for(int j = 0; j < arrayLength; j++)
                {
                    dataGridView_conditionalFrequencies.Rows[i].Cells[j].Value = String.Format("{0:0.00%}", ((Double)analyzer.getConditionalFrequencies()[i, j] / analyzer.textLength));
                    controlSum += ((Double)analyzer.getConditionalFrequencies()[i, j] / analyzer.textLength);
                }
            }

            this.label_control_sum.Text = "Контрольная сумма: " + controlSum.ToString();
        }
    }
}
