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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void CategoryForm_Load(object sender, EventArgs e)
        {

            foreach (Category category in db.Categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.CategoryID.ToString();
                lvi.SubItems.Add(category.CategoryName);
                lvi.SubItems.Add(category.Description);
                //lvi.Tag = category;
                listView1.Items.Add(lvi);
            }
        }
        private void AddCategory()
        {
            try
            {
                Category category = new Category();
                category.CategoryName = txtCategoyName.Text;
                category.Description = txtDescription.Text;
                db.Categories.Add(category);
                db.SaveChanges();

                MessageBox.Show(category.CategoryName + " kategorisi kaydedildi");
                GetCategories();
                txtCategoyName.Text = "";
                txtDescription.Text = "";
                txtCategoyName.Focus(); //islem bittikten sonra imlec kategori textbox'inda yanip sonsun.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GetCategories()
        {
            listView1.Items.Clear();
            foreach (Category category in db.Categories)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = category.CategoryID.ToString();
                lvi.SubItems.Add(category.CategoryName);
                lvi.SubItems.Add(category.Description);
                listView1.Items.Add(lvi);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            AddCategory();
        }
    }
}
