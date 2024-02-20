namespace Tooded
{
    partial class Sissepäass
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbLog = new System.Windows.Forms.TextBox();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logi sisse";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbLog
            // 
            this.txtbLog.Location = new System.Drawing.Point(92, 139);
            this.txtbLog.Name = "txtbLog";
            this.txtbLog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbLog.Size = new System.Drawing.Size(198, 21);
            this.txtbLog.TabIndex = 1;
            this.txtbLog.Text = "Kasutaja nimi";
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(92, 178);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(198, 21);
            this.txtbPass.TabIndex = 2;
            this.txtbPass.Text = "Parool";
            this.txtbPass.UseWaitCursor = true;
            this.txtbPass.TextChanged += new System.EventHandler(this.txtbPass_TextChanged);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(228, 223);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(62, 21);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "Sisene";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(92, 223);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(93, 21);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Registreerimine";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Sissepäass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 313);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtbPass);
            this.Controls.Add(this.txtbLog);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "Sissepäass";
            this.Text = "Sissepääs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbLog;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnReg;
    }
}