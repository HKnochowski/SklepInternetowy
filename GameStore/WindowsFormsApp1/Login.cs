using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;

            SqlConnectionStringBuilder connStringBuilder;

            
                connStringBuilder = new SqlConnectionStringBuilder();
                connStringBuilder.DataSource = "DESKTOP-B4P8S8M";
                connStringBuilder.InitialCatalog = "GameStore.Data_Access_Layer.StoreGameContext";
                connStringBuilder.Encrypt = true;
                connStringBuilder.TrustServerCertificate = true;
                connStringBuilder.ConnectTimeout = 30;
                connStringBuilder.AsynchronousProcessing = true;
                connStringBuilder.MultipleActiveResultSets = true;
                connStringBuilder.IntegratedSecurity = true;

                conn = new SqlConnection(connStringBuilder.ToString());
                comm = conn.CreateCommand();
            


            //SqlConnection con = new SqlConnection(@"DataSource = DESKTOP-B4P8S8M;InitialCatalog = GameStore.Data_Access_Layer.StoreGameContext; Encrypt = true;TrustServerCertificate = true;ConnectTimeout = 30;AsynchronousProcessing = true;MultipleActiveResultSets = true;IntegratedSecurity = true;");
            

            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Employer Where EmployerLogin='"+textBoxLogin.Text+"' and EmployerPassword='"+textBoxPassword.Text+"'",conn);
            SqlDataAdapter clientsda = new SqlDataAdapter("Select Count (*) From Client Where LoginClient='" + textBoxLogin.Text + "' and PasswordClient='" + textBoxPassword.Text + "'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataTable cdt = new DataTable();
            clientsda.Fill(cdt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Menu m = new Menu();
                m.Show();
            }
            else if (cdt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                ClientMenu cm = new ClientMenu();
                cm.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane do logowania");
            }

            
        }
    }
}
