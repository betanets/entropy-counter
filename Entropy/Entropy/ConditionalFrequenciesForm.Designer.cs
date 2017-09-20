namespace Entropy
{
    partial class ConditionalFrequenciesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_conditionalFrequencies = new System.Windows.Forms.DataGridView();
            this.label_control_sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_conditionalFrequencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_conditionalFrequencies
            // 
            this.dataGridView_conditionalFrequencies.AllowUserToAddRows = false;
            this.dataGridView_conditionalFrequencies.AllowUserToDeleteRows = false;
            this.dataGridView_conditionalFrequencies.AllowUserToResizeColumns = false;
            this.dataGridView_conditionalFrequencies.AllowUserToResizeRows = false;
            this.dataGridView_conditionalFrequencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_conditionalFrequencies.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_conditionalFrequencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_conditionalFrequencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_conditionalFrequencies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_conditionalFrequencies.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_conditionalFrequencies.Location = new System.Drawing.Point(12, 25);
            this.dataGridView_conditionalFrequencies.Name = "dataGridView_conditionalFrequencies";
            this.dataGridView_conditionalFrequencies.Size = new System.Drawing.Size(660, 624);
            this.dataGridView_conditionalFrequencies.TabIndex = 0;
            // 
            // label_control_sum
            // 
            this.label_control_sum.AutoSize = true;
            this.label_control_sum.Location = new System.Drawing.Point(12, 9);
            this.label_control_sum.Name = "label_control_sum";
            this.label_control_sum.Size = new System.Drawing.Size(115, 13);
            this.label_control_sum.TabIndex = 1;
            this.label_control_sum.Text = "Контрольная сумма: ";
            // 
            // ConditionalFrequenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.label_control_sum);
            this.Controls.Add(this.dataGridView_conditionalFrequencies);
            this.Name = "ConditionalFrequenciesForm";
            this.Text = "ConditionalFrequenciesForm";
            this.Load += new System.EventHandler(this.ConditionalFrequenciesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_conditionalFrequencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_conditionalFrequencies;
        private System.Windows.Forms.Label label_control_sum;
    }
}