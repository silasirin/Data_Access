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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetProducts();
            FillCategories();
            cmbCategory.SelectedIndex = -1;
            cmbCategorySelect.SelectedIndex = -1;

            //Total categories and total products goruntuleme:
            lblTotalCategories.Text =db.Categories.Count().ToString();
            lblTotalProducts.Text =db.Products.Count().ToString();

        }

        NorthwindEntities db = new NorthwindEntities();

        //Kategorileri combobox'lara eklemek icin olusturulan method:
        private void FillCategories()
        {
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId"; //combobox'tan category secilirken arkaplanda tutulacak olan value'su.
            cmbCategory.DataSource = db.Categories.ToList();

            cmbCategorySelect.DisplayMember = "CategoryName";
            cmbCategorySelect.ValueMember = "CategoryId";
            cmbCategorySelect.DataSource = db.Categories.ToList();
            //Value member sonradan dolduruluyor ve olusturulan methodla cakisiyor. Bu hatanin olusmamasi icin datasource kismi her zaman en sonda yazilmali.
        }
        private void FillCategories(int Id)
        {
            listView1.Items.Clear();

            List<Product> products = db.Products.Where(x => x.CategoryID==Id).ToList();

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                string categoryName = product.CategoryID == null ? "Tanimsiz" : product.Category.CategoryName;
                lvi.SubItems.Add(cmbCategorySelect.Text);
                listView1.Items.Add(lvi);
            }
        }

        //Urunleri listview'a eklemek icin kullanilan method:
        private void GetProducts()
        {
            listView1.Items.Clear();

            foreach (Product product in db.Products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString(); ;
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());

                string categoryName = product.CategoryID == null ? "Tanimsiz":product.Category.CategoryName; //ternary if (tek satirda if yapisidir.
                //? -> if
                //: -> else
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
        //order by islemi icin tanimlanan method:
        private void GetProducts(bool val)
        {
            List<Product> products;
            listView1.Items.Clear();
            if (val)
            {
                products = db.Products.OrderBy(x => x.UnitPrice).ToList();
            }
            else
            {
                products = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
            }
            

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString(); ;
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());

                string categoryName = product.CategoryID == null ? "Tanimsiz" : product.Category.CategoryName; 
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }

        private void GetProducts(string param)
        {
            listView1.Items.Clear();

            List<Product> products = db.Products.Where(x => x.ProductName.Contains(param)).ToList();

            foreach (Product product in products)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = product.ProductID.ToString();
                lvi.SubItems.Add(product.ProductName);
                lvi.SubItems.Add(product.UnitPrice.ToString());
                lvi.SubItems.Add(product.UnitsInStock.ToString());
                string categoryName = product.CategoryID == null ? "Tanimsiz" : product.Category.CategoryName;
                lvi.SubItems.Add(categoryName);
                listView1.Items.Add(lvi);
            }
        }
            //Database'e urun ekleme methodu:
            private void AddProducts(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
                GetProducts();
                
                MessageBox.Show(product.ProductName + " adli urun kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);;
            }
        }
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtProductName.Text;
            p.UnitPrice = nudPrice.Value;
            p.UnitsInStock = Convert.ToInt16(nudStock.Value);
            p.CategoryID = (int)cmbCategory.SelectedValue;

            txtProductName.Text = "";
            nudPrice.Value = 0;
            nudStock.Value = 0;
            cmbCategory.SelectedIndex = -1;
            txtProductName.Focus();

            AddProducts(p);
        }
        
        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            GetProducts(true);
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            GetProducts(false);
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Search'e veri girisi oldugunda veri dizilimi ona gore sekillenecek
            GetProducts(txtSearch.Text);
        }

        private void cmbCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listview'da, secilen categoryName'e ait urunler siralanacak.
            int categoryId = Convert.ToInt32(cmbCategorySelect.SelectedValue);
            FillCategories(categoryId);
        }
    }
}
