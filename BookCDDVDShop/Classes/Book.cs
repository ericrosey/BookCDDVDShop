using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;

/* Eric Rosenblatt & Max Robins
 * CIS 3309
 * 05/04/2020
 * Project 4 - BookCDDVDShop
 * Book class
 */

namespace BookCDDVDShop.Classes
{
    // Book inherits the data and methods in Product and can be a serialized to a binary file

    [Serializable()]
    class Book : Product
    {
        private int hiddenLeftISBN;
        private int hiddenRightISBN;
        private string hiddenAuthor;
        private int hiddenPages;
        public Book()
        {
            hiddenLeftISBN = 100;
            hiddenRightISBN = 000;
            hiddenAuthor = "";
            hiddenPages = 0;
        }  // end Parameterless Constructor


        // Parameterized constructor
        public Book(int UPC, decimal price, string title, int quantity,  // For Product Constructor
            int leftISBN, int rightISBN, string author, int pages) : base(UPC, price, title, quantity)
        {
            hiddenLeftISBN = leftISBN;
            hiddenRightISBN = rightISBN;
            hiddenAuthor = author;
            hiddenPages = pages;
        }  // end parameterized constructor



        // These six methods replace what were VB Properties
        // get or set an item in the List
        // Accessor/mutator for Tuition, Year and Credits
        public int BookLeftISBN
        {
            get
            {
                return hiddenLeftISBN;
            }
            set
            {
                hiddenLeftISBN = value;
            }
        }
        public int BookRightISBN
        {
            get
            {
                return hiddenRightISBN;
            }
            set
            {
                hiddenRightISBN = value;
            }
        }
        public string BookAuthor
        {
            get
            {
                return hiddenAuthor;
            }
            set
            {
                hiddenAuthor = value;
            }
        }
        public int BookPages
        {
            get
            {
                return hiddenPages;
            }
            set
            {
                hiddenPages = value;
            }
        }

        // Save data from form to object
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenLeftISBN = Convert.ToInt32(f.txtBookISBNLeft.Text);
            hiddenRightISBN = Convert.ToInt32(f.txtBookISBNRight.Text);
            hiddenAuthor = f.txtBookAuthor.Text;
            hiddenPages = Convert.ToInt32(f.txtBookPages.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookISBNLeft.Text = hiddenLeftISBN.ToString();
            f.txtBookISBNRight.Text = hiddenRightISBN.ToString();
            f.txtBookAuthor.Text = hiddenAuthor;
            f.txtBookPages.Text = hiddenPages.ToString();
        }  // end Display


        // This toString function overrides the Student toString
        // function.  The base refers to the Student because this class
        // inherits Student by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "ISBN:  " + hiddenLeftISBN + "-" + hiddenRightISBN + "\n";
            s += "Author:  " + hiddenAuthor + "\n";
            s += "Pages:  " + hiddenPages;
            return s;
        } //  end ToString

    }  // end Book Class
}  // end namespace
