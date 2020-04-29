using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookCDDVDShop.Classes;

// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace BookCDDVDShop
{
    public partial class frmBookCDDVDShop : Form
    {
        // This is a class object that manages a List of Products		
        ProductList thisProductList = new ProductList();

        // This index keeps track of the current Owl
        int currentIndex = -1;

        int recordsProcessedCount = 0;
        // File to read or write to
        string FileName = "PersistentObject.bin";

        // Database methods and attributes stored here
        //ProductDB dbFunctions = new ProductDB();// Parameterless Constructor for fmrEmpMan
        public frmBookCDDVDShop()
        {
            InitializeComponent();
        }  // end frmEmpMan Parameterless Constructor


        // Tooltip messages
        string ttCreateCDChamber = "Click to enter Make CDChamber mode to add a CDChamber to the List of Products.";
        string ttCreateCDOrchestra = "Click to enter Make CDOrchestra mode to add a CDOrchestra to the List of Products.";
        string ttCreateBook = "Click to enter Make Book mode to add a Book to the List of Products.";
        string ttCreateBookCIS = "Click to enter Make BookCIS mode to add a BookCIS to the List of Products.";
        string ttCreateDVD = "Click to enter Make DVD mode to add a DVD to the List of Products.";
        string ttSaveCDChamber = "Click to Save a CDChamber object to the List of Products.";
        string ttSaveCDOrchestra = "Click to Save a CDOrchestra object to the List of Products.";
        string ttSaveBookCIS = "Click to Save a BookCIS object to the list of Products.";
        string ttSaveBook = "Click to Save the Book object to the List of Products.";
        string ttSaveDVD = "Click to Save the DVD to the List of Products.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Product in the List of Products.";
        string ttDelete = "Click to Delete Product from the List of Products.";
        string ttEdit = "Click to Edit a Product's data.";
        string ttExit = "Click to exit application.";

        // ?????????? Fix The Specs (in red) for Each Item ??????????

        string ttProductUPC = "Enter a 5 digit integer - no leading zeros";
        string ttProductPrice = "Enter dollars and cents >= 0.0. NO $. Exactly two decimal digits";
        string ttProductTitle = "Enter a string of words (all letters) separated by blanks for any item in the shop";
        string ttProductQuantity = "Enter any integer greater than or equal to 0";
        string ttBookISBN = "Enter Book ISBN in format nnn-nnn)";
        string ttBookAuthor = "Enter Book Author first and last names (all letters) separated by a blank";
        string ttBookPages = "Enter Book page count as an integer greater than 0.";
        string ttDVDLeadActor = "Enter DVD Lead Actor with first and last names (all letters) separated by a blank.";
        string ttDVDReleaseDate = "Enter DVD Release Date in form mm/dd/yyyy between Jan 1 1980 and Dec 31 2019. Use date picker.";
        string ttDVDRunTime = "Enter DVD run time in minutes. Must be a positive integer.";
        string ttBookCISCISArea = "Enter valid CIS area of study using a drop-down menu.";
        string ttCDClassicalLabel = "Enter any sequence of words (all letters) separated by blanks.";
        string ttCDClassicalArtists = "Enter soloists last names separated by a blank";
        string ttCDChamberInstrumentList = "Enter Instrument names separated by a blank";
        string ttCDOrchestraConductor = "Enter Conductor last name with all letters and one blank or one hyphen";

        //*****This section has the forms load and closing events

        // This sub is called when the form is loaded
        private void frmBookCDDVDShop_Load(System.Object sender, System.EventArgs e)
        {
            // Read serialized binary data file
            //SFManager.readFromFile(ref thisProductList, FileName);
            FormController.clear(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateBookCIS, ttCreateBookCIS);
            toolTip1.SetToolTip(btnCreateBook, ttCreateBook);
            toolTip1.SetToolTip(btnCreateCDChamber, ttCreateCDOrchestra);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttCreateDVD);
            toolTip1.SetToolTip(btnCreateDVD, ttCreateCDChamber);

            toolTip1.SetToolTip(btnResetForm, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtProductUPC, ttProductUPC);
            toolTip1.SetToolTip(txtProductPrice, ttProductPrice);
            toolTip1.SetToolTip(txtProductQuantity, ttProductQuantity);
            toolTip1.SetToolTip(txtProductTitle, ttProductTitle);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtBookISBNLeft, ttBookISBN);
            toolTip1.SetToolTip(txtBookAuthor, ttBookAuthor);
            toolTip1.SetToolTip(txtBookPages, ttBookPages);
            toolTip1.SetToolTip(txtDVDLeadActor, ttDVDLeadActor);
            toolTip1.SetToolTip(txtDVDReleaseDate, ttDVDReleaseDate);
            toolTip1.SetToolTip(txtDVDRunTime, ttDVDRunTime);
            toolTip1.SetToolTip(txtCDClassicalLabel, ttCDClassicalLabel);
            toolTip1.SetToolTip(txtCDClassicalArtists, ttCDClassicalArtists);
            toolTip1.SetToolTip(txtCDOrchestraConductor, ttCDOrchestraConductor);
            toolTip1.SetToolTip(txtCDChamberInstrumentList, ttCDChamberInstrumentList);
            toolTip1.SetToolTip(txtBookCISCISArea, ttBookCISCISArea);
        } // end frmEBookCDDVDShop_Load

        // Clear textboxes
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of records processed = " +
                recordsProcessedCount.ToString(),
                "Exit Message", MessageBoxButtons.OK);
            MessageBox.Show("The list entries are ...", "Display List Entries");
            //thisProductList.displayProductList();

            // Save serialized binary file
            //SFManager.writeToFile(thisProductList, FileName);

            this.Close();

        }
        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            if(btnCreateBook.Text == "Create Book")
            {
                DisplayBookForm();
                btnEnterUPC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving");
                if(Validators.ValidateBook(txtProductUPC.Text, txtProductPrice.Text, txtProductTitle.Text, txtProductQuantity.Text,
                    txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text))
                {
                    MessageBox.Show("Passed Book Test");
                    Book x = new Book();
                    x.Save(this);//x now has all values in textboxes
                    MessageBox.Show(x.ToString());
                    thisProductList.addAnItem(x);
                    btnCreateBook.Enabled = false;
                }
            }   
        }//end of create book button click method
        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            if(btnCreateBookCIS.Text == "Create Book CIS")
            {
                DisplayBookCISForm();
                btnEnterUPC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving");
                if(Validators.ValidateBookCIS(txtProductUPC.Text, txtProductPrice.Text, txtProductTitle.Text, txtProductQuantity.Text,
                    txtBookISBNLeft.Text, txtBookISBNRight.Text, txtBookAuthor.Text, txtBookPages.Text, txtBookCISCISArea.Text))
                {
                    MessageBox.Show("Passed CIS Book Test");
                    BookCIS x = new BookCIS();
                    x.Save(this);//x now has all values in textboxes
                    MessageBox.Show(x.ToString());
                    thisProductList.addAnItem(x);
                    btnCreateBookCIS.Enabled = false;
                }
            }
        }//end of create book cis click method

        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            if(btnCreateDVD.Text == "Create DVD")
            {
                DisplayDVDForm();
                btnEnterUPC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving");
                if(Validators.ValidateDVD(txtProductUPC.Text, txtProductPrice.Text, txtProductTitle.Text, txtProductQuantity.Text, txtDVDLeadActor.Text, 
                    txtDVDReleaseDate.Text, txtDVDRunTime.Text))
                {
                    MessageBox.Show("Passed DVD Test");
                    DVD x = new DVD();
                    x.Save(this);//x now has all values in textboxes
                    MessageBox.Show(x.ToString());
                    thisProductList.addAnItem(x);
                    btnCreateDVD.Enabled = false;
                }
            }
        }//end of create dvd button click method

        private void btnCreateCDOrchestra_Click(object sender, EventArgs e)
        {
            if(btnCreateCDOrchestra.Text == "Create CD Orchestra")
            {
                DisplayCDOrchestra();
                btnEnterUPC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving");
                if (Validators.ValidateCDOrchestra(txtProductUPC.Text, txtProductPrice.Text, txtProductTitle.Text, txtProductQuantity.Text,
                    txtCDClassicalLabel.Text, txtCDClassicalArtists.Text, txtCDOrchestraConductor.Text))
                {
                    MessageBox.Show("Passed CD Orchestra Test");
                    CDOrchestra x = new CDOrchestra();
                    x.Save(this);//x now has all values in textboxes
                    MessageBox.Show(x.ToString());
                    thisProductList.addAnItem(x);
                    btnCreateCDOrchestra.Enabled = false;
                }
            }
        }//end of ochestra click method

        private void btnCreateCDChamber_Click(object sender, EventArgs e)
        {
            if(btnCreateCDChamber.Text == "Create CD Chamber")
            {
                DisplayCDChamberForm();
                btnEnterUPC.Enabled = false;
            }
            else
            {
                MessageBox.Show("Saving");
                if(Validators.ValidateCDChamber(txtProductUPC.Text, txtProductPrice.Text, txtProductTitle.Text, txtProductQuantity.Text,
                    txtCDClassicalLabel.Text, txtCDClassicalArtists.Text, txtCDChamberInstrumentList.Text))
                {
                    MessageBox.Show("Passed CD Chamber Test");
                    CDChamber x = new CDChamber();
                    x.Save(this);//now x has all values in textboxes
                    MessageBox.Show(x.ToString());
                    thisProductList.addAnItem(x);
                    btnCreateCDChamber.Enabled = false;
                }
            }
        }//end of create chamber on click method
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            FormController.clear(this);
            btnEnterUPC.Text = "Click HERE to enter a UPC";
            btnDelete.Text = "Delete";
        }
        void DisplayCDChamberForm()
        {
            // Display form for Create/Insert or Find/SELECT or Edit/Update or Delete a Chamber Music CD
            btnCreateCDChamber.Enabled = true;
            btnCreateCDChamber.Text = "Save CD Chamber";
            FormController.formAddMode(this);
            txtProductUPC.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductTitle.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtDVDLeadActor.Enabled = false;
            txtDVDReleaseDate.Enabled = false;
            txtDVDRunTime.Enabled = false;
            txtBookISBNLeft.Enabled = false;
            txtBookISBNRight.Enabled = false;
            txtBookAuthor.Enabled = false;
            txtBookPages.Enabled = false;
            txtBookCISCISArea.Enabled = false;
            txtCDClassicalLabel.Enabled = true;
            txtCDClassicalArtists.Enabled = true;
            txtCDOrchestraConductor.Enabled = false;
            txtCDChamberInstrumentList.Enabled = true;

            btnCreateBookCIS.Enabled = false;
            btnCreateBook.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;

            FormController.activateCDChamber(this);
            FormController.deactivateCDOrchestra(this);
            FormController.deactivateDVD(this);
            FormController.deactivateBook(this);
            FormController.deactivateBookCIS(this);
            toolTip1.SetToolTip(btnCreateCDChamber, ttSaveCDChamber);
            txtProductUPC.Focus();
        } // end DisplayCDChamberForm
        void DisplayBookForm()
        {
            btnCreateBook.Enabled = true;
            btnCreateBook.Text = "Save Book";
            FormController.formAddMode(this);
            txtProductUPC.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductTitle.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtDVDLeadActor.Enabled = false;
            txtDVDReleaseDate.Enabled = false;
            txtDVDRunTime.Enabled = false;
            txtBookISBNLeft.Enabled = true;
            txtBookISBNRight.Enabled = true;
            txtBookAuthor.Enabled = true;
            txtBookPages.Enabled = true;
            txtBookCISCISArea.Enabled = false;
            txtCDClassicalLabel.Enabled = false;
            txtCDClassicalArtists.Enabled = false;
            txtCDChamberInstrumentList.Enabled = false;
            txtCDOrchestraConductor.Enabled = false;

            btnCreateBookCIS.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnCreateCDChamber.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;

            FormController.activateBook(this);
            FormController.deactivateBookCIS(this);
            FormController.deactivateCDChamber(this);
            FormController.deactivateCDOrchestra(this);
            FormController.deactivateDVD(this);
            toolTip1.SetToolTip(btnCreateBook, ttSaveBook);
            txtProductUPC.Focus();
        }//end displayBookForm
        void DisplayBookCISForm()
        {
            btnCreateBookCIS.Enabled = true;
            btnCreateBookCIS.Text = "Save Book CIS";
            FormController.formAddMode(this);
            txtProductUPC.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductTitle.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtDVDLeadActor.Enabled = false;
            txtDVDReleaseDate.Enabled = false;
            txtDVDRunTime.Enabled = false;
            txtBookISBNLeft.Enabled = true;
            txtBookISBNRight.Enabled = true;
            txtBookAuthor.Enabled = true;
            txtBookPages.Enabled = true;
            txtBookCISCISArea.Enabled = true;
            txtCDClassicalLabel.Enabled = false;
            txtCDClassicalArtists.Enabled = false;
            txtCDOrchestraConductor.Enabled = false;
            txtCDChamberInstrumentList.Enabled = false;

            btnCreateBook.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;
            btnCreateCDChamber.Enabled = false;

            FormController.activateBookCIS(this);
            FormController.deactivateCDOrchestra(this);
            FormController.deactivateCDChamber(this);
            FormController.deactivateDVD(this);
            toolTip1.SetToolTip(btnCreateBookCIS, ttSaveBookCIS);
            txtProductUPC.Focus();
        }//end of display bookCIS
        void DisplayDVDForm()
        {
            btnCreateDVD.Enabled = true;
            btnCreateDVD.Text = "Save DVD";
            FormController.formAddMode(this);
            txtProductUPC.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductTitle.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtDVDLeadActor.Enabled = true;
            txtDVDReleaseDate.Enabled = true;
            txtDVDRunTime.Enabled = true;
            txtBookISBNLeft.Enabled = false;
            txtBookISBNRight.Enabled = false;
            txtBookAuthor.Enabled = false;
            txtBookPages.Enabled = false;
            txtBookCISCISArea.Enabled = false;
            txtCDClassicalLabel.Enabled = false;
            txtCDClassicalArtists.Enabled = false;
            txtCDOrchestraConductor.Enabled = false;
            txtCDChamberInstrumentList.Enabled = false;

            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateCDChamber.Enabled = false;
            btnCreateCDOrchestra.Enabled = false;

            FormController.activateDVD(this);
            FormController.deactivateBook(this);
            FormController.deactivateBookCIS(this);
            FormController.deactivateCDChamber(this);
            FormController.deactivateCDOrchestra(this);
            toolTip1.SetToolTip(btnCreateDVD, ttSaveDVD);
            txtProductUPC.Focus();
        }//end of display dvd
        void DisplayCDOrchestra()
        {
            btnCreateCDOrchestra.Enabled = true;
            btnCreateCDOrchestra.Text = "Save CD Orchestra";
            FormController.formAddMode(this);
            txtProductUPC.Enabled = true;
            txtProductPrice.Enabled = true;
            txtProductTitle.Enabled = true;
            txtProductQuantity.Enabled = true;
            txtDVDLeadActor.Enabled = false;
            txtDVDReleaseDate.Enabled = false;
            txtDVDRunTime.Enabled = false;
            txtBookISBNLeft.Enabled = false;
            txtBookISBNRight.Enabled = false;
            txtBookAuthor.Enabled = false;
            txtBookPages.Enabled = false;
            txtBookCISCISArea.Enabled = false;
            txtCDClassicalLabel.Enabled = true;
            txtCDClassicalArtists.Enabled = true;
            txtCDOrchestraConductor.Enabled = true;
            txtCDChamberInstrumentList.Enabled = false;

            btnCreateBook.Enabled = false;
            btnCreateBookCIS.Enabled = false;
            btnCreateDVD.Enabled = false;
            btnCreateCDChamber.Enabled = false;

            FormController.activateCDOrchestra(this);
            FormController.deactivateBook(this);
            FormController.deactivateBookCIS(this);
            FormController.deactivateCDChamber(this);
            FormController.deactivateDVD(this);
            toolTip1.SetToolTip(btnCreateCDOrchestra, ttSaveCDOrchestra);
            txtProductUPC.Focus();
        }//end display CD Orchestra

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool success;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnSaveEditUpdate.Enabled = false;
            
            success = thisProductList.checkForDuplicate(Convert.ToInt32(txtProductUPC.Text));//call find an item 
            if (success)
            {
                btnSaveEditUpdate.Enabled = true;
                btnEdit.Enabled = false;

                Product p = thisProductList.getAnItem(Convert.ToInt32(txtProductUPC.Text));// search by UCP and return reference to product
                txtProductPrice.Text = p.ProductPrice.ToString();
                txtProductUPC.Text = p.ProductUPC.ToString();
                txtProductQuantity.Text = p.ProductQuantity.ToString();
                txtProductTitle.Text = p.ProductTitle.ToString();
                MessageBox.Show("Edit/UPDATE current Product (as shown). Press Save Updates Button", "Edit/Update Notice",
                    MessageBoxButtons.OK);
                if (p.GetType() == typeof(CDChamber))
                {
                    FormController.activateCDChamber(this);
                    FormController.deactivateAllButCDChamber(this);
                    FormController.deactivateAddButtons(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDChamberInstrumentList.Text = ((CDChamber)p).getCDChamberInstrumentList();

                    
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDOrchestraConductor.Text = ((CDOrchestra)p).OrchestraConductor;
                }
                else if (p.GetType() == typeof(Book))
                {
                    FormController.activateBook(this);
                    FormController.deactivateAllButBook(this);
                    FormController.deactivateAddButtons(this);

                    txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = ((Book)p).BookPages.ToString();
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);

                    txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = (((Book)p).BookPages).ToString();
                    txtBookCISCISArea.Text = ((BookCIS)p).BookCISArea;
                }  // end multiple alternative if

                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);

                    txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                    txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("mm/dd/yyyy");
                    txtDVDRunTime.Text = (((DVD)p).DVDRuntime).ToString();
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                        "Mis-typed Object", MessageBoxButtons.OK);
                    this.Close();
                }  // end multiple alternative if
            }  // end if on success
        }//end of edit on click method

        private void btnEnterUPC_Click(object sender, EventArgs e)
        {
            if(btnEnterUPC.Text == "Click HERE to enter a UPC")
            {
                FormController.deactivateAddButtons(this);
                txtProductUPC.Enabled = true;

                MessageBox.Show("Enter the desired product UPC above. Then click 'Check for Product' to continue.");

                btnEnterUPC.Text = "Check for Product";
            }
            else
            {
                if(Validators.ValidateProductUPC(txtProductUPC.Text))//validates product upc
                {
                    if (thisProductList.checkForDuplicate(Convert.ToInt32(txtProductUPC.Text)))//checks product list for same value
                    {
                        MessageBox.Show("Match Found!");
                        btnEnterUPC.Enabled = false;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnFind.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Match Not Found");
                    }
                }
            }
        }//end of UPC enter on click method

        private void btnFind_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;//disable remaining buttons
            btnDelete.Enabled = false;

            Product p = thisProductList.getAnItem(Convert.ToInt32(txtProductUPC.Text));// product to be found

            txtProductPrice.Text = p.ProductPrice.ToString();
            txtProductUPC.Text = p.ProductUPC.ToString();
            txtProductQuantity.Text = p.ProductQuantity.ToString();
            txtProductTitle.Text = p.ProductTitle.ToString();
            if (p.GetType() == typeof(CDChamber))
            {
                FormController.activateCDChamber(this);
                FormController.deactivateAllButCDChamber(this);
                FormController.deactivateAddButtons(this);

                txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                txtCDChamberInstrumentList.Text = ((CDChamber)p).getCDChamberInstrumentList();
            }
            else if (p.GetType() == typeof(CDOrchestra))
            {
                FormController.activateCDOrchestra(this);
                FormController.deactivateAllButCDOrchestra(this);

                txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                txtCDOrchestraConductor.Text = ((CDOrchestra)p).OrchestraConductor;
            }
            else if (p.GetType() == typeof(Book))
            {
                FormController.activateBook(this);
                FormController.deactivateAllButBook(this);
                FormController.deactivateAddButtons(this);

                txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                txtBookAuthor.Text = ((Book)p).BookAuthor;
                txtBookPages.Text = ((Book)p).BookPages.ToString();
            }
            else if (p.GetType() == typeof(BookCIS))
            {
                FormController.activateBookCIS(this);
                FormController.deactivateAllButBookCIS(this);

                txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                txtBookAuthor.Text = ((Book)p).BookAuthor;
                txtBookPages.Text = (((Book)p).BookPages).ToString();
                txtBookCISCISArea.Text = ((BookCIS)p).BookCISArea;
            }  // end multiple alternative if

            else if (p.GetType() == typeof(DVD))
            {
                FormController.activateDVD(this);
                FormController.deactivateAllButDVD(this);

                txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("mm/dd/yyyy");
                txtDVDRunTime.Text = (((DVD)p).DVDRuntime).ToString();
            }
            else
            {
                MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                    "Mis-typed Object", MessageBoxButtons.OK);
                this.Close();
            }  // end multiple alternative if
            FormController.disableTextBoxes(this);//will make it just so the textboxes cannot be changed
        }//end of button find on click

        private void btnSaveEditUpdate_Click(object sender, EventArgs e)
        {
            Product p = thisProductList.getAnItem(Convert.ToInt32(txtProductUPC.Text));// product to be found
            p.Save(this);//save whatever is in textboxes to p's attributes

            thisProductList.setAnItem(p);
            MessageBox.Show("Product has been updated");
        }//end of saveEditUpdate on click method

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnDelete.Text == "Delete")
            {
                btnFind.Enabled = false;
                btnEdit.Enabled = false;

                Product p = thisProductList.getAnItem(Convert.ToInt32(txtProductUPC.Text));// product to be deleted
                txtProductPrice.Text = p.ProductPrice.ToString();
                txtProductUPC.Text = p.ProductUPC.ToString();
                txtProductQuantity.Text = p.ProductQuantity.ToString();
                txtProductTitle.Text = p.ProductTitle.ToString();
                if (p.GetType() == typeof(CDChamber))
                {
                    FormController.activateCDChamber(this);
                    FormController.deactivateAllButCDChamber(this);
                    FormController.deactivateAddButtons(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDChamberInstrumentList.Text = ((CDChamber)p).getCDChamberInstrumentList();
                }
                else if (p.GetType() == typeof(CDOrchestra))
                {
                    FormController.activateCDOrchestra(this);
                    FormController.deactivateAllButCDOrchestra(this);

                    txtCDClassicalLabel.Text = ((CDClassical)p).CDClassicalLabel;
                    txtCDClassicalArtists.Text = ((CDClassical)p).CDClassicalArtists;
                    txtCDOrchestraConductor.Text = ((CDOrchestra)p).OrchestraConductor;
                }
                else if (p.GetType() == typeof(Book))
                {
                    FormController.activateBook(this);
                    FormController.deactivateAllButBook(this);
                    FormController.deactivateAddButtons(this);

                    txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = ((Book)p).BookPages.ToString();
                }
                else if (p.GetType() == typeof(BookCIS))
                {
                    FormController.activateBookCIS(this);
                    FormController.deactivateAllButBookCIS(this);

                    txtBookISBNLeft.Text = (((Book)p).BookLeftISBN).ToString();
                    txtBookISBNRight.Text = (((Book)p).BookRightISBN).ToString();
                    txtBookAuthor.Text = ((Book)p).BookAuthor;
                    txtBookPages.Text = (((Book)p).BookPages).ToString();
                    txtBookCISCISArea.Text = ((BookCIS)p).BookCISArea;
                }  // end multiple alternative if

                else if (p.GetType() == typeof(DVD))
                {
                    FormController.activateDVD(this);
                    FormController.deactivateAllButDVD(this);

                    txtDVDLeadActor.Text = ((DVD)p).DVDLeadActor;
                    txtDVDReleaseDate.Text = ((DateTime)((DVD)p).DVDReleaseDate).ToString("mm/dd/yyyy");
                    txtDVDRunTime.Text = (((DVD)p).DVDRuntime).ToString();
                }
                else
                {
                    MessageBox.Show("Fatal error. Data type not Book, BookCIS, DVD, DC Chamber or CD Orchestra. Program Terminated. ",
                        "Mis-typed Object", MessageBoxButtons.OK);
                    this.Close();
                }  // end multiple alternative if
                FormController.disableTextBoxes(this);//make sure user cannot change info during delete
                MessageBox.Show("Are you sure you want to delete this product? Confirm delete action below.");
                btnDelete.Text = "Confirm Delete";
            }
            else//confirm
            {
                Product p = thisProductList.getAnItem(Convert.ToInt32(txtProductUPC.Text));// product to be deleted
                thisProductList.removeAnItem(p);
                btnDelete.Enabled = false;
            }
        }//end of delete click method
    }
}