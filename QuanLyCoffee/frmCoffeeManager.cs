using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyCoffee
{
    public partial class frmCoffeeManager : Form
    {
        public frmCoffeeManager()
        {
            InitializeComponent();
        }

        TableBUS tabBUS = new TableBUS();
        private void frmCoffeeManager_Load(object sender, EventArgs e)
        {

            DataTable tables = tabBUS.Get();
            foreach (DataRow table in tables.Rows)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 100);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.Text = table[1].ToString() + Environment.NewLine + Environment.NewLine + table[2].ToString();
                //btn.Click += Btn_Click;
                btn.Tag = table;

                switch (table[2].ToString())
                {
                    case "Có người":
                        btn.BackgroundImage = QuanLyCoffee.Properties.Resources.coffeeColor;
                        break;
                    default:
                        btn.BackgroundImage = QuanLyCoffee.Properties.Resources.coffeeBlack;
                        break;
                }
                flpTable.Controls.Add(btn);
            }

        }
      

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
