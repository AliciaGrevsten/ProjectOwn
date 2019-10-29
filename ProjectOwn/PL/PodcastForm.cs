using System;
using System.Windows.Forms;
using ProjectOwn.BLL;

namespace ProjectOwn
{
    public partial class PodcastForm : Form
    {
        public PodcastForm()
        {
            InitializeComponent();

            onLoadFillCategoryList();


        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            if (Validation.URLInputValidation(tbURLInput.Text))
            {
                MessageBox.Show("Podcast Added!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Incorrect URL Input", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (Validation.CharacterInputLengthValidation(tbCategoryInput.Text))
            {
                MessageBox.Show("Category Added!", "Success", MessageBoxButtons.OK);
                string category = tbCategoryInput.Text;
                XML_FileAccess.AddToCategoryXMLFile(category);
                onLoadFillCategoryList();
            }
            else
            {
                MessageBox.Show("Incorrect Input. \nHas to be at least 3 characters long \nand cannot contain any numbers", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onLoadFillCategoryList()
        {
            listViewCategories.Clear();
            foreach (string title in XML_FileAccess.LoadCategoryXMLFile())
                listViewCategories.Items.Add(title);
        }


        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            XML_FileAccess.RemoveFromCategoryXMLFile(tbCategoryInput.Text);
            onLoadFillCategoryList();
        }
    }
}
