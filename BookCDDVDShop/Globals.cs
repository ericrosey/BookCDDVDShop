using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookCDDVDShop
{
    class Globals
    {
        // NOTE:
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        // private static string currentFilePath = "CurrentProductFile.txt";

        // Application classes
        // public static currentFileClass currentFile = new currentFileClass(currentFilePath);
        // public static updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Creating instances of all the forms ...
        public static frmBookCDDVDShop ff = new frmBookCDDVDShop();

        // For communication between forms ... not needed for this project??
        // public static string FormsCode = "";

    } // end Global Data Class

} // end namespace
