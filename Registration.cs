using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tooded
{
    public partial class Registration : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NEVLUCA;Initial Catalog=ToodeDatabase;Integrated Security=True;Encrypt=False");

        SqlDataAdapter adapter_toode, adapter_kategooria;
        SqlCommand command;
        int kliendikaart = 0;
        int boonus = 0;
        public Registration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                kliendikaart = 1;
                boonus = 10;
            }
            else
            {
                kliendikaart = 0;
                boonus = 0;
            }
        }

        private void lbllog_Click(object sender, EventArgs e)
        {

        }

        private void txtboxPass_TextChanged(object sender, EventArgs e)
        {
            txtboxPass.PasswordChar = '*';
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool on = false;

            if (ToString() == txtboxLog.Text && ToString() == txtboxPass.Text)
            {
                on = true;
            }
            
            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kasutajad(nimi, pass, email, identify, kliendikaart, boonus) values(@nimi, @pass, @email, 'Klient', @kliendikaart, @boonus)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@nimi", txtboxLog.Text);
                command.Parameters.AddWithValue("@pass", txtboxPass.Text);
                command.Parameters.AddWithValue("@email", txtboxEmail.Text);
                command.Parameters.AddWithValue("@kliendikaart", kliendikaart);
                command.Parameters.AddWithValue("@boonus", boonus);
                command.ExecuteNonQuery();
                connect.Close();

                this.Hide();
                var login = new Sissepäass();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selline inimene on juba olemas!");
            }
        }
    }
}
