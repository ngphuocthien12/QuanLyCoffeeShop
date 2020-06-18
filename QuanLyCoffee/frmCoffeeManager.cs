using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyCoffee
{
    public partial class frmCoffeeManager : Form
    {
        public frmCoffeeManager()
        {
            InitializeComponent();
            LoadCategory();
        }
        //hiển thị bàn
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
                btn.Click += Btn_Click;
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
        //hiển thị hóa đơn theo bàn
        ItemBUS itemBUS = new ItemBUS();
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DataRow table = (DataRow)btn.Tag;

            int tableID = Int32.Parse(table[0].ToString());

            DataTable dt = itemBUS.Get(tableID);
            dgvItem.DataSource = dt;
             // tính tổng tiền
            float total = 0;
            if (table[2].ToString() == "Có người")
            {
                foreach (DataRow row in dt.Rows)
                {
                    total += float.Parse(row["TTien"].ToString());
                }
                txtTTien.Text = total.ToString();
            }
            else txtTTien.Text = total.ToString("0");
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CategoryBUS categoryBUS = new CategoryBUS();
        public void LoadCategory()
        {
            List<Category> listCategory = categoryBUS.LoadCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "name";
        }

       

      
    }
}
