using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Tooded
{
    public partial class Form1 : Form
    {
        
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NEVLUCA;Initial Catalog=ToodeDatabase;Integrated Security=True;Encrypt=False");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
        }

        private void Lisa_Kat_Click_1(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var item in Kat_Box.Items)
            {
                if (item.ToString() == Kat_Box.Text)
                {
                    on = true;
                }
            }
            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatable(Kategooria_nimetus) values(@Kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@Kat", Kat_Box.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooriat on juba olemas!");
            }
        }
        public void NaitaKategooriad()
        {
            Kat_Box.Items.Clear();
            Kat_Box.Text = "";
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Kategooria_nimetus, Id FROM Kategooriatable", connect);
            DataTable dt_kategooria = new DataTable();
            adapter_kategooria.Fill(dt_kategooria);
            foreach (DataRow nimetus in dt_kategooria.Rows)
            {
                if (!Kat_Box.Items.Contains(nimetus["Kategooria_nimetus"]))
                {
                    Kat_Box.Items.Add(nimetus["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooriatable WHERE Id = @id", connect);
                    command.Parameters.AddWithValue("@id", nimetus["Id"]);
                    command.ExecuteNonQuery();
                }
            }
            connect.Close();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            //ComboBox comboBox = new ComboBox();
            DataTable dt_toode = new DataTable();
            //DataTable table = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, K.Kategooria_nimetus as Kategooria FROM Toodetabel as T INNER JOIN Kategooriatable as K on T.Kategooriad=K.Id", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.HeaderText = "Kategooria";
            combo_kat.Name = "KategooriaColumn";
            combo_kat.DataPropertyName = "Kategooria";
            HashSet<string> uniqueCategories = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string category = item["Kategooria"].ToString();
                if (!uniqueCategories.Contains(category))
                {
                    uniqueCategories.Add(category);
                    combo_kat.Items.Add(category);
                }
            }
            dataGridView2.Columns.Add(combo_kat);
            dataGridView2.Columns["Kategooria"].Visible = false;
            connect.Close();
        }

        private void KustutaKat_Click(object sender, EventArgs e)
        {
            if (Kat_Box.SelectedItem != null)
            {
                string val_kat = Kat_Box.SelectedItem.ToString();

                command = new SqlCommand("DELETE FROM Kategooriatable WHERE Kategooria_nimetus = @Kat", connect);
                connect.Open();
                command.Parameters.AddWithValue("@Kat", val_kat);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaKategooriad();
            }
        }

        int Id = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ToodeBox.Text.Trim() != string.Empty && KogusBox.Text.Trim() != string.Empty && HindBox.Text.Trim() != string.Empty && Kat_Box.SelectedItem != null)
            {
                try
                {
                    connect.Open();

                    command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@Kat", connect);
                    command.Parameters.AddWithValue("@Kat", Kat_Box.Text);
                    command.ExecuteNonQuery();
                    Id = Convert.ToInt32(command.ExecuteScalar());

                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Kategooriad) VALUES (@toode, @kogus ,@hind, @pilt, @kat)", connect);
                    command.Parameters.AddWithValue("@toode", ToodeBox.Text);
                    command.Parameters.AddWithValue("@kogus", KogusBox.Text);
                    command.Parameters.AddWithValue("@hind", HindBox.Text);
                    command.Parameters.AddWithValue("@pilt", ToodeBox.Text + ".jpg");
                    command.Parameters.AddWithValue("@kat", Id);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count >= 0)
            {
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);

                connect.Open();
                command = new SqlCommand("DELETE FROM Toodetabel WHERE Id = @id", connect);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_Box.Items.Clear();
                NaitaAndmed();
            }
        }
        //string kat;
        //SaveFileDialog save;
        OpenFileDialog open;

        private void button2_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\\Users\\opilane\\Pictures";
            open.Multiselect = true;
            open.Filter = "Images Files(*.jpeg, *.bmp, *.png, *.jpg)|*.jpeg; *.bmp; *.png; *.jpg";


            FileInfo open_info = new FileInfo(@"C:\\Users\\opilane\\Pictures" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && ToodeBox.Text != null)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = ToodeBox.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && ToodeBox.Text != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    Toode_pb.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btnKassa_Click(object sender, EventArgs e)
        {
            var Kassa = new Kassa();
            Kassa.ShowDialog();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            var Kliendid = new AdminPanel();
            Kliendid.ShowDialog();
        }

        private void dataGridView2_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = (int)dataGridView2.Rows[e.RowIndex].Cells["Id"].Value;
            ToodeBox.Text = dataGridView2.Rows[e.RowIndex].Cells["Toodenimetus"].Value.ToString();
            KogusBox.Text = dataGridView2.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
            HindBox.Text = dataGridView2.Rows[e.RowIndex].Cells["Hind"].Value.ToString();
            try
            {
                Toode_pb.SizeMode = PictureBoxSizeMode.StretchImage;
                Toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Images"), dataGridView2.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pilt puudub" + ex.Message);
            }
            Kat_Box.SelectedItem = dataGridView2.Rows[e.RowIndex].Cells[5].Value;
        }
    }
}

//create table Kategooriatable(
//Id int not null primary key identity(1,1),
//Kategooria_nimetus varchar(100),
//Kirjandus text
//);

//create table Toodetabel(
//Id int not null primary key identity(1,1),
//Toodenimetus varchar(100),
//Kogus int,
//Hind int,
//Pilt text,
//Kategooriad int,
//foreign key (Kategooriad) references Kategooriatable(Id)
//);

//create table Kasutajad(
//	Id int primary key identity(1,1) not null,
//    nimi varchar(30),
//    pass varchar(30),
//      email varchar(30),
//    identify varchar(10)
//    kliendikaart bit,
//    boonus int
//);

//insert into Kasutajad(nimi, pass, identify)
//values('admin', 'admin', 'Omanik');
//insert into Kasutajad(nimi, pass, identify)
//values('test', 'test', 'Müüja');
