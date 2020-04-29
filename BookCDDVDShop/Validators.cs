// Validators Class
// Responsible for all validation processing.  Includes validators that are part of VB but not CSHarp 
// Written in CSharp by Frank Friedman     Spring 2016

// Revised: June 16, 2017
// Revised: June 27, 2018

// This class contains "static" methods to handle required data validations for this Temple Owl project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop
{
    // This class cannot be instantiated
    // It contains a collection of methods called to validate all input data from our Form
    public static class Validators
    {
        // Validate Form data for a Product
        public static bool ValidateProduct
           (string UPC, string price, string title, string quantity)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
                return true;
            else
                return false;
        }  // end ValidateProduct
       
        // Validate Product UPC
        public static bool ValidateProductUPC(string UPC)    // IN: Product's UPC (must be a 5 digit value with no preceding 0)
        {
            if (UPC == "" || UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters. Re-enter.", "Product UPC Error");
                return false;
            }  // end Product UP blank

            if (UPC[0] == '0')
            {
                MessageBox.Show("Product UPC was began with a 0. Re-enter.", "Product UPC Error");
                return false;
            }

            // Using Regex to validate the Product UPC text box to contain exactly 5 digits 
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Product UPC must be a 5 digit value with no leading zeros. Reenter.",
                    "Regex Product UPC Error");
                return false;
            }  // end Product UPC Regex test
            return true;   // Passed all tests
        }  // end Validate ProductUPC

        //validate the products prices
        public static bool ValidateProductPrice(string price)
        {
            try
            {

                decimal productPrice = Convert.ToDecimal(String.Format("{0:.##}", price));//makes sure the number can be a decimal
                if (productPrice > 0)//price must be greater than 0
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Product Price must be a decimal value.");
                return false;
            }
        }//end of validate product price
        public static bool ValidateProductTitle(string title)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(title, @"^([A-Z]{1}[a-z]*\s?)+$"))//checks for proper validity of title
            {
                MessageBox.Show("You must capitalize only the first letter of every word.\n"
                    + "No numbers are allowed in the title.");
                return false;
            }
            else
            {
                return true;
            }
        }//end of validate product title
        public static bool ValidateProductQuantity(string quantity)
        {
            try
            {
                int productQuantity = Convert.ToInt32(quantity);//see if quantity can be an integer
                if(productQuantity > 0)//quantity must be greater than 0
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The product quantity must be greater than 0");
                    return false;//quantity is less than 0
                }
            }
            catch//if it can't be converted to an integer
            {
                MessageBox.Show("The product quantity must be an integer/number");
                return false;
            }
        }//end of validate product quantity
        public static bool ValidateBook(string UPC, string price, string title, string quantity, string leftISBN,
           string rightISBN, string author, string pages)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity)
                && ValidateBookISBN(leftISBN) && ValidateBookISBN(rightISBN) && ValidateBookAuthor(author) && ValidateBookPages(pages))
                return true;
            else
                return false;
        }//end validate book 
        
        public static bool ValidateBookISBN(string ISBN)//checking both sides of ISBN
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ISBN, @"^[\d]{3}$"))//checks if ISBN parts are 3 number digits
            {
                return true;
            }
            else
            {
                MessageBox.Show("Left and Right ISBN's must be 3 digits 0-9");
                return false;
            }
        }//end of validate ISBN
        public static bool ValidateBookAuthor(string author)//validates the author name(s)
        {
            if(author == "" || author == " ")//checks for empty string
            {
                MessageBox.Show("Must fill in the book author. Information is blank.");
                return false;
            }
            if (author.Contains(","))//checks if theres authors seperated by commas (more than one author)
            {
                string[] authorString = author.Split(',');//splits author names using commas
                for(int i = 0; i < authorString.Length; i++)
                {
                    authorString[i] = authorString[i].Trim();//trims extra spaces that may be on ends
                    if (!System.Text.RegularExpressions.Regex.IsMatch(authorString[i], @"^([A-Z]{1}[a-z]*\s?)+$"))//if their name isn't capitalized or has numbers
                    {
                        MessageBox.Show("Must format your authors correctly.\n" + 
                            "More than one author should be seperated by commas and make sure you capitalize their names.");
                        return false;
                    }
                }
            }
            else//if theres only one author 
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(author, @"^([A-Z]{1}[a-z]*\s?)+$"))//checking a singular author
                {
                    MessageBox.Show("Author names must be capitalized and cannot contain any numbers");
                    return false;
                }
            }
            return true;//if the author input makes it through all the checks
        }//end of validate book author
        public static bool ValidateBookPages(string pages)
        {
            try
            {
                int bookPages = Convert.ToInt32(pages);//see if pages can be an integer
                if(bookPages > 0)//make sure there is more than one page
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("There must be greater than 0 pages in the book.");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Number of pages must be a number");
                return false;
            }
        }
        public static bool ValidateBookCIS(string UPC, string price, string title, string quantity, string leftISBN,
           string rightISBN, string author, string pages, string CISArea)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity)
                && ValidateBookISBN(leftISBN) && ValidateBookISBN(rightISBN) && ValidateBookAuthor(author) && ValidateBookPages(pages) && ValidateBookCISArea(CISArea))
                return true;
            else
                return false;
        }//end validate book cis
        public static bool ValidateBookCISArea(string CISArea)
        {
            if(CISArea =="" || CISArea == " ")//checks if empty string
            {
                MessageBox.Show("Must complete information about the book's CIS Area.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(CISArea, @"^([A-Z]{1}([a-z]|\+|\#|)*\s?\d*)+$"))//covers things for C+/C# and capitals
            {
                MessageBox.Show("Capitalize all words in the CIS Area");
                return false;
            }
            return true;//if it passes all the attempts
        }//end of validate book cis area
        public static bool ValidateDVD(string UPC, string price, string title, string quantity, string leadActor, string releaseDate, string runTime)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity)
                && ValidateDVDLeadActor(leadActor) && ValidateDVDReleaseDate(releaseDate) && ValidateDVDRunTime(runTime))
                return true;
            else
                return false;
        }//end of validate dvd
        public static bool ValidateDVDLeadActor(string leadActor)
        {
            if (leadActor == "" || leadActor == " ")//checks for empty string
            {
                MessageBox.Show("Must fill in the book author. Information is blank.");
                return false;
            }
            if (leadActor.Contains(","))//checks if theres actors seperated by commas (more than one actor)
            {
                string[] actorString = leadActor.Split(',');//splits actor names using commas
                for (int i = 0; i < actorString.Length; i++)
                {
                    actorString[i] = actorString[i].Trim();//trims extra spaces that may be on ends
                    if (!System.Text.RegularExpressions.Regex.IsMatch(actorString[i], @"^([A-Z]{1}[a-z]*\s?)+$"))//if their name isn't capitalized or has numbers
                    {
                        MessageBox.Show("Must format your lead actors correctly.\n" +
                            "More than one lead actors should be seperated by commas and make sure you capitalize their names.");
                        return false;
                    }
                }
            }
            else//if theres only one lead actor
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(leadActor, @"^([A-Z]{1}[a-z]*\s?)+$"))//checking a singular actor
                {
                    MessageBox.Show("Lead actor names must be capitalized and cannot contain any numbers");
                    return false;
                }
            }
            return true;//if the actor input makes it through all the checks
        }
        public static bool ValidateDVDReleaseDate(string releaseDate)//input should be mm/dd/yyyy
        {
            try
            {
                DateTime DVDreleaseDate = DateTime.Parse(releaseDate);
                DateTime minDate = new DateTime(1980, 01, 01);//create the minimum date for comparison
                DateTime maxDate = new DateTime(2019, 12, 31);//create the maximum date for comparison
                if(DVDreleaseDate.Year < minDate.Year || DVDreleaseDate.Year > maxDate.Year)
                {
                    MessageBox.Show("Release dates must be within the dates 01/01/1980 and 12/31/2019");
                    return false;//if release date is out of specified range
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("The DVD release date must be in the format MM/dd/yyyy.");
                return false;
            }
        }//end validate dvd release date
        public static bool ValidateDVDRunTime(string runTime)
        {
            try
            {
                int DVDRunTime = Convert.ToInt32(runTime);
                if(DVDRunTime > 0 && DVDRunTime < 240)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The DVD run time must be greater than 0 minutes and less than 240 minutes.");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("The DVD run time must be in a number format represented in minutes.");
                return false;
            }
        }//end validate dvd runtime
        public static bool ValidateCDChamber(string UPC, string price, string title, string quantity, string label, string artists, string instruments)
        {
            if(ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity) && ValidateCDClassicalLabel(label)
                && ValidateCDClassicalArtists(artists) && ValidateCDChamberInstruments(instruments))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end validate cd chamber
        public static bool ValidateCDClassicalLabel(string label)
        {
            if(label == "" || label == " ")
            {
                MessageBox.Show("Must fill in information for the CD Chamber label.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(label, @"^([A-Z]{1}[a-z]*\s?)+$"))//using same regex as author, taking out period option
            {
                MessageBox.Show("Labels must be capitalized and numbers are not allowed.");
                return false;
            }
            return true;//if label passes all tests
        }//validate cd classical label
        public static bool ValidateCDClassicalArtists(string artists)
        {
            if (artists == "" || artists == " ")//checks for empty string
            {
                MessageBox.Show("Must fill in the book artist. Information is blank.");
                return false;
            }
            if (artists.Contains(","))//checks if theres artist seperated by commas (more than one artist)
            {
                string[] artistsString = artists.Split(',');//splits artist names using commas
                for (int i = 0; i < artistsString.Length; i++)
                {
                    artistsString[i] = artistsString[i].Trim();//trims extra spaces that may be on ends
                    if (!System.Text.RegularExpressions.Regex.IsMatch(artistsString[i], @"^([A-Z]{1}[a-z]*\s?)+$"))//if their name isn't capitalized or has numbers
                    {
                        MessageBox.Show("Must format your artists correctly.\n" +
                            "More than one artist should be seperated by commas and make sure you capitalize their names.");
                        return false;
                    }
                }
            }
            else//if theres only one author 
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(artists, @"^([A-Z]{1}[a-z]*\s?)+$"))//checking a singular artist
                {
                    MessageBox.Show("Artist names must be capitalized and cannot contain any numbers");
                    return false;
                }
            }
            return true;//if the artist input makes it through all the checks
        }//end of cd classical artist check
        public static bool ValidateCDChamberInstruments(string instruments)
        {
            if (instruments == "" || instruments == " ")//checks for empty string
            {
                MessageBox.Show("Must fill in the book instruments. Information is blank.");
                return false;
            }
            if (instruments.Contains(","))//checks if theres instruments seperated by commas (more than one instrument)
            {
                string[] instrumentString = instruments.Split(',');//splits instrument names using commas
                for (int i = 0; i < instrumentString.Length; i++)
                {
                    instrumentString[i] = instrumentString[i].Trim();//trims extra spaces that may be on ends
                    if (!System.Text.RegularExpressions.Regex.IsMatch(instrumentString[i], @"^([A-Z]{1}[a-z]*\s?)+$"))//if the name isn't capitalized or has numbers
                    {
                        MessageBox.Show("Must format your instruments correctly.\n" +
                            "More than one instrument should be seperated by commas and make sure you capitalize the instrument names.");
                        return false;
                    }
                }
            }
            else//if theres only one instrument
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(instruments, @"^([A-Z]{1}[a-z]*\s?)+$"))//checking a singular instrument
                {
                    MessageBox.Show("Instrument names must be capitalized and cannot contain any numbers");
                    return false;
                }
            }
            return true;//if the instrument input makes it through all the checks
        }//end of instrument validation
        public static bool ValidateCDOrchestra(string UPC, string price, string title, string quantity, string label, string artists, string conductor)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity) && ValidateCDClassicalLabel(label)
                && ValidateCDClassicalArtists(artists) && ValidateCDOrchestraConductor(conductor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end validate cd orchestra
        public static bool ValidateCDOrchestraConductor(string conductor)
        {
            if(conductor == "" || conductor == " ")
            {
                MessageBox.Show("Must fill in CD Orchestra conductor information.");
                return false;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(conductor, @"^([A-Z]{1}[a-z]*\s?)+$"))//checking a singular conductor
            {
                MessageBox.Show("The conductor's name must be capitalized and cannot contain any numbers");
                return false;
            }
            return true;//if it passes the tests
        }//end of validate orchestra conductor

    }//end of static class validators
}//end of namespace