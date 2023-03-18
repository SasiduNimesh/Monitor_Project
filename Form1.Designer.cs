namespace Monitor_Project
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
            this.labelCPUUSAGE = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelSYSTEMUPTIME = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCPUUSAGE
            // 
            this.labelCPUUSAGE.AutoSize = true;
            this.labelCPUUSAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPUUSAGE.Location = new System.Drawing.Point(50, 20);
            this.labelCPUUSAGE.Name = "labelCPUUSAGE";
            this.labelCPUUSAGE.Size = new System.Drawing.Size(133, 25);
            this.labelCPUUSAGE.TabIndex = 0;
            this.labelCPUUSAGE.Text = "CPU Usage";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.Location = new System.Drawing.Point(52, 61);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(166, 25);
            this.labelRAM.TabIndex = 1;
            this.labelRAM.Text = "Available RAM";
            // 
            // labelSYSTEMUPTIME
            // 
            this.labelSYSTEMUPTIME.AutoSize = true;
            this.labelSYSTEMUPTIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSYSTEMUPTIME.Location = new System.Drawing.Point(52, 100);
            this.labelSYSTEMUPTIME.Name = "labelSYSTEMUPTIME";
            this.labelSYSTEMUPTIME.Size = new System.Drawing.Size(205, 25);
            this.labelSYSTEMUPTIME.TabIndex = 2;
            this.labelSYSTEMUPTIME.Text = "SYSTEM UP TIME";
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
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(52, 149);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(119, 25);
            this.labelDateTime.TabIndex = 5;
            this.labelDateTime.Text = "Date Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelSYSTEMUPTIME);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelCPUUSAGE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPUUSAGE;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelSYSTEMUPTIME;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDateTime;
    }
}

