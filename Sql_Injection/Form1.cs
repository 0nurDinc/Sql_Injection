using Sql_Injection.Model;
using System.Drawing.Printing;

namespace Sql_Injection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string _connectionString = "Server=.;Database=Sql_Injection;Trusted_Connection=True;";
        public CategoryRepo categoryRepo = new CategoryRepo(_connectionString);
        public HackRepo hackRepo = new HackRepo(_connectionString);

        public Category selectedCategory = null;

        private void LoadListView()
        {
            listViewCategory.Items.Clear();

            foreach (Category category in categoryRepo.GetCategoryList())
            {
                ListViewItem item = new ListViewItem();
                item.Text = category.CategoryID.ToString();
                item.SubItems.Add(category.CategoryName);
                item.SubItems.Add(category.CategoryDescription);
                item.Tag = category;
                listViewCategory.Items.Add(item);
            }
        }

        private void LoadFilterList(string filter)
        {
            listViewCategory.Items.Clear();


            foreach (Category category in hackRepo.FilterProducts(filter))
            {
                ListViewItem item = new ListViewItem();
                item.Text = category.CategoryID.ToString();
                item.SubItems.Add(category.CategoryName);
                item.SubItems.Add(category.CategoryDescription);
                item.Tag = category;
                listViewCategory.Items.Add(item);
            }
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryID = Guid.NewGuid(),
                CategoryName = txtCategoryName.Text,
                CategoryDescription = txtCategoryDescription.Text
            };

            categoryRepo.AddCategory(category);
            LoadListView();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (selectedCategory is null)
            {
                MessageBox.Show("No record has been selected to update.");
                return;
            }

            Category updateCategory = selectedCategory;
            updateCategory.CategoryName = txtCategoryName.Text;
            updateCategory.CategoryDescription = txtCategoryDescription.Text;


            categoryRepo.UpdateCategory(updateCategory);
            LoadListView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedCategory is null)
            {
                MessageBox.Show("No record has been selected to update.");
                return;
            }

            Category deleteCategory = selectedCategory;
            categoryRepo.Delete(deleteCategory.CategoryID);
            LoadListView();
        }

        private void listViewCategory_Click(object sender, EventArgs e)
        {
            if (listViewCategory.SelectedItems[0] is null)
                return;

            selectedCategory = listViewCategory.SelectedItems[0].Tag as Category;
            txtCategoryName.Text = selectedCategory.CategoryName;
            txtCategoryDescription.Text = selectedCategory.CategoryDescription;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchCategoryName.Text;
            LoadFilterList(searchText);
        }
    }
}