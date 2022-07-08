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
    public partial class Form1 : Form
    {
        private SqlConnection obj = null;
        private SqlCommand cmd = null;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void reset()
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            TxtEmailId.Clear();
            TxtPassword.Clear();
            TxtConformPassword.Clear();
            
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            using (obj = new SqlConnection(ConfigurationManager.ConnectionStrings["Login"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_LoginAdd", obj))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", DtpBirthDate.Text);
                    cmd.Parameters.AddWithValue("@Gender", ComboGender.Text);
                    cmd.Parameters.AddWithValue("@EmailId ", TxtEmailId.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                    cmd.Parameters.AddWithValue("@ConformPassword", TxtConformPassword.Text);
                    if (obj.State == ConnectionState.Closed)
                    {
                        obj.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Regesiter Sucessfully");
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.reset();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }

}
    

