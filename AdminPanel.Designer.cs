namespace Tooded
{
    partial class AdminPanel
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nimiBox = new System.Windows.Forms.TextBox();
            this.paroolBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lisaBtn = new System.Windows.Forms.Button();
            this.uuendaBtn = new System.Windows.Forms.Button();
            this.kustutaBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(348, 76);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(517, 164);
            this.dataGridView3.TabIndex = 0;
            // 
            // nimiBox
            // 
            this.nimiBox.Location = new System.Drawing.Point(152, 144);
            this.nimiBox.Name = "nimiBox";
            this.nimiBox.Size = new System.Drawing.Size(159, 20);
            this.nimiBox.TabIndex = 1;
            // 
            // paroolBox
            // 
            this.paroolBox.Location = new System.Drawing.Point(152, 197);
            this.paroolBox.Name = "paroolBox";
            this.paroolBox.Size = new System.Drawing.Size(159, 20);
            this.paroolBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(152, 250);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(159, 20);
            this.emailBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kasutaja nimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-mail";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lisaBtn
            // 
            this.lisaBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lisaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lisaBtn.Location = new System.Drawing.Point(111, 303);
            this.lisaBtn.Name = "lisaBtn";
            this.lisaBtn.Size = new System.Drawing.Size(134, 23);
            this.lisaBtn.TabIndex = 7;
            this.lisaBtn.Text = "Lisa kasutaja";
            this.lisaBtn.UseVisualStyleBackColor = true;
            this.lisaBtn.Click += new System.EventHandler(this.lisaBtn_Click);
            // 
            // uuendaBtn
            // 
            this.uuendaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uuendaBtn.Location = new System.Drawing.Point(537, 367);
            this.uuendaBtn.Name = "uuendaBtn";
            this.uuendaBtn.Size = new System.Drawing.Size(134, 23);
            this.uuendaBtn.TabIndex = 8;
            this.uuendaBtn.Text = "Uuenda kasutaja andmed";
            this.uuendaBtn.UseVisualStyleBackColor = true;
            this.uuendaBtn.Click += new System.EventHandler(this.uuendaBtn_Click);
            // 
            // kustutaBtn
            // 
            this.kustutaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kustutaBtn.Location = new System.Drawing.Point(537, 321);
            this.kustutaBtn.Name = "kustutaBtn";
            this.kustutaBtn.Size = new System.Drawing.Size(134, 23);
            this.kustutaBtn.TabIndex = 9;
            this.kustutaBtn.Text = "Kustuta kasutaja";
            this.kustutaBtn.UseVisualStyleBackColor = true;
            this.kustutaBtn.Click += new System.EventHandler(this.kustutaBtn_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lisa kasutaja vorm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(506, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Admin õigus:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kustutaBtn);
            this.Controls.Add(this.uuendaBtn);
            this.Controls.Add(this.lisaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.paroolBox);
            this.Controls.Add(this.nimiBox);
            this.Controls.Add(this.dataGridView3);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox nimiBox;
        private System.Windows.Forms.TextBox paroolBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lisaBtn;
        private System.Windows.Forms.Button uuendaBtn;
        private System.Windows.Forms.Button kustutaBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}