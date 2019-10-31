using System;
using System.Windows.Forms;
using ProjectOwn.BLL;

namespace ProjectOwn
{
    public partial class PodcastForm : Form
    {
        public string CategoryToChange;

        public PodcastForm()
        {
            InitializeComponent();

            onLoadFillCategoryList();


        }

        private void btnAddPodcast_Click(object sender, EventArgs e)
        {
            if (Validation.URLInputValidation(tbURLInput.Text))
            {
                //  Code for adding podcast
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
                if (!Validation.CategoryExistValidation(tbCategoryInput.Text))
                {
                    //MessageBox.Show("Category successfully added!", "Success", MessageBoxButtons.OK);
                    string category = tbCategoryInput.Text;
                    XML_FileAccess.AddToCategoryXMLFile(category);
                    onLoadFillCategoryList();
                    tbCategoryInput.Clear();
                }
                else
                {
                    MessageBox.Show("Category already exists.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Input. \nHas to be between 3-30 characters long \nand cannot contain any numbers and cannot \n start with a white space.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            if (tbCategoryInput.Text.Length == 0 || Validation.CategoryExistValidation(tbCategoryInput.Text))
            {
                // MessageBox.Show("Category successfully removed.", "Success", MessageBoxButtons.OK);
                string category = tbCategoryInput.Text;
                XML_FileAccess.RemoveFromCategoryXMLFile(category);
                onLoadFillCategoryList();
                tbCategoryInput.Clear();
            }
            else
            {
                MessageBox.Show("The input does not correnspomd with an existing category.", "Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnChangeCategory_Click(object sender, EventArgs e)
        {
            //  Choose a category from the list
            //  Save choice (in global field?)
            //  Save new input
            //  Replace old string with new string (method in XML_FileAccess)

            string newCategory = tbCategoryInput.Text;
            XML_FileAccess.ChangeCategoriItem(CategoryToChange, newCategory);

            onLoadFillCategoryList();
            tbCategoryInput.Clear();
        }

        private void onLoadFillCategoryList()
        {
            listViewCategories.Clear();
            foreach (string title in XML_FileAccess.LoadCategoryXMLFile())
                listViewCategories.Items.Add(title);
        }

        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCategories.SelectedItems.Count > 0)
            {
                tbCategoryInput.Clear();
                ListViewItem listViewItem = listViewCategories.SelectedItems[0];
                tbCategoryInput.Text = listViewItem.Text;
                CategoryToChange = listViewItem.Text;
            }
        }

        
    }
}
