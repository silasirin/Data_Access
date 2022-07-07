using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_Northwind
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void GetOrders()
        {
            listView1.Items.Clear();

            foreach (Order order in db.Orders)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = order.OrderID.ToString();
                lvi.SubItems.Add(order.OrderDate.ToString());
                listView1.Items.Add(lvi);
            }
        }
        private void GetOrders(bool val)
        {
            List<Order> orders;

            listView1.Items.Clear();
            if (val)
            {
                orders = db.Orders.OrderBy(x => x.OrderID).ToList();
            }
            else
            {
                orders = db.Orders.OrderByDescending(x => x.OrderID).ToList();
            }
            foreach (Order order in db.Orders)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = order.OrderID.ToString();
                lvi.SubItems.Add(order.OrderDate.ToString());
                listView1.Items.Add(lvi);
            }
        }

        
        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            GetOrders(true);
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            GetOrders(false);
        }
    }
}
