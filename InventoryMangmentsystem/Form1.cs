using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace InventoryMangmentsystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ztech.pk\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registerform2 regForm = new Registerform2();
            regForm.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
   
        }

        private void cross_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
  
        }
        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (checkConnection()) {

                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM users WHERE username=@name AND password=@password";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@name", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable tabel = new DataTable();
                        adapter.Fill(tabel);

                        if (tabel.Rows.Count>0)
                        {
                            MessageBox.Show("Login Successful!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm mform = new MainForm();
                            mform.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Invalid username/password or there's is no Admin's approval", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed!" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            if (login_username.Text == "" || login_password.Text == "" )
            {
                MessageBox.Show("Please fill all the fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
