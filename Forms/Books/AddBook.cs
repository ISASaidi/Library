﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Library
{
    public partial class AddBook : Form
    {

        BookRepository repository = new BookRepository();

        public AddBook()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;

            try
            {
                Book bk = new Book(txtTitle.Text, txtEdition.Text, txtAuthor.Text, txtGenre.Text);
                
                repository.AddBook(bk);
            }

            finally
            {
                btnAdd.Enabled = true;
            }

        }
    }
}

