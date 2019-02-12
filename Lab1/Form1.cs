﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void AddTitle_Click(object sender, EventArgs e)
        {
            string SelectedItem = (string)comboBox1.SelectedItem;
            int Quantity = Int32.Parse(QuantityText.Text);
            Double TotalCost = Quantity * Convert.ToDouble(PriceText.Text);
            // Populate the rows.
            string[] row = new string[] { SelectedItem, "$" + PriceText.Text, Quantity.ToString(), "$" + TotalCost.ToString() };

            dataGridView1.Rows.Add(row);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedItem = (string)comboBox1.SelectedItem;
            string Book1Name = "The Kite Runner";
            decimal Book1Price = 14.40m;
            string Book1ISBN = "9781594631931";
            string Book1Author = "Khaled Hosseini";

            string Book2Name = "Charlie and the Chocolate Factory";
            decimal Book2Price = 7.20m;
            string Book2ISBN = "9780142410318";
            string Book2Author = "Roald Dahl";

            string Book3Name = "Twilight";
            decimal Book3Price = 14.44m;
            string Book3ISBN = "9780316015844";
            string Book3Author = "Stephenie Meyer";

            Book Book1 = new Book(Book1Name, Book1Author, Book1ISBN, Book1Price);
            Book Book2 = new Book(Book2Name, Book2Author, Book2ISBN, Book2Price);
            Book Book3 = new Book(Book3Name, Book3Author, Book3ISBN, Book3Price);
            string test = comboBox1.SelectedText;
            string test2 = e.ToString();
            if (SelectedItem == "The Kite Runner")
            {
                AuthorText.Text = Book1.author;
                IsbnText.Text = Book1.ISBN;
                PriceText.Text = Book1.price.ToString();
            }
            else if (SelectedItem == "Charlie and the Chocolate Factory")
            {
                AuthorText.Text = Book2.author;
                IsbnText.Text = Book2.ISBN;
                PriceText.Text = Book2.price.ToString();
            }
            else if (SelectedItem == "Twilight")
            {
                AuthorText.Text = Book2.author;
                IsbnText.Text = Book2.ISBN;
                PriceText.Text = Book2.price.ToString();
            }
            else
            {
                AuthorText.Clear();
                IsbnText.Clear();
                PriceText.Clear();
                TotalText.Text = "Select a Book to purchase!";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuantityText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subtotal_Text_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}