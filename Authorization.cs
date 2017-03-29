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
        public static string PersonID, RoleID;
        public Authorization()
        {
            InitializeComponent();
        }
        private void Login() //Авторизация
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader reader;
            try
            {
               
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd.CommandText = "Authorization";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", UsernameTB.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();
                da.SelectCommand = cmd;
                reader.Close();
                da.Fill(ds, "Parking");
                if (ds.Tables[0].Rows[0][2].ToString() == "")
                {
                    PersonID = ds.Tables[0].Rows[0][0].ToString();
                    RoleID = ds.Tables[0].Rows[0][1].ToString();
                    ActiveForm.Hide();
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
                Login();
            }
        }
    }
}
