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
 * CDOrchestra class
 */

namespace BookCDDVDShop.Classes
{
    //CD Orchestra inherits the data and methods from the CDClassical class
    [Serializable()]
    class CDOrchestra : CDClassical
    {
        private string hiddenConductor;

        //parameterless constructor
        public CDOrchestra()
        {
            hiddenConductor = "";
        }//end parameterless constructor

        //parameterized constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity, string label, string artists,
            string conductor) : base(UPC, price, title, quantity, label, artists)
        {
            hiddenConductor = conductor;
        }//end of parameterized constructor

        public string OrchestraConductor
        {
            get
            {
                return hiddenConductor;
            }
            set
            {
                hiddenConductor = value;
            }
        }//end of get and set conductor

        public override void Save(frmBookCDDVDShop f)
        {
            base.Save(f);
            hiddenConductor = f.txtCDOrchestraConductor.Text;
        }//end save

        public override void Display(frmBookCDDVDShop f)
        {
            base.Display(f);
            f.txtCDOrchestraConductor.Text = hiddenConductor;
        }//end of display

        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Conductor:  " + hiddenConductor;
            return s;
        }//end of tostring

    }//end of CDOrchestra Class
}//end of namespace
