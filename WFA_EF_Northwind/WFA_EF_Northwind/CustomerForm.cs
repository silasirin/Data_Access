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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        
        private void GetCustomers()
        {
            listView1.Items.Clear();

            foreach (Customer customer in db.Customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerID;
                lvi.SubItems.Add(customer.CompanyName);
                string companyName = customer.CustomerID == null ? "Tanimsiz" : customer.CustomerID;
                listView1.Items.Add(lvi);
            }
        }
            
        private void AddCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                MessageBox.Show(customer.CompanyName + " adli musteri kaydedildi");
                GetCustomers();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = txtCustomerId.Text;
            customer.CompanyName = txtCompanyName.Text;
            AddCustomer(customer);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            GetCustomers();
        }
        private void GetCustomers(bool val)
        {
            List<Customer> customers;
            listView1.Items.Clear();
            if (val)
            {
                customers = db.Customers.OrderBy(x => x.CustomerID).ToList();
            }
            else
            {
                customers = db.Customers.OrderByDescending(x => x.CustomerID).ToList();
            }

            foreach (Customer customer in customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerID;
                lvi.SubItems.Add(customer.CompanyName);
                listView1.Items.Add(lvi);
            }
        }
        private void GetCustomers(string param)
        {
            listView1.Items.Clear();

            List<Customer> customers = db.Customers.Where(x => x.CustomerID.Contains(param)).ToList();

            foreach (Customer customer in customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerID;
                lvi.SubItems.Add(customer.CompanyName);
                listView1.Items.Add(lvi);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetCustomers(txtSearch.Text);
        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            GetCustomers(true);
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            GetCustomers(false);
        }
    }
}
