﻿namespace Monitor_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelCPUUSAGE = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelSYSTEMUPTIME = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labCPU = new System.Windows.Forms.Label();
            this.labRAM = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCOUNTOFPHYSICALCPUs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCPUUSAGE
            // 
            this.labelCPUUSAGE.AutoSize = true;
            this.labelCPUUSAGE.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUUSAGE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCPUUSAGE.Location = new System.Drawing.Point(56, 138);
            this.labelCPUUSAGE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPUUSAGE.Name = "labelCPUUSAGE";
            this.labelCPUUSAGE.Size = new System.Drawing.Size(201, 27);
            this.labelCPUUSAGE.TabIndex = 0;
            this.labelCPUUSAGE.Text = "CPU Usage            :";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelRAM.Location = new System.Drawing.Point(56, 190);
            this.labelRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(204, 27);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "Available RAM      :";
            // 
            // labelSYSTEMUPTIME
            // 
            this.labelSYSTEMUPTIME.AutoSize = true;
            this.labelSYSTEMUPTIME.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSYSTEMUPTIME.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSYSTEMUPTIME.Location = new System.Drawing.Point(56, 249);
            this.labelSYSTEMUPTIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSYSTEMUPTIME.Name = "labelSYSTEMUPTIME";
            this.labelSYSTEMUPTIME.Size = new System.Drawing.Size(205, 27);
            this.labelSYSTEMUPTIME.TabIndex = 2;
            this.labelSYSTEMUPTIME.Text = "SYSTEM UP TIME  :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 450;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.ForeColor = System.Drawing.Color.Maroon;
            this.labelDateTime.Location = new System.Drawing.Point(747, 28);
            this.labelDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(117, 27);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "Date Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(531, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(531, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "RAM";
            // 
            // labCPU
            // 
            this.labCPU.AutoSize = true;
            this.labCPU.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCPU.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labCPU.Location = new System.Drawing.Point(935, 122);
            this.labCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCPU.Name = "labCPU";
            this.labCPU.Size = new System.Drawing.Size(36, 24);
            this.labCPU.TabIndex = 8;
            this.labCPU.Text = "0%";
            // 
            // labRAM
            // 
            this.labRAM.AutoSize = true;
            this.labRAM.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRAM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labRAM.Location = new System.Drawing.Point(935, 156);
            this.labRAM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRAM.Name = "labRAM";
            this.labRAM.Size = new System.Drawing.Size(36, 24);
            this.labRAM.TabIndex = 9;
            this.labRAM.Text = "0%";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(588, 127);
            this.progressBarCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(309, 18);
            this.progressBarCPU.TabIndex = 10;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(588, 161);
            this.progressBarRAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(309, 18);
            this.progressBarRAM.TabIndex = 11;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed bytes in use";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Navy;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(536, 217);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "CPU";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "RAM";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(437, 368);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // labelCOUNTOFPHYSICALCPUs
            // 
            this.labelCOUNTOFPHYSICALCPUs.AutoSize = true;
            this.labelCOUNTOFPHYSICALCPUs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOUNTOFPHYSICALCPUs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCOUNTOFPHYSICALCPUs.Location = new System.Drawing.Point(56, 80);
            this.labelCOUNTOFPHYSICALCPUs.Name = "labelCOUNTOFPHYSICALCPUs";
            this.labelCOUNTOFPHYSICALCPUs.Size = new System.Drawing.Size(244, 27);
            this.labelCOUNTOFPHYSICALCPUs.TabIndex = 13;
            this.labelCOUNTOFPHYSICALCPUs.Text = "Count of Physical CPUs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1065, 614);
            this.Controls.Add(this.labelCOUNTOFPHYSICALCPUs);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.labRAM);
            this.Controls.Add(this.labCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelSYSTEMUPTIME);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPUUSAGE);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPUUSAGE;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelSYSTEMUPTIME;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCPU;
        private System.Windows.Forms.Label labRAM;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelCOUNTOFPHYSICALCPUs;
    }
}

