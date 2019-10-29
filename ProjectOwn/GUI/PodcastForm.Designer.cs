namespace ProjectOwn
{
    partial class PodcastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewPodcasts = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemovePodcast = new System.Windows.Forms.Button();
            this.btnChangePodcast = new System.Windows.Forms.Button();
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbURLInput = new System.Windows.Forms.TextBox();
            this.cbCategoryAdd = new System.Windows.Forms.ComboBox();
            this.cbUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorySort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listViewCategories = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCategoryInput = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewPodcasts
            // 
            this.listViewPodcasts.HideSelection = false;
            this.listViewPodcasts.Location = new System.Drawing.Point(18, 60);
            this.listViewPodcasts.Name = "listViewPodcasts";
            this.listViewPodcasts.Size = new System.Drawing.Size(459, 450);
            this.listViewPodcasts.TabIndex = 0;
            this.listViewPodcasts.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemovePodcast);
            this.panel1.Controls.Add(this.btnChangePodcast);
            this.panel1.Controls.Add(this.btnAddPodcast);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbURLInput);
            this.panel1.Controls.Add(this.cbCategoryAdd);
            this.panel1.Controls.Add(this.cbUpdateFrequency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCategorySort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listViewPodcasts);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 630);
            this.panel1.TabIndex = 1;
            // 
            // btnRemovePodcast
            // 
            this.btnRemovePodcast.Location = new System.Drawing.Point(349, 576);
            this.btnRemovePodcast.Name = "btnRemovePodcast";
            this.btnRemovePodcast.Size = new System.Drawing.Size(128, 31);
            this.btnRemovePodcast.TabIndex = 13;
            this.btnRemovePodcast.Text = "Remove Podcast";
            this.btnRemovePodcast.UseVisualStyleBackColor = true;
            // 
            // btnChangePodcast
            // 
            this.btnChangePodcast.Location = new System.Drawing.Point(218, 576);
            this.btnChangePodcast.Name = "btnChangePodcast";
            this.btnChangePodcast.Size = new System.Drawing.Size(127, 31);
            this.btnChangePodcast.TabIndex = 12;
            this.btnChangePodcast.Text = "Change Pocast";
            this.btnChangePodcast.UseVisualStyleBackColor = true;
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(77, 576);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(135, 31);
            this.btnAddPodcast.TabIndex = 11;
            this.btnAddPodcast.Text = "Add Podcast";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Update Frequency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "URL:";
            // 
            // tbURLInput
            // 
            this.tbURLInput.Location = new System.Drawing.Point(18, 539);
            this.tbURLInput.Name = "tbURLInput";
            this.tbURLInput.Size = new System.Drawing.Size(188, 20);
            this.tbURLInput.TabIndex = 7;
            // 
            // cbCategoryAdd
            // 
            this.cbCategoryAdd.FormattingEnabled = true;
            this.cbCategoryAdd.Location = new System.Drawing.Point(339, 538);
            this.cbCategoryAdd.Name = "cbCategoryAdd";
            this.cbCategoryAdd.Size = new System.Drawing.Size(138, 21);
            this.cbCategoryAdd.TabIndex = 6;
            // 
            // cbUpdateFrequency
            // 
            this.cbUpdateFrequency.FormattingEnabled = true;
            this.cbUpdateFrequency.Location = new System.Drawing.Point(212, 539);
            this.cbUpdateFrequency.Name = "cbUpdateFrequency";
            this.cbUpdateFrequency.Size = new System.Drawing.Size(121, 21);
            this.cbUpdateFrequency.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter By Category:";
            // 
            // cbCategorySort
            // 
            this.cbCategorySort.FormattingEnabled = true;
            this.cbCategorySort.Location = new System.Drawing.Point(314, 24);
            this.cbCategorySort.Name = "cbCategorySort";
            this.cbCategorySort.Size = new System.Drawing.Size(163, 21);
            this.cbCategorySort.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Podcast";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.listView2);
            this.panel3.Location = new System.Drawing.Point(513, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(398, 630);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podcast Episodes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(16, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 203);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Episode Information";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(20, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(330, 13);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Title";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(20, 71);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(330, 122);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Description";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(16, 60);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(367, 348);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listViewCategories
            // 
            this.listViewCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title});
            this.listViewCategories.FullRowSelect = true;
            this.listViewCategories.GridLines = true;
            this.listViewCategories.HideSelection = false;
            this.listViewCategories.Location = new System.Drawing.Point(15, 60);
            this.listViewCategories.Name = "listViewCategories";
            this.listViewCategories.Size = new System.Drawing.Size(202, 346);
            this.listViewCategories.TabIndex = 4;
            this.listViewCategories.UseCompatibleStateImageBehavior = false;
            this.listViewCategories.View = System.Windows.Forms.View.List;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbCategoryInput);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.btnAddCategory);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.listViewCategories);
            this.panel4.Location = new System.Drawing.Point(917, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 630);
            this.panel4.TabIndex = 4;
            // 
            // tbCategoryInput
            // 
            this.tbCategoryInput.Location = new System.Drawing.Point(15, 432);
            this.tbCategoryInput.Name = "tbCategoryInput";
            this.tbCategoryInput.Size = new System.Drawing.Size(203, 20);
            this.tbCategoryInput.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 495);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 25);
            this.button6.TabIndex = 8;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "Change";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(15, 464);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(100, 25);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Categories";
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 654);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PodcastForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPodcasts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemovePodcast;
        private System.Windows.Forms.Button btnChangePodcast;
        private System.Windows.Forms.Button btnAddPodcast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbURLInput;
        private System.Windows.Forms.ComboBox cbCategoryAdd;
        private System.Windows.Forms.ComboBox cbUpdateFrequency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategorySort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listViewCategories;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbCategoryInput;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader Title;
    }
}

