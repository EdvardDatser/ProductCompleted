using System.Windows.Forms;

namespace Tooded
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Kat_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lisa_Kat = new System.Windows.Forms.Button();
            this.Toode_lb = new System.Windows.Forms.Label();
            this.Kogus_lb = new System.Windows.Forms.Label();
            this.Hind_lb = new System.Windows.Forms.Label();
            this.HindBox = new System.Windows.Forms.TextBox();
            this.KogusBox = new System.Windows.Forms.TextBox();
            this.Kustuta_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ToodeBox = new System.Windows.Forms.TextBox();
            this.Toode_pb = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKassa = new System.Windows.Forms.Button();
            this.admin_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 225);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.Size = new System.Drawing.Size(647, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick_1);
            // 
            // Kat_Box
            // 
            this.Kat_Box.FormattingEnabled = true;
            this.Kat_Box.Location = new System.Drawing.Point(106, 169);
            this.Kat_Box.Name = "Kat_Box";
            this.Kat_Box.Size = new System.Drawing.Size(121, 21);
            this.Kat_Box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(11, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategooriad:";
            // 
            // Lisa_Kat
            // 
            this.Lisa_Kat.AccessibleName = "Lisa_Kat";
            this.Lisa_Kat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Lisa_Kat.Location = new System.Drawing.Point(168, 196);
            this.Lisa_Kat.Name = "Lisa_Kat";
            this.Lisa_Kat.Size = new System.Drawing.Size(59, 21);
            this.Lisa_Kat.TabIndex = 3;
            this.Lisa_Kat.Tag = "Lisa_Kat";
            this.Lisa_Kat.Text = "Lisa kategooria";
            this.Lisa_Kat.UseVisualStyleBackColor = true;
            this.Lisa_Kat.Click += new System.EventHandler(this.Lisa_Kat_Click_1);
            // 
            // Toode_lb
            // 
            this.Toode_lb.Location = new System.Drawing.Point(0, 0);
            this.Toode_lb.Name = "Toode_lb";
            this.Toode_lb.Size = new System.Drawing.Size(100, 23);
            this.Toode_lb.TabIndex = 16;
            // 
            // Kogus_lb
            // 
            this.Kogus_lb.Location = new System.Drawing.Point(0, 0);
            this.Kogus_lb.Name = "Kogus_lb";
            this.Kogus_lb.Size = new System.Drawing.Size(100, 23);
            this.Kogus_lb.TabIndex = 15;
            // 
            // Hind_lb
            // 
            this.Hind_lb.Location = new System.Drawing.Point(0, 0);
            this.Hind_lb.Name = "Hind_lb";
            this.Hind_lb.Size = new System.Drawing.Size(100, 23);
            this.Hind_lb.TabIndex = 14;
            // 
            // HindBox
            // 
            this.HindBox.Location = new System.Drawing.Point(85, 72);
            this.HindBox.Name = "HindBox";
            this.HindBox.Size = new System.Drawing.Size(100, 20);
            this.HindBox.TabIndex = 12;
            // 
            // KogusBox
            // 
            this.KogusBox.Location = new System.Drawing.Point(85, 45);
            this.KogusBox.Name = "KogusBox";
            this.KogusBox.Size = new System.Drawing.Size(100, 20);
            this.KogusBox.TabIndex = 11;
            // 
            // Kustuta_btn
            // 
            this.Kustuta_btn.AccessibleName = "Kustuta_btn";
            this.Kustuta_btn.Location = new System.Drawing.Point(106, 196);
            this.Kustuta_btn.Name = "Kustuta_btn";
            this.Kustuta_btn.Size = new System.Drawing.Size(56, 21);
            this.Kustuta_btn.TabIndex = 10;
            this.Kustuta_btn.Text = "Kustuta";
            this.Kustuta_btn.UseVisualStyleBackColor = true;
            this.Kustuta_btn.Click += new System.EventHandler(this.KustutaKat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Toode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Kogus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(15, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hind";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(614, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Lisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ToodeBox
            // 
            this.ToodeBox.Location = new System.Drawing.Point(85, 20);
            this.ToodeBox.Name = "ToodeBox";
            this.ToodeBox.Size = new System.Drawing.Size(100, 20);
            this.ToodeBox.TabIndex = 13;
            // 
            // Toode_pb
            // 
            this.Toode_pb.Location = new System.Drawing.Point(259, 39);
            this.Toode_pb.Name = "Toode_pb";
            this.Toode_pb.Size = new System.Drawing.Size(229, 178);
            this.Toode_pb.TabIndex = 21;
            this.Toode_pb.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "Lisa uus pilt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 24);
            this.button3.TabIndex = 23;
            this.button3.Text = "Kustuta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKassa
            // 
            this.btnKassa.Location = new System.Drawing.Point(536, 41);
            this.btnKassa.Name = "btnKassa";
            this.btnKassa.Size = new System.Drawing.Size(123, 27);
            this.btnKassa.TabIndex = 24;
            this.btnKassa.Text = "Kassa";
            this.btnKassa.UseVisualStyleBackColor = true;
            this.btnKassa.Click += new System.EventHandler(this.btnKassa_Click);
            // 
            // admin_btn
            // 
            this.admin_btn.Location = new System.Drawing.Point(536, 80);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(123, 30);
            this.admin_btn.TabIndex = 25;
            this.admin_btn.Text = "Kasutaja kontroll";
            this.admin_btn.UseVisualStyleBackColor = true;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Navigeerimine";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(671, 387);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.btnKassa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Toode_pb);
            this.Controls.Add(this.ToodeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Kustuta_btn);
            this.Controls.Add(this.KogusBox);
            this.Controls.Add(this.HindBox);
            this.Controls.Add(this.Hind_lb);
            this.Controls.Add(this.Kogus_lb);
            this.Controls.Add(this.Toode_lb);
            this.Controls.Add(this.Lisa_Kat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kat_Box);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Toode_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void DataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }



        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox Kat_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lisa_Kat;
        private Label Toode_lb;
        private Label Kogus_lb;
        private Label Hind_lb;
        private TextBox HindBox;
        private TextBox KogusBox;
        private Button Kustuta_btn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox ToodeBox;
        private PictureBox Toode_pb;
        private Button button2;
        private Button button3;
        private Button btnKassa;
        private Button admin_btn;
        private Label label5;
    }
}

