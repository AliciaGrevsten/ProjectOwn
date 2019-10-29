using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                onLoadFillCategoryList();
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
                XML_FileAccess.ChangeCategoryXMLFile(category);
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
    }
}
