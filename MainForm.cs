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
            //Заглушка, чтобы не вводить логин и пароль на время разработки
            Authorization.PersonID = "1";
            Authorization.RoleID = "2";

            if (Authorization.RoleID == "1")
            {
                Tree.Nodes[0].Nodes["Log"].Remove(); //Удаление определенного узла
                Tree.Nodes[0].Nodes["Parking"].Remove();
            }
            Tree.ExpandAll();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)//Загрузка User Control в зависимости от выбранного узла дерева
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

        private void PlaceInfoLoad()//загрузка информации о парковочном месте пользователя
        {
            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConStr);
            SqlDataReader PlaceInfoReader;
            SqlDataReader CarInfoReader;
            try
            {
                //Объявление параметров для загрузки информации по парковочному месту
                SqlCommand PlaceInfoSQLCommand = new SqlCommand();
                SqlDataAdapter PlaceInfoDataAdapter = new SqlDataAdapter();
                DataSet PlaceInfoDataSet = new DataSet();

                //Объявление параметров для загрузки информации по машинам пользователя
                SqlCommand CarInfoSQLCommand = new SqlCommand();
                SqlDataAdapter CarInfoDataAdapter = new SqlDataAdapter();
                DataSet CarInfoDataSet = new DataSet();

                //Выборка информации по парковочному месту
                PlaceInfoSQLCommand.CommandText = "PlaceInfoLoad";
                PlaceInfoSQLCommand.CommandType = CommandType.StoredProcedure;
                PlaceInfoSQLCommand.Parameters.AddWithValue("@PersonID", Authorization.PersonID);
                PlaceInfoSQLCommand.Connection = con;
                con.Open();
                PlaceInfoReader = PlaceInfoSQLCommand.ExecuteReader();
                PlaceInfoDataAdapter.SelectCommand = PlaceInfoSQLCommand;
                PlaceInfoReader.Close();
                PlaceInfoDataAdapter.Fill(PlaceInfoDataSet, "Parking");

                //Выборка информации по машинам
                CarInfoSQLCommand.CommandText = "CarInfoLoad";
                CarInfoSQLCommand.CommandType = CommandType.StoredProcedure;
                CarInfoSQLCommand.Parameters.AddWithValue("@PersonID", Authorization.PersonID);
                CarInfoSQLCommand.Connection = con;
                CarInfoReader = CarInfoSQLCommand.ExecuteReader();
                CarInfoDataAdapter.SelectCommand = CarInfoSQLCommand;
                CarInfoReader.Close();
                CarInfoDataAdapter.Fill(CarInfoDataSet, "Parking");

                //Подключение User Control для отображения информации о парковочном месте и машинам пользователя
                PlaceUC PlaceUC = new PlaceUC();
                splitContainer.Panel2.Controls.Clear();
                splitContainer.Panel2.Controls.Add(PlaceUC);
                PlaceUC.PlaceNumberLabel.Text ="Место: " + PlaceInfoDataSet.Tables[0].Rows[0][0].ToString();
                PlaceUC.PlaceStatusLabel.Text = "Статус: " + PlaceInfoDataSet.Tables[0].Rows[0][1].ToString();
                PlaceUC.DateFromLabel.Text = "Дата с: " + PlaceInfoDataSet.Tables[0].Rows[0][2].ToString().Remove(11,7);
                PlaceUC.DateToLabel.Text = "Дата по: " + PlaceInfoDataSet.Tables[0].Rows[0][3].ToString().Remove(11,7);
                PlaceUC.CarDGV.DataSource = CarInfoDataSet.Tables[0];
              //  PlaceUC.CarDGV.Columns[0].Visible = false;
                PlaceUC.CarDGV.Columns[0].HeaderCell.Value = "Марка";
                PlaceUC.CarDGV.Columns[1].HeaderCell.Value = "Модель";
                PlaceUC.CarDGV.Columns[2].HeaderCell.Value = "Регистрационный номер";
            }
            finally
            {
                con.Close();
            }
        }
        
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) //закрытие приложения
        {
            Application.Exit();
        }
    }
}
