namespace MStockAnalysis
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
            this.bReadCSVs = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.bSTOP = new System.Windows.Forms.Button();
            this.bgReadCSVs = new System.ComponentModel.BackgroundWorker();
            this.bgReadCSVs.WorkerReportsProgress = true;
            this.bgReadCSVs.WorkerSupportsCancellation = true;
            this.SuspendLayout();
            // 
            // bReadCSVs
            // 
            this.bReadCSVs.Location = new System.Drawing.Point(12, 12);
            this.bReadCSVs.Name = "bReadCSVs";
            this.bReadCSVs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bReadCSVs.Size = new System.Drawing.Size(86, 28);
            this.bReadCSVs.TabIndex = 0;
            this.bReadCSVs.Text = "Read CSVs";
            this.bReadCSVs.UseVisualStyleBackColor = true;
            this.bReadCSVs.Click += new System.EventHandler(this.ReadCSVs_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(16, 87);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(712, 163);
            this.txtConsole.TabIndex = 1;
            // 
            // bSTOP
            // 
            this.bSTOP.Location = new System.Drawing.Point(121, 12);
            this.bSTOP.Name = "bSTOP";
            this.bSTOP.Size = new System.Drawing.Size(86, 28);
            this.bSTOP.TabIndex = 2;
            this.bSTOP.Text = "STOP";
            this.bSTOP.UseVisualStyleBackColor = true;
            this.bSTOP.Click += new System.EventHandler(this.STOP);
            // 
            // bgReadCSVs
            // 
            this.bgReadCSVs.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgReadCSVs_DoWork);
            this.bgReadCSVs.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgReadCSVs_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 342);
            this.Controls.Add(this.bSTOP);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.bReadCSVs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bReadCSVs;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button bSTOP;
        private System.ComponentModel.BackgroundWorker bgReadCSVs;
    }
}

