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
using System.Configuration;

namespace ParkingSystem
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void login() //Авторизация11123
        {
            
            string constring = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(constring);
            try
            {
               
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd.CommandText = @"SELECT * FROM Users WHERE Login='" + UsernameTB.Text + "'AND Password='" + PasswordTB.Text + "';";
                con.Open();
                cmd.Connection = con;
                da.SelectCommand = cmd;
                da.Fill(ds, "0");
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    Authorization.ActiveForm.Hide();
                    MainForm MainForm = new MainForm();
                    MainForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            UsernameTB.Text = "user";
            PasswordTB.Text = "user";
            if (UsernameTB.Text == "" | PasswordTB.Text == "")
            {
                MessageBox.Show("Введите логин и пароль!");
            }
            else
            {
                login();
            }
        }
    }
}
