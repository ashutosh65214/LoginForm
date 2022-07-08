using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        private SqlConnection obj = null;
        private SqlCommand cmd = null;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUseName.Text == "")
            {
                MessageBox.Show("Enter the user name");
            }
            else if(TxtPassword.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    using (obj = new SqlConnection(ConfigurationManager.ConnectionStrings["Login"].ConnectionString))
                    {
                        using (cmd = new SqlCommand("Select * from Login where EmailId=@username and password=@password", obj))
                        {
                            cmd.Parameters.AddWithValue("@username", TxtUseName.Text);
                            cmd.Parameters.AddWithValue("@password", TxtPassword.Text);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            da.Fill(dt);
                            if(dt.Rows.Count > 0)
                            {
                                MessageBox.Show("Login Sucessfull");
                            }
                            else
                            {
                                MessageBox.Show("username or password in incorrect");
                            }

                        }
                    }
                   


                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }


        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
                
                
        }
    }
}
