using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ParkingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if (Authorization.RoleID == "1")
            {
                Tree.Nodes[0].Nodes["Log"].Remove(); //Удаление определенного узла
                Tree.Nodes[0].Nodes["Parking"].Remove();
            }
            Tree.ExpandAll();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "Place":
                    {
                       PlaceInfoLoad();
                    }
                    break;
                case "Application":
                    {
                        
                    }
                    break;
                case "Log":
                    {

                    }
                    break;
                case "Parking":
                    {

                    }
                    break;
            }
        }

        private void PlaceInfoLoad()
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader reader;
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                cmd.CommandText = "PlaceInfoLoad";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PersonID", 1);
                cmd.Connection = con;
                con.Open();
                reader = cmd.ExecuteReader();
                da.SelectCommand = cmd;
                reader.Close();
                da.Fill(ds, "Parking");
                PlaceUC PlaceUC = new PlaceUC();
                splitContainer.Panel2.Controls.Clear();
                splitContainer.Panel2.Controls.Add(PlaceUC);
                PlaceUC.PlaceNumberLabel.Text ="Место: " + ds.Tables[0].Rows[0][0].ToString();
                PlaceUC.PlaceStatusLabel.Text = "Статус: " + ds.Tables[0].Rows[0][1].ToString();
                PlaceUC.DateFromLabel.Text = "Дата с: " + ds.Tables[0].Rows[0][2].ToString();
                PlaceUC.DateToLabel.Text = "Дата по: " + ds.Tables[0].Rows[0][3].ToString();
            }
            finally
            {
                con.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }//закрытие приложения
    }
}
