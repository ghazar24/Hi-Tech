using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagment_InventoryManagment_Entity.Models;

namespace OrderManagment.GUI
{
    public partial class Inventory_Conroller : Form
    {
        Hi_TechDBEntities1 dBEntities = new Hi_TechDBEntities1();
        public Inventory_Conroller()
        {
            InitializeComponent();
        }

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxBookCategoryName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category", "Error");
                return;

            }
            else if (comboBoxBookPublisherID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a publisher", "Error");
                return;
            }
            int publisherid = Convert.ToInt32(comboBoxBookPublisherID.SelectedValue);
            int categoryid = Convert.ToInt32(comboBoxBookCategoryName.SelectedValue);
            Book book = new Book();
            book.ISBN = textBoxBookISBN.Text.Trim();
            book.Title = textBoxBookTitle.Text.Trim();
            book.UnitPrice = Convert.ToInt32(textBoxBookUnitPrice.Text.Trim());
            book.YearPublished = Convert.ToDateTime(maskedTextBoxYearPublished.Text.Trim());
            book.CategoryID = categoryid;
            book.PublisherID = publisherid;
            dBEntities.Books.Add(book);

            dBEntities.SaveChanges();
            MessageBox.Show("Book Added successfully.", "Confirmation");

        }








        private void buttonBookUpdate_Click(object sender, EventArgs e)
        {

            if (comboBoxBookCategoryName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category", "Error");
                return;

            }
            else if (comboBoxBookPublisherID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a publisher", "Error");
                return;
            }

            int publisherid = Convert.ToInt32(comboBoxBookPublisherID.SelectedValue);
            int categoryid = Convert.ToInt32(comboBoxBookCategoryName.SelectedValue);
            var update = (from b in dBEntities.Books
                          where b.ISBN == textBoxBookISBN.Text.Trim()
                          select b).FirstOrDefault();
            if (update != null)
            {

                update.ISBN = textBoxBookISBN.Text.Trim();
                update.Title = textBoxBookTitle.Text.Trim();
                update.UnitPrice = Convert.ToInt32(textBoxBookUnitPrice.Text.Trim());
                update.YearPublished = Convert.ToDateTime(maskedTextBoxYearPublished.Text.Trim());
                update.CategoryID = categoryid;
                update.PublisherID = publisherid;
                dBEntities.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Wrong ISBN Number!", "Error");
            }



        }

        private void buttonBookSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxBookSearch.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    var searchbookid = (from b in dBEntities.Books
                                        where b.ISBN == textBoxBookSearch.Text.Trim()
                                        select b).FirstOrDefault();
                    if (searchbookid != null)
                    {
                        listViewBooks.Items.Clear();
                        ListViewItem item = new ListViewItem(searchbookid.ISBN);

                        item.SubItems.Add(searchbookid.Title);
                        item.SubItems.Add(searchbookid.UnitPrice.ToString());
                        item.SubItems.Add(searchbookid.YearPublished.ToString());
                        item.SubItems.Add(searchbookid.CategoryID.ToString());
                        item.SubItems.Add(searchbookid.PublisherID.ToString());

                        listViewBooks.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("No book with that ISBN!", "Error");
                    }
                    break;
                case 1:
                    var listname = (from b in dBEntities.Books
                                    where b.Title == textBoxBookSearch.Text.Trim()
                                    select b).ToList();
                    if (listname.Count > 0)
                    {
                        listViewBooks.Items.Clear();
                        foreach (var book in listname)
                        {
                            ListViewItem item = new ListViewItem(book.ISBN);

                            item.SubItems.Add(book.Title);
                            item.SubItems.Add(book.UnitPrice.ToString());
                            item.SubItems.Add(book.YearPublished.ToString());
                            item.SubItems.Add(book.CategoryID.ToString());
                            item.SubItems.Add(book.PublisherID.ToString());

                            listViewBooks.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No book with that title!", "Error");
                    }

                    break;
                case 2:
                    int pid = Convert.ToInt32(textBoxBookSearch.Text.Trim());
                    var searchPubid = (from b in dBEntities.Books
                                       where b.PublisherID == pid
                                       select b).FirstOrDefault();
                    if (searchPubid != null)
                    {
                        listViewBooks.Items.Clear();
                        ListViewItem item = new ListViewItem(searchPubid.ISBN);

                        item.SubItems.Add(searchPubid.Title);
                        item.SubItems.Add(searchPubid.UnitPrice.ToString());
                        item.SubItems.Add(searchPubid.YearPublished.ToString());
                        item.SubItems.Add(searchPubid.CategoryID.ToString());
                        item.SubItems.Add(searchPubid.PublisherID.ToString());

                        listViewBooks.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("No book assigned to that publisher ID!", "Error");
                    }
                    break;
            }
        }

        private void buttonBookListAll_Click(object sender, EventArgs e)
        {
            var listbooks = dBEntities.Books.ToList();
            listViewBooks.Items.Clear();
            if (listbooks.Count != 0)
            {
                foreach (var book in listbooks)
                {
                    ListViewItem item = new ListViewItem(book.ISBN);

                    item.SubItems.Add(book.Title);
                    item.SubItems.Add(book.UnitPrice.ToString());
                    item.SubItems.Add(book.YearPublished.ToString());
                    item.SubItems.Add(book.CategoryID.ToString());
                    item.SubItems.Add(book.PublisherID.ToString());

                    listViewBooks.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("books List!", "No book");
            }
        }

        private void buttonBookDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do really want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                var delete = (from b in dBEntities.Books
                              where b.ISBN == textBoxBookISBN.Text.Trim()
                              select b).FirstOrDefault();
                if (delete != null)
                {
                    dBEntities.Books.Remove(delete);
                    dBEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wrong ISBN Number! or Book already Deleted", "No book");
                }
            }
            else
            {
                textBoxBookISBN.Text = string.Empty;
                return;
            }
        }

        private void buttonPublisherAdd_Click(object sender, EventArgs e)
        {


            Publisher pub = new Publisher();
            pub.PublisherID = Convert.ToInt32(textBoxPublisherID.Text.Trim());
            pub.Name = textBoxPublisherName.Text.Trim();
            pub.Phone_Number = textBoxPublisherPhoneNumber.Text.Trim();

            dBEntities.Publishers.Add(pub);

            dBEntities.SaveChanges();
            MessageBox.Show("Publisher Added successfully.", "Confirmation");
        }

        private void buttonPublisherUpdate_Click(object sender, EventArgs e)
        {
            int pubid = Convert.ToInt32(textBoxPublisherID.Text.Trim());
            var update = (from p in dBEntities.Publishers
                          where p.PublisherID == pubid
                          select p).FirstOrDefault();
            if (update != null)
            {

                update.PublisherID = Convert.ToInt32(textBoxPublisherID.Text.Trim());
                update.Name = textBoxPublisherName.Text.Trim();
                update.Phone_Number = textBoxPublisherPhoneNumber.Text.Trim();

                dBEntities.SaveChangesAsync();
                MessageBox.Show("Sussecfully Updated!", "Confirm");
            }
            else
            {
                MessageBox.Show("Wrong PublisherID Number!", "Error");
            }
        }

        private void buttonPublisherDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do really want to delete this Publisher?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                int pubid = Convert.ToInt32(textBoxPublisherID.Text.Trim());
                var delete = (from p in dBEntities.Publishers
                              where p.PublisherID == pubid
                              select p).FirstOrDefault();
                if (delete != null)
                {
                    dBEntities.Publishers.Remove(delete);
                    dBEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wrong ID Number! or Publisher already Deleted", "No Publisher");
                }
            }
            else
            {
                textBoxPublisherID.Text = string.Empty;
                return;
            }
        }

        private void buttonPublisherListAll_Click(object sender, EventArgs e)
        {
            var listPublishers = dBEntities.Publishers.ToList();
            listViewPublishers.Items.Clear();
            if (listPublishers.Count != 0)
            {
                foreach (var pub in listPublishers)
                {
                    ListViewItem item = new ListViewItem(pub.PublisherID.ToString());

                    item.SubItems.Add(pub.Name);
                    item.SubItems.Add(pub.Phone_Number);


                    listViewPublishers.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Publishers List!", "No Publishers");
            }
        }
        private void buttonPublisherSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxPublisherSearch.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    int pubid = Convert.ToInt32(textBoxPublisherSearch.Text);
                    var searchpubid = (from p in dBEntities.Publishers
                                       where p.PublisherID == pubid
                                       select p).FirstOrDefault();
                    if (searchpubid != null)
                    {
                        listViewPublishers.Items.Clear();

                        ListViewItem item = new ListViewItem(searchpubid.PublisherID.ToString());

                        item.SubItems.Add(searchpubid.Name);
                        item.SubItems.Add(searchpubid.Phone_Number);


                        listViewPublishers.Items.Add(item);
                    }

                    else
                    {
                        MessageBox.Show("No Publisher with that ID!", "Error");
                    }
                    break;
                case 1:
                    var listname = (from p in dBEntities.Publishers
                                    where p.Name == textBoxPublisherSearch.Text.Trim()
                                    select p).ToList();
                    if (listname.Count > 0)
                    {
                        foreach (var pub in listname)
                        {
                            listViewPublishers.Items.Clear();

                            ListViewItem item = new ListViewItem(pub.PublisherID.ToString());

                            item.SubItems.Add(pub.Name);
                            item.SubItems.Add(pub.Phone_Number);


                            listViewPublishers.Items.Add(item);
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Publisher with that name!", "Error");
                    }
                    break;
            }
        }

        private void Inventory_Conroller_Load(object sender, EventArgs e)
        {
            var listCtg = (from ctg in dBEntities.Categories
                           select ctg).ToList<Category>();
            foreach (Category ctg in listCtg)
            {
                comboBoxBookCategoryName.DisplayMember = "Title";
                comboBoxBookCategoryName.ValueMember = "CategoryID";
                comboBoxBookCategoryName.DataSource = listCtg;
            }
            var listPblsh = (from pub in dBEntities.Publishers
                             select pub).ToList<Publisher>();
            foreach (Publisher pub in listPblsh)
            {
                comboBoxBookPublisherID.DisplayMember = "Name";
                comboBoxBookPublisherID.ValueMember = "PublisherID";
                comboBoxBookPublisherID.DataSource = listPblsh;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listCtg = (from ctg in dBEntities.Categories
                           select ctg).ToList<Category>();
            foreach (Category ctg in listCtg)
            {
                comboBoxBookCategoryName.DisplayMember = "Title";
                comboBoxBookCategoryName.ValueMember = "CategoryID";
                comboBoxBookCategoryName.DataSource = listCtg;
            }
            var listPblsh = (from pub in dBEntities.Publishers
                             select pub).ToList<Publisher>();
            foreach (Publisher pub in listPblsh)
            {
                comboBoxBookPublisherID.DisplayMember = "Name";
                comboBoxBookPublisherID.ValueMember = "PublisherID";
                comboBoxBookPublisherID.DataSource = listPblsh;
            }
        }

        private void buttonAuthorAdd_Click(object sender, EventArgs e)
        {
            Author auth = new Author();
            auth.AuthorID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
            auth.First_Name = textBoxAuthorFirstName.Text.Trim();
            auth.Last_Name = textBoxAuthorLastName.Text.Trim();
            auth.Email = textBoxAuthorEmail.Text.Trim();

            dBEntities.Authors.Add(auth);

            dBEntities.SaveChanges();
            MessageBox.Show("Author Added successfully.", "Confirmation");
        }

        private void buttonAuthorUpdate_Click(object sender, EventArgs e)
        {
            int authid = Convert.ToInt32(textBoxAuthorID.Text.Trim());
            var update = (from a in dBEntities.Authors
                          where a.AuthorID == authid
                          select a).FirstOrDefault();
            if (update != null)
            {

                update.AuthorID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
                update.First_Name = textBoxAuthorFirstName.Text.Trim();
                update.Last_Name = textBoxAuthorLastName.Text.Trim();
                update.Email = textBoxAuthorEmail.Text.Trim();
                dBEntities.SaveChangesAsync();
            }
            else
            {
                MessageBox.Show("Wrong Author ID Number!", "Error");
            }
        }

        private void buttonAuthorDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do really want to delete this Author?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                int authrid = Convert.ToInt32(textBoxAuthorID.Text.Trim());
                var delete = (from a in dBEntities.Authors
                              where a.AuthorID == authrid
                              select a).FirstOrDefault();
                if (delete != null)
                {

                    dBEntities.Authors.Remove(delete);
                    dBEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wrong Author ID or Author already Deleted", "No Author");
                }
            }
            else
            {
                textBoxAuthorID.Text = string.Empty;
                return;
            }
        }

        private void buttonAuthorListAll_Click(object sender, EventArgs e)
        {
            listViewAuthors.Items.Clear();
            var listauthors = dBEntities.Authors.ToList();
            
            if (listauthors.Count != 0)
            {
                foreach (var auth in listauthors)
                {
                    ListViewItem item = new ListViewItem(auth.AuthorID.ToString());

                    item.SubItems.Add(auth.First_Name);
                    item.SubItems.Add(auth.Last_Name);
                    item.SubItems.Add(auth.Email);

                    listViewAuthors.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Authors List!", "No Author");
            }
        }


        private void buttonAuthorSearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxAuthorSearch.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    int authid = Convert.ToInt32(textBoxAuthorSearch.Text.Trim());
                    var searchAuthid = (from a in dBEntities.Authors
                                        where a.AuthorID == authid
                                        select a).FirstOrDefault();
                    if (searchAuthid != null)
                    {
                        listViewAuthors.Items.Clear();
                        ListViewItem item = new ListViewItem(searchAuthid.AuthorID.ToString());

                        item.SubItems.Add(searchAuthid.First_Name);
                        item.SubItems.Add(searchAuthid.Last_Name);
                        item.SubItems.Add(searchAuthid.Email);

                        listViewAuthors.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Author ID Not Found!", "Error");
                    }
                    break;
                case 1:
                    var listname = (from a in dBEntities.Authors
                                    where a.First_Name == textBoxAuthorSearch.Text.Trim()
                                    select a).ToList();
                    if (listname.Count != 0)
                    {
                        listViewAuthors.Items.Clear();
                        foreach (var auth in listname)
                        {
                            ListViewItem item = new ListViewItem(auth.AuthorID.ToString());

                            item.SubItems.Add(auth.First_Name);
                            item.SubItems.Add(auth.Last_Name);
                            item.SubItems.Add(auth.Email);

                            listViewAuthors.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Author Name Not Found!", "Error");
                    }
                    break;
            }
        }

        private void buttonCategoryAdd_Click(object sender, EventArgs e)
        {
            Category cat = new Category();

            cat.CategoryID = Convert.ToInt32(textBoxCategoryID.Text.Trim());
            cat.Title = textBoxCategoryTitle.Text.Trim();
            dBEntities.Categories.Add(cat);
            dBEntities.SaveChanges();
            MessageBox.Show("Successfuly Added", "Confirm");
        }

        private void buttonCategoryUpdate_Click(object sender, EventArgs e)
        {
            int catid = Convert.ToInt32(textBoxCategoryID.Text.Trim());
            var searchCatid = (from c in dBEntities.Categories
                               where c.CategoryID == catid
                               select c).FirstOrDefault();
            if (searchCatid != null)
            {
                searchCatid.CategoryID = Convert.ToInt32(textBoxCategoryID.Text.Trim());
                searchCatid.Title = textBoxCategoryTitle.Text.Trim();
                dBEntities.SaveChanges();
                MessageBox.Show("Successfuly updated", "Confirm");
            }
            else
            {
                MessageBox.Show("Wrong Category ID", "No Category");
            }
        }

        private void buttonCategoryDelete_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do really want to delete this Category?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (answer == DialogResult.Yes)
            {
                int catid = Convert.ToInt32(textBoxCategoryID.Text.Trim());
                var delete = (from c in dBEntities.Categories
                              where c.CategoryID == catid
                              select c).FirstOrDefault();
                if (delete != null)
                {

                    dBEntities.Categories.Remove(delete);
                    dBEntities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Wrong Category ID or Category already Deleted", "No Category");
                }
            }
            else
            {
                textBoxCategoryID.Text = string.Empty;
                return;
            }
        }

        private void buttonCategoryListAll_Click(object sender, EventArgs e)
        {

            listViewCategories.Items.Clear();
            var listcat = dBEntities.Categories.ToList();
            
            if (listcat.Count != 0)
            {
                foreach (var cat in listcat)
                {
                    ListViewItem item = new ListViewItem(cat.CategoryID.ToString());

                    item.SubItems.Add(cat.Title);


                    listViewCategories.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("Category List!", "No Category");
            }
        }

        private void buttonCategorySearch_Click(object sender, EventArgs e)
        {
            int indexSelected = comboBoxCategorySearch.SelectedIndex;

            switch (indexSelected)
            {
                case 0:
                    int catid = Convert.ToInt32(textBoxCategorySearch.Text.Trim());
                    var searchCatid = (from c in dBEntities.Categories
                                       where c.CategoryID == catid
                                       select c).FirstOrDefault();
                    if (searchCatid != null)
                    {
                        listViewCategories.Items.Clear();
                        ListViewItem item = new ListViewItem(searchCatid.CategoryID.ToString());

                        item.SubItems.Add(searchCatid.Title);


                        listViewCategories.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("Category ID Not Found!", "Error");
                    }
                    break;
                case 1:
                    var listname = (from a in dBEntities.Categories
                                    where a.Title == textBoxCategorySearch.Text.Trim()
                                    select a).FirstOrDefault();
                    if (listname != null)
                    {
                        listViewCategories.Items.Clear();

                        ListViewItem item = new ListViewItem(listname.CategoryID.ToString());

                        item.SubItems.Add(listname.Title);


                        listViewCategories.Items.Add(item);

                    }
                    else
                    {
                        MessageBox.Show("Category Name Not Found!", "Error");
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Do you really want to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}