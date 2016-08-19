using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Tree.ExpandAll();
            

        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "Place":
                    {
                       PlaceUC PlaceUC = new PlaceUC();
                       splitContainer.Panel2.Controls.Clear();
                       splitContainer.Panel2.Controls.Add(PlaceUC);
                       
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
