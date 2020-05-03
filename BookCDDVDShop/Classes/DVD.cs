using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop.Classes
{
    [Serializable()]
    class DVD : Product
    {
        private string hiddenDVDLeadActor;
        private DateTime hiddenDVDReleaseDate;
        private int hiddenDVDRuntime;

        //parameterless constuctor
        public DVD()
        {
            hiddenDVDLeadActor = "";
            hiddenDVDReleaseDate = new DateTime(2000, 01, 01);
            hiddenDVDRuntime = 0;
        }//end of parameterless constructor

        //parameterized constructor
        public DVD(int UPC, decimal price, string title, int quantity, string DVDLeadActor,
            DateTime DVDReleaseDate, int DVDRuntime):base(UPC, price, title, quantity)
        {
            hiddenDVDLeadActor = DVDLeadActor;
            hiddenDVDReleaseDate = DVDReleaseDate;
            hiddenDVDRuntime = DVDRuntime;
        }//end of parameterized constructor
        public string DVDLeadActor //get and set lead actor
        {
            get
            {
                return hiddenDVDLeadActor;
            }
            set
            {
                hiddenDVDLeadActor = value;
            }
        }//end of get and set lead actor
        public DateTime DVDReleaseDate
        {
            get
            {
                return hiddenDVDReleaseDate;
            }
            set
            {
                hiddenDVDReleaseDate = value;
            }
        }//end get and set DVD Release Date
        public int DVDRuntime
        {
            get
            {
                return hiddenDVDRuntime;
            }
            set
            {
                hiddenDVDRuntime = value;
            }
        }//end of get and set DVD runtime

        //save data in object on form
        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenDVDLeadActor = f.txtDVDLeadActor.Text;
            hiddenDVDReleaseDate = DateTime.Parse(f.txtDVDReleaseDate.Text);
            hiddenDVDRuntime = Convert.ToInt32(f.txtDVDRunTime.Text);
        }//end of save
        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtDVDLeadActor.Text = hiddenDVDLeadActor;
            f.txtDVDReleaseDate.Text = hiddenDVDReleaseDate.ToString();
            f.txtDVDRunTime.Text = hiddenDVDRuntime.ToString();
        }//end of display
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Lead Actor:  " + hiddenDVDLeadActor + "\n";
            s += "Release Date:  " + hiddenDVDReleaseDate + "\n";
            s += "Run Time :  " + hiddenDVDRuntime + "\n";
            return s;
        }//end to string

    }//end of DVD Class
}//end of namespace
