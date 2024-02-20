using Newtonsoft.Json.Serialization;
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
    public partial class AdminPanel : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-NEVLUCA;Initial Catalog=ToodeDatabase;Integrated Security=True;Encrypt=False");

        SqlDataAdapter adapter_toode;
        SqlCommand command;
        public AdminPanel()
        {
            InitializeComponent();
            NaitaAndmed();
        }

        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Id, nimi, pass, email, identify from Kasutajad", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = dt_toode;
            connect.Close();
        }

        private void DataGridView3_RowHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            int Id = (int)dataGridView3.Rows[e.RowIndex].Cells["Id"].Value;
            nimiBox.Text = dataGridView3.Rows[e.RowIndex].Cells["nimi"].Value.ToString();
            paroolBox.Text = dataGridView3.Rows[e.RowIndex].Cells["pass"].Value.ToString();
            emailBox.Text = dataGridView3.Rows[e.RowIndex].Cells["email"].Value.ToString();
        }

        private void lisaBtn_Click(object sender, EventArgs e)
        {
            if (nimiBox.Text.Trim() != string.Empty && paroolBox.Text.Trim() != string.Empty)
            {
                try
                {
                    command = new SqlCommand("INSERT INTO Kasutajad(nimi, pass, email, identify) values(@nimi, @pass, @email, 'Klient')", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@nimi", nimiBox.Text);
                    command.Parameters.AddWithValue("@pass", paroolBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }

        private void uuendaBtn_Click(object sender, EventArgs e)
        {
            if (nimiBox.Text.Trim() != string.Empty && paroolBox.Text.Trim() != string.Empty)
            {
                int id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["Id"].Value);
                try
                {
                    command = new SqlCommand("UPDATE Kasutajad SET nimi = @nimi, pass = @pass, email = @email where Id = @Id", connect);
                    connect.Open();
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@nimi", nimiBox.Text);
                    command.Parameters.AddWithValue("@pass", paroolBox.Text);
                    command.Parameters.AddWithValue("@email", emailBox.Text);

                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
        }

        private void kustutaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count >= 0)
            {
                int id = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["Id"].Value);

                connect.Open();
                command = new SqlCommand("DELETE FROM Kasutajad WHERE Id = @id", connect);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                connect.Close();
                NaitaAndmed();
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
