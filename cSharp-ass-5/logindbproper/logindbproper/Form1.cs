using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace logindbproper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSC-COMP-19;Initial Catalog=user;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
            try
            {
                String querry = "SELECT * FROM login WHERE username='" + txt_username.Text + "' AND password='" + txt_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;

                    user_password = txt_password.Text;
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid details");
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("invalid login");
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}