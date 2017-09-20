using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entropy
{
    public partial class ConditionalFrequenciesForm : Form
    {
        private Int32[,] conditionalFrequencies;
        private Int64 textLength;
        private Double controlSum = 0;

        public ConditionalFrequenciesForm(Int32[,] conditionalFrequencies, Int64 textLength)
        {
            InitializeComponent();
            this.conditionalFrequencies = conditionalFrequencies;
            this.textLength = textLength;
        }

        private void ConditionalFrequenciesForm_Load(object sender, EventArgs e)
        {
            dataGridView_conditionalFrequencies.Rows.Clear();
            dataGridView_conditionalFrequencies.Columns.Clear();

            Int32 arrayLength = conditionalFrequencies.GetLength(0);

            for (int i = 0; i < arrayLength; i++)
            {
                DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
                //dataGridViewColumn.HeaderText = pair.Key;
                //dataGridViewColumn.Name = pair.Key;
                dataGridViewColumn.Width = 50;
                dataGridView_conditionalFrequencies.Columns.Add(dataGridViewColumn);
            }

            if (dataGridView_conditionalFrequencies.Columns.Count > 0)
            {
                dataGridView_conditionalFrequencies.Rows.Add(arrayLength);
            }
            else return;

            for(int i = 0; i < arrayLength; i++)
            {
                for(int j = 0; j < arrayLength; j++)
                {
                    dataGridView_conditionalFrequencies.Rows[i].Cells[j].Value = String.Format("{0:0.00%}", ((Double)conditionalFrequencies[i, j] / textLength));
                    controlSum += ((Double)conditionalFrequencies[i, j] / textLength);
                }
            }

            this.label_control_sum.Text = "Контрольная сумма: " + controlSum.ToString();
        }
    }
}
