using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

/* Eric Rosenblatt & Max Robins
 * CIS 3309
 * 05/04/2020
 * Project 4 - BookCDDVDShop
 * ProductList class
 */

namespace BookCDDVDShop.Classes
{
    
    //the productList class holds a list of products that could be added/edited/deleted to/from the list
    //the products in the list can be either book, bookcis, cdclassical, cdchamber, cdorchestra due to inheritance

    public class ProductList
    {
        private List<Product> hiddenProductList;
        private int index;
        public ProductList()
        {
            hiddenProductList = new List<Product>(4);
        }
        public int getIndex()
        {
            return index;
        }//end of get index
        public Product getAnItem(int productUPC)//change to search for UPC
        {
            foreach (Product product in hiddenProductList)//checks every product in the list
            {
                if (product.ProductUPC == productUPC)
                {
                    return product;//returns product with matching UPC
                }
            }
            MessageBox.Show("There is no product with the entered UPC in the system");
            return null;
        } // end getAnItem
        public bool checkForDuplicate(int UPC)
        {
            foreach(Product product in hiddenProductList)//checks every product in the list
            {
                if(product.ProductUPC == UPC)
                {
                    return true;
                }
            }
            return false;//if none of the products match the given UPC
        }//end of check duplicates

        public void setAnItem(Product value)//check to make sure this works
        {
            int productUPC = value.ProductUPC;//sets product UPC to the incoming product (should be same as product being set)
            Product productInList = getAnItem(productUPC);
            productInList = value;

        } // end set
        public void addAnItem(Product value)
        {
            hiddenProductList.Add(value);
            MessageBox.Show("Product has been added.");
        }
        public void removeAnItem(Product value)
        {
            hiddenProductList.Remove(value);
            MessageBox.Show("Product has been deleted.");
        }
        public int Count()
        {
            return hiddenProductList.Count;
        }
    }
}
