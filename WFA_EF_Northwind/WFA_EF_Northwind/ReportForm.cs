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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void ReportForm_Load(object sender, EventArgs e)
        {
            //Kategoriye gore urun sayilari listboxta listelenecek

            //T-SQL Sorgusu: select CategoryName,count(ProductID) as 'Urun Adedi' from Categories c join Products p on p.CategoryID=c.CategoryID group by c.CategoryName


            foreach (Category category in db.Categories)
            {
                lstKategori.Items.Add(category.CategoryName + " " + category.Products.Count());
            }

            //Calisanlarin almis oldugu siparis sayilari 

            // T-SQL Sorgusu: select e.FirstName,count(OrderID) from Orders o join Employees e on e.EmployeeID=o.EmployeeID group by e.FirstName

            foreach (Employee employee in db.Employees)
            {
                    lstSiparisler.Items.Add(employee.FirstName + " " + employee.LastName + " " + employee.Orders.Count());            
            }
            //Ulkelere gore calisan sayisi
            foreach (Employee employee in db.Employees)
            {
                if (employee.Employees1.Count() > 0)
                {
                    lstCalisanlar.Items.Add(employee.Country + " " + employee.Employees1.Count());
                }
                
            }
            
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            lstTariheGore.Items.Clear();
            //Secili tarih araligina gore siparis ID'leri
            List<Order> orders = db.Orders.Where(x => x.OrderDate > dateMin.Value && x.OrderDate < dateMax.Value).ToList();

            foreach (Order order in orders)
            {
                lstTariheGore.Items.Add(order.OrderDate+ " "+order.OrderID);
            }
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            lstPersoneleGore.Items.Clear();
            //Personel adina gore siparisler
            //T-SQL Sorgusu: select * from orders o join Employees e on e.EmployeeID=o.EmployeeID where e.FirstName='Nancy'
            List<Order> orders = db.Orders.Where(x=>x.Employee.FirstName==txtCalisanAdi.Text).ToList();
            foreach (Order order in orders)
            {
                lstPersoneleGore.Items.Add(order.OrderID);
            }
        }

        private void btnFiyat_Click(object sender, EventArgs e)
        {
            //Secili fiyat araligina gore siparisler

            lstFiyataGore.Items.Clear();

            List<Order_Detail> orderDetails = db.Order_Details.Where(x => x.UnitPrice >= nudMinFiyat.Value && x.UnitPrice <= nudMaxFiyat.Value).ToList();
            foreach (Order_Detail od in orderDetails)
            {
                lstFiyataGore.Items.Add(" Sip No: "+od.OrderID+ " Price: "+ od.UnitPrice);
            }

        }
    }
}
