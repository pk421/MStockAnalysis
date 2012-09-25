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
            this.txtSayHello = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSayHello
            // 
            this.txtSayHello.Location = new System.Drawing.Point(16, 18);
            this.txtSayHello.Name = "txtSayHello";
            this.txtSayHello.Size = new System.Drawing.Size(149, 63);
            this.txtSayHello.TabIndex = 0;
            this.txtSayHello.Text = "SayHello";
            this.txtSayHello.UseVisualStyleBackColor = true;
            this.txtSayHello.Click += new System.EventHandler(this.txtSayHello_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 342);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtSayHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSayHello;
        private System.Windows.Forms.TextBox txtConsole;
    }
}

