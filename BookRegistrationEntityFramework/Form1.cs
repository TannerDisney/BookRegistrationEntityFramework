using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRegistrationEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrepopulateForm();
        }
        /// <summary>
        /// Calls the "Populate" methods to populate the form with data.
        /// </summary>
        private void PrepopulateForm()
        {
            PopulateCustomerList();
            PopulateBookList();
        }

        /// <summary>
        /// Populates ComboBoxes with books from the database in alphabetical order.
        /// </summary>
        private void PopulateBookList()
        {
            List<Book> books = BookDb.GetBooks();

            cboBooks.DataSource = books;
            cboBooks.DisplayMember = nameof(Book.Title);
        }

        /// <summary>
        /// Populates ComboBoxes with customers from the database in alphabetical order.
        /// </summary>
        private void PopulateCustomerList()
        {
            List<Customer> customers = CustomerDb.GetCustomers();

            cboCustomers.DataSource = customers;
            cboCustomers.DisplayMember = nameof(Customer.FirstName);
        }
    }
}
