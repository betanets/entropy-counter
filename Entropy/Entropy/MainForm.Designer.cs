﻿namespace Entropy
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.main_menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_analyze = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.dataGridView_stats = new System.Windows.Forms.DataGridView();
            this.chart_current_entropy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_current_entropy)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(913, 24);
            this.main_menu.TabIndex = 1;
            this.main_menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button_analyze
            // 
            this.button_analyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_analyze.Enabled = false;
            this.button_analyze.Location = new System.Drawing.Point(773, 27);
            this.button_analyze.Name = "button_analyze";
            this.button_analyze.Size = new System.Drawing.Size(129, 23);
            this.button_analyze.TabIndex = 4;
            this.button_analyze.Text = "Начать обработку";
            this.button_analyze.UseVisualStyleBackColor = true;
            this.button_analyze.Click += new System.EventHandler(this.button_analyze_Click);
            // 
            // label_file
            // 
            this.label_file.AutoSize = true;
            this.label_file.Location = new System.Drawing.Point(10, 32);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(92, 13);
            this.label_file.TabIndex = 3;
            this.label_file.Text = "Файл не выбран";
            // 
            // dataGridView_stats
            // 
            this.dataGridView_stats.AllowUserToAddRows = false;
            this.dataGridView_stats.AllowUserToDeleteRows = false;
            this.dataGridView_stats.AllowUserToResizeColumns = false;
            this.dataGridView_stats.AllowUserToResizeRows = false;
            this.dataGridView_stats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_stats.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView_stats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_stats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stats.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_stats.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_stats.Location = new System.Drawing.Point(14, 56);
            this.dataGridView_stats.Name = "dataGridView_stats";
            this.dataGridView_stats.ReadOnly = true;
            this.dataGridView_stats.RowHeadersVisible = false;
            this.dataGridView_stats.Size = new System.Drawing.Size(888, 65);
            this.dataGridView_stats.TabIndex = 6;
            // 
            // chart_current_entropy
            // 
            this.chart_current_entropy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "EntropyArea";
            this.chart_current_entropy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_current_entropy.Legends.Add(legend1);
            this.chart_current_entropy.Location = new System.Drawing.Point(14, 138);
            this.chart_current_entropy.Name = "chart_current_entropy";
            this.chart_current_entropy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "EntropyArea";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_current_entropy.Series.Add(series1);
            this.chart_current_entropy.Size = new System.Drawing.Size(887, 300);
            this.chart_current_entropy.TabIndex = 7;
            this.chart_current_entropy.Text = "chart_current_entropy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.chart_current_entropy);
            this.Controls.Add(this.dataGridView_stats);
            this.Controls.Add(this.button_analyze);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.main_menu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.main_menu.ResumeLayout(false);
            this.main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_current_entropy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button_analyze;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.DataGridView dataGridView_stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_current_entropy;
    }
}