using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        string connString = "Server=localhost;Uid=root;Database=cs_harcosok";
        public MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            loadHarcosok();
        }

        private void Nev_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadHarcosok()
        {
            conn = new MySqlConnection(connString);
            {
                MySqlCommand GET = new MySqlCommand("Select * from harcosok", conn);

                conn.Open();

                MySqlDataReader reader = GET.ExecuteReader();

                hasznaloComboBox.Items.Clear();
                harcosokListBox.Items.Clear();

                while (reader.Read())
                {
                    string harcos = (reader.GetString("id"));

                    hasznaloComboBox.Items.Add(reader.GetString("id"));
                    harcosokListBox.Items.Add(reader.GetString("id"));
                }

                conn.Close();
            }
        }

        private void loadKepessegek(int id)
        {
            conn = new MySqlConnection(connString);
            {
                MySqlCommand GET = new MySqlCommand("SELECT * FROM kepessegek WHERE harcos_id = " + id, conn);

                conn.Open();

                MySqlDataReader reader = GET.ExecuteReader();

                kepessegekListBox.Items.Clear();


                while (reader.Read())
                {
                    
                    kepessegekListBox.Items.Add(reader.GetString("nev"));
                }

                conn.Close();
            }
        }

        private void loadKepessegLeiras(string nev)
        {
            conn = new MySqlConnection(connString);
            {
                string sql = "SELECT `leiras` FROM `kepessegek` WHERE nev = '" + nev +"'";
                MySqlCommand GET = new MySqlCommand(sql, conn);

                conn.Open();

                MySqlDataReader reader = GET.ExecuteReader();

                


                while (reader.Read())
                {

                    kepessegLeirasTextBox.Text = (reader.GetString("leiras"));
                }

                conn.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                {
                    MySqlCommand SET = new MySqlCommand("Insert into kepessegek(nev, leiras, harcos_id) values(@name, @disc, @id)", conn);
                    SET.Parameters.AddWithValue("@name", kepessegNeveTextBox.Text);
                    SET.Parameters.AddWithValue("@disc", leirasTextBox.Text);
                    SET.Parameters.AddWithValue("@id", hasznaloComboBox.SelectedItem);

                    conn.Open();
                    SET.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sikeres felvetel.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen felvetel.");
                
            }
            
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                {

                    MySqlCommand SET = new MySqlCommand("Insert into harcosok(nev) values(@nev)", conn);
                    SET.Parameters.AddWithValue("@nev", harcosNeveTextBox.Text);

                    conn.Open();
                    SET.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sikeres felvetel.");
                    loadHarcosok();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen felvetel.");
            }


            
        }

        private void harcosokListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(harcosokListBox.SelectedItem.ToString());
            loadKepessegek(id);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                {
                    string sql = "DELETE FROM kepessegek WHERE nev = '" + kepessegekListBox.SelectedItem + "'";
                    MySqlCommand SET = new MySqlCommand(sql, conn);

                    Console.WriteLine(sql);

                    conn.Open();
                    SET.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sikeres torles.");

                    int id = int.Parse(harcosokListBox.SelectedItem.ToString());
                    loadKepessegek(id);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sikertelen torles.");
            }
            
        }

        private void kepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nev = kepessegekListBox.SelectedItem.ToString();
            loadKepessegLeiras(nev);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                {
                    string sql = "UPDATE `kepessegek` SET `leiras`='" + kepessegLeirasTextBox.Text + "' WHERE nev ='" + kepessegekListBox.SelectedItem + "'";
                    MySqlCommand SET = new MySqlCommand(sql, conn);

                    Console.WriteLine(sql);

                    conn.Open();
                    SET.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Sikeres modositas.");

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sikertelen torles.");
            }
        }
    }
}
