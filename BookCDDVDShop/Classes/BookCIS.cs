using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serializati
using System.Runtime.Serialization.Formatters.Binary;

/* Eric Rosenblatt & Max Robins
 * CIS 3309
 * 05/04/2020
 * Project 4 - BookCDDVDShop
 * Book CIS class
 */

namespace BookCDDVDShop.Classes
{
    // Book CIS inherits the data and methods in Product and can be a serialized to a binary file

    [Serializable()]
    class BookCIS : Book
    {
        private string hiddenBookCISArea;

        //parameterless Constructor
        public BookCIS()
        {
            hiddenBookCISArea = "";
        }//end parameterless constuctor

        //Parameterized constuctor
        public BookCIS(int UPC, decimal price, string title, int quantity,
            int leftISBN, int rightISBN, string author, int pages, string CISArea) :
            base(UPC, price, title, quantity, leftISBN, rightISBN, author, pages)
        {
            hiddenBookCISArea = CISArea;
        }//ends parameterized constuctor
        public string BookCISArea//get/set for CIS Area
        {
            get
            {
                return hiddenBookCISArea;
            }
            set
            {
                hiddenBookCISArea = value;
            }
        }//end of get set CIS Area
        public override void Save(frmBookCDDVDShop f)//save data from form to object
        {
            base.Save(f);
            hiddenBookCISArea = f.txtBookCISCISArea.Text;
        }//end save
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtBookCISCISArea.Text = hiddenBookCISArea;
        }//end display
        public override string ToString()
        {
            string s =  base.ToString() + "\n";
            s += "Book CIS Area:  " + hiddenBookCISArea;
            return s;
        }//end to string

    }//end CIS Book Class
}//end namepace
