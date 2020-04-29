namespace BookCDDVDShop
{
    partial class frmBookCDDVDShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDataEntryandDisplay = new System.Windows.Forms.Label();
            this.lblCreateInstructions = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateCDChamber = new System.Windows.Forms.Button();
            this.btnCreateCDOrchestra = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.grpCDChamber = new System.Windows.Forms.GroupBox();
            this.txtCDChamberInstrumentList = new System.Windows.Forms.TextBox();
            this.lblCDChamberInstrumentList = new System.Windows.Forms.Label();
            this.grpCDOrchestra = new System.Windows.Forms.GroupBox();
            this.txtCDOrchestraConductor = new System.Windows.Forms.TextBox();
            this.lblCDOrchestraConductor = new System.Windows.Forms.Label();
            this.grpCDClassical = new System.Windows.Forms.GroupBox();
            this.txtCDClassicalArtists = new System.Windows.Forms.TextBox();
            this.txtCDClassicalLabel = new System.Windows.Forms.TextBox();
            this.lblCDClassicalArtists = new System.Windows.Forms.Label();
            this.lblCDClassicalLabel = new System.Windows.Forms.Label();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.txtDVDRunTime = new System.Windows.Forms.TextBox();
            this.lblDVDRunTime = new System.Windows.Forms.Label();
            this.txtDVDReleaseDate = new System.Windows.Forms.TextBox();
            this.lblDVDReleaseDate = new System.Windows.Forms.Label();
            this.txtDVDLeadActor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBookCIS = new System.Windows.Forms.GroupBox();
            this.txtBookCISCISArea = new System.Windows.Forms.TextBox();
            this.lblCISArea = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtBookPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.txtBookISBNRight = new System.Windows.Forms.TextBox();
            this.txtBookISBNLeft = new System.Windows.Forms.TextBox();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.txtProductTitle = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductUPC = new System.Windows.Forms.TextBox();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSearchEditDeleteInstructions = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDataProcessing = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveEditUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.lblDataProcessingInstructions = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnResetForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpCDChamber.SuspendLayout();
            this.grpCDOrchestra.SuspendLayout();
            this.grpCDClassical.SuspendLayout();
            this.grpDVD.SuspendLayout();
            this.grpBookCIS.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpDataProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataEntryandDisplay
            // 
            this.lblDataEntryandDisplay.AutoSize = true;
            this.lblDataEntryandDisplay.Location = new System.Drawing.Point(401, 20);
            this.lblDataEntryandDisplay.Name = "lblDataEntryandDisplay";
            this.lblDataEntryandDisplay.Size = new System.Drawing.Size(303, 17);
            this.lblDataEntryandDisplay.TabIndex = 0;
            this.lblDataEntryandDisplay.Text = "Data Entry and Display for Book CD DVD Shop";
            // 
            // lblCreateInstructions
            // 
            this.lblCreateInstructions.AutoSize = true;
            this.lblCreateInstructions.Location = new System.Drawing.Point(185, 48);
            this.lblCreateInstructions.Name = "lblCreateInstructions";
            this.lblCreateInstructions.Size = new System.Drawing.Size(730, 17);
            this.lblCreateInstructions.TabIndex = 1;
            this.lblCreateInstructions.Text = "To CREATE a new Book, CIS Book, DVD, Orchestra CD or Chamber CD, always press a b" +
    "utton below before typing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateCDChamber);
            this.groupBox1.Controls.Add(this.btnCreateCDOrchestra);
            this.groupBox1.Controls.Add(this.btnCreateDVD);
            this.groupBox1.Controls.Add(this.btnCreateBookCIS);
            this.groupBox1.Controls.Add(this.btnCreateBook);
            this.groupBox1.Location = new System.Drawing.Point(105, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 57);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls for Creating a New Entry";
            // 
            // btnCreateCDChamber
            // 
            this.btnCreateCDChamber.Location = new System.Drawing.Point(743, 21);
            this.btnCreateCDChamber.Name = "btnCreateCDChamber";
            this.btnCreateCDChamber.Size = new System.Drawing.Size(159, 23);
            this.btnCreateCDChamber.TabIndex = 4;
            this.btnCreateCDChamber.Text = "Create CD Chamber";
            this.btnCreateCDChamber.UseVisualStyleBackColor = true;
            this.btnCreateCDChamber.Click += new System.EventHandler(this.btnCreateCDChamber_Click);
            // 
            // btnCreateCDOrchestra
            // 
            this.btnCreateCDOrchestra.Location = new System.Drawing.Point(535, 21);
            this.btnCreateCDOrchestra.Name = "btnCreateCDOrchestra";
            this.btnCreateCDOrchestra.Size = new System.Drawing.Size(159, 23);
            this.btnCreateCDOrchestra.TabIndex = 3;
            this.btnCreateCDOrchestra.Text = "Create CD Orchestra";
            this.btnCreateCDOrchestra.UseVisualStyleBackColor = true;
            this.btnCreateCDOrchestra.Click += new System.EventHandler(this.btnCreateCDOrchestra_Click);
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Location = new System.Drawing.Point(366, 21);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(136, 23);
            this.btnCreateDVD.TabIndex = 4;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            this.btnCreateDVD.Click += new System.EventHandler(this.btnCreateDVD_Click);
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.Location = new System.Drawing.Point(193, 21);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(135, 23);
            this.btnCreateBookCIS.TabIndex = 3;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            this.btnCreateBookCIS.Click += new System.EventHandler(this.btnCreateBookCIS_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(29, 21);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(134, 23);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.grpCDChamber);
            this.grpProduct.Controls.Add(this.grpCDOrchestra);
            this.grpProduct.Controls.Add(this.grpCDClassical);
            this.grpProduct.Controls.Add(this.grpDVD);
            this.grpProduct.Controls.Add(this.grpBookCIS);
            this.grpProduct.Controls.Add(this.grpBook);
            this.grpProduct.Controls.Add(this.txtProductQuantity);
            this.grpProduct.Controls.Add(this.txtProductTitle);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Controls.Add(this.txtProductUPC);
            this.grpProduct.Controls.Add(this.lblUPC);
            this.grpProduct.Controls.Add(this.lblPrice);
            this.grpProduct.Controls.Add(this.lblTitle);
            this.grpProduct.Controls.Add(this.lblQuantity);
            this.grpProduct.Location = new System.Drawing.Point(105, 193);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(810, 399);
            this.grpProduct.TabIndex = 3;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // grpCDChamber
            // 
            this.grpCDChamber.Controls.Add(this.txtCDChamberInstrumentList);
            this.grpCDChamber.Controls.Add(this.lblCDChamberInstrumentList);
            this.grpCDChamber.Location = new System.Drawing.Point(431, 324);
            this.grpCDChamber.Name = "grpCDChamber";
            this.grpCDChamber.Size = new System.Drawing.Size(369, 62);
            this.grpCDChamber.TabIndex = 16;
            this.grpCDChamber.TabStop = false;
            this.grpCDChamber.Text = "CD Chamber";
            // 
            // txtCDChamberInstrumentList
            // 
            this.txtCDChamberInstrumentList.Location = new System.Drawing.Point(105, 26);
            this.txtCDChamberInstrumentList.Name = "txtCDChamberInstrumentList";
            this.txtCDChamberInstrumentList.Size = new System.Drawing.Size(228, 22);
            this.txtCDChamberInstrumentList.TabIndex = 31;
            // 
            // lblCDChamberInstrumentList
            // 
            this.lblCDChamberInstrumentList.AutoSize = true;
            this.lblCDChamberInstrumentList.Location = new System.Drawing.Point(18, 29);
            this.lblCDChamberInstrumentList.Name = "lblCDChamberInstrumentList";
            this.lblCDChamberInstrumentList.Size = new System.Drawing.Size(81, 17);
            this.lblCDChamberInstrumentList.TabIndex = 30;
            this.lblCDChamberInstrumentList.Text = "Instruments";
            // 
            // grpCDOrchestra
            // 
            this.grpCDOrchestra.Controls.Add(this.txtCDOrchestraConductor);
            this.grpCDOrchestra.Controls.Add(this.lblCDOrchestraConductor);
            this.grpCDOrchestra.Location = new System.Drawing.Point(29, 324);
            this.grpCDOrchestra.Name = "grpCDOrchestra";
            this.grpCDOrchestra.Size = new System.Drawing.Size(369, 62);
            this.grpCDOrchestra.TabIndex = 15;
            this.grpCDOrchestra.TabStop = false;
            this.grpCDOrchestra.Text = "CD Orchestra";
            // 
            // txtCDOrchestraConductor
            // 
            this.txtCDOrchestraConductor.Location = new System.Drawing.Point(99, 26);
            this.txtCDOrchestraConductor.Name = "txtCDOrchestraConductor";
            this.txtCDOrchestraConductor.Size = new System.Drawing.Size(200, 22);
            this.txtCDOrchestraConductor.TabIndex = 29;
            // 
            // lblCDOrchestraConductor
            // 
            this.lblCDOrchestraConductor.AutoSize = true;
            this.lblCDOrchestraConductor.Location = new System.Drawing.Point(16, 29);
            this.lblCDOrchestraConductor.Name = "lblCDOrchestraConductor";
            this.lblCDOrchestraConductor.Size = new System.Drawing.Size(73, 17);
            this.lblCDOrchestraConductor.TabIndex = 28;
            this.lblCDOrchestraConductor.Text = "Conductor";
            // 
            // grpCDClassical
            // 
            this.grpCDClassical.Controls.Add(this.txtCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.txtCDClassicalLabel);
            this.grpCDClassical.Controls.Add(this.lblCDClassicalArtists);
            this.grpCDClassical.Controls.Add(this.lblCDClassicalLabel);
            this.grpCDClassical.Location = new System.Drawing.Point(29, 256);
            this.grpCDClassical.Name = "grpCDClassical";
            this.grpCDClassical.Size = new System.Drawing.Size(771, 62);
            this.grpCDClassical.TabIndex = 14;
            this.grpCDClassical.TabStop = false;
            this.grpCDClassical.Text = "CD Classical";
            // 
            // txtCDClassicalArtists
            // 
            this.txtCDClassicalArtists.Location = new System.Drawing.Point(376, 26);
            this.txtCDClassicalArtists.Name = "txtCDClassicalArtists";
            this.txtCDClassicalArtists.Size = new System.Drawing.Size(359, 22);
            this.txtCDClassicalArtists.TabIndex = 27;
            // 
            // txtCDClassicalLabel
            // 
            this.txtCDClassicalLabel.Location = new System.Drawing.Point(82, 26);
            this.txtCDClassicalLabel.Name = "txtCDClassicalLabel";
            this.txtCDClassicalLabel.Size = new System.Drawing.Size(172, 22);
            this.txtCDClassicalLabel.TabIndex = 26;
            // 
            // lblCDClassicalArtists
            // 
            this.lblCDClassicalArtists.AutoSize = true;
            this.lblCDClassicalArtists.Location = new System.Drawing.Point(323, 29);
            this.lblCDClassicalArtists.Name = "lblCDClassicalArtists";
            this.lblCDClassicalArtists.Size = new System.Drawing.Size(47, 17);
            this.lblCDClassicalArtists.TabIndex = 24;
            this.lblCDClassicalArtists.Text = "Artists";
            // 
            // lblCDClassicalLabel
            // 
            this.lblCDClassicalLabel.AutoSize = true;
            this.lblCDClassicalLabel.Location = new System.Drawing.Point(16, 29);
            this.lblCDClassicalLabel.Name = "lblCDClassicalLabel";
            this.lblCDClassicalLabel.Size = new System.Drawing.Size(43, 17);
            this.lblCDClassicalLabel.TabIndex = 25;
            this.lblCDClassicalLabel.Text = "Label";
            // 
            // grpDVD
            // 
            this.grpDVD.Controls.Add(this.txtDVDRunTime);
            this.grpDVD.Controls.Add(this.lblDVDRunTime);
            this.grpDVD.Controls.Add(this.txtDVDReleaseDate);
            this.grpDVD.Controls.Add(this.lblDVDReleaseDate);
            this.grpDVD.Controls.Add(this.txtDVDLeadActor);
            this.grpDVD.Controls.Add(this.label1);
            this.grpDVD.Location = new System.Drawing.Point(29, 188);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(771, 62);
            this.grpDVD.TabIndex = 13;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "DVD";
            // 
            // txtDVDRunTime
            // 
            this.txtDVDRunTime.Location = new System.Drawing.Point(644, 25);
            this.txtDVDRunTime.Name = "txtDVDRunTime";
            this.txtDVDRunTime.Size = new System.Drawing.Size(91, 22);
            this.txtDVDRunTime.TabIndex = 23;
            // 
            // lblDVDRunTime
            // 
            this.lblDVDRunTime.AutoSize = true;
            this.lblDVDRunTime.Location = new System.Drawing.Point(557, 28);
            this.lblDVDRunTime.Name = "lblDVDRunTime";
            this.lblDVDRunTime.Size = new System.Drawing.Size(69, 17);
            this.lblDVDRunTime.TabIndex = 22;
            this.lblDVDRunTime.Text = "Run Time";
            // 
            // txtDVDReleaseDate
            // 
            this.txtDVDReleaseDate.Location = new System.Drawing.Point(423, 25);
            this.txtDVDReleaseDate.Name = "txtDVDReleaseDate";
            this.txtDVDReleaseDate.Size = new System.Drawing.Size(102, 22);
            this.txtDVDReleaseDate.TabIndex = 21;
            // 
            // lblDVDReleaseDate
            // 
            this.lblDVDReleaseDate.AutoSize = true;
            this.lblDVDReleaseDate.Location = new System.Drawing.Point(323, 28);
            this.lblDVDReleaseDate.Name = "lblDVDReleaseDate";
            this.lblDVDReleaseDate.Size = new System.Drawing.Size(94, 17);
            this.lblDVDReleaseDate.TabIndex = 20;
            this.lblDVDReleaseDate.Text = "Release Date";
            // 
            // txtDVDLeadActor
            // 
            this.txtDVDLeadActor.Location = new System.Drawing.Point(99, 25);
            this.txtDVDLeadActor.Name = "txtDVDLeadActor";
            this.txtDVDLeadActor.Size = new System.Drawing.Size(200, 22);
            this.txtDVDLeadActor.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lead Actor";
            // 
            // grpBookCIS
            // 
            this.grpBookCIS.Controls.Add(this.txtBookCISCISArea);
            this.grpBookCIS.Controls.Add(this.lblCISArea);
            this.grpBookCIS.Location = new System.Drawing.Point(29, 120);
            this.grpBookCIS.Name = "grpBookCIS";
            this.grpBookCIS.Size = new System.Drawing.Size(771, 62);
            this.grpBookCIS.TabIndex = 12;
            this.grpBookCIS.TabStop = false;
            this.grpBookCIS.Text = "CIS Book";
            // 
            // txtBookCISCISArea
            // 
            this.txtBookCISCISArea.Location = new System.Drawing.Point(87, 26);
            this.txtBookCISCISArea.Name = "txtBookCISCISArea";
            this.txtBookCISCISArea.Size = new System.Drawing.Size(282, 22);
            this.txtBookCISCISArea.TabIndex = 26;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Location = new System.Drawing.Point(16, 29);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(63, 17);
            this.lblCISArea.TabIndex = 25;
            this.lblCISArea.Text = "CIS Area";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtBookPages);
            this.grpBook.Controls.Add(this.lblPages);
            this.grpBook.Controls.Add(this.txtBookAuthor);
            this.grpBook.Controls.Add(this.lblBookAuthor);
            this.grpBook.Controls.Add(this.lblDash);
            this.grpBook.Controls.Add(this.txtBookISBNRight);
            this.grpBook.Controls.Add(this.txtBookISBNLeft);
            this.grpBook.Controls.Add(this.lblBookISBN);
            this.grpBook.Location = new System.Drawing.Point(29, 52);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(771, 62);
            this.grpBook.TabIndex = 4;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // txtBookPages
            // 
            this.txtBookPages.Location = new System.Drawing.Point(588, 28);
            this.txtBookPages.Name = "txtBookPages";
            this.txtBookPages.Size = new System.Drawing.Size(83, 22);
            this.txtBookPages.TabIndex = 24;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(524, 31);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(48, 17);
            this.lblPages.TabIndex = 23;
            this.lblPages.Text = "Pages";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(260, 28);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(233, 22);
            this.txtBookAuthor.TabIndex = 22;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(204, 31);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblBookAuthor.TabIndex = 21;
            this.lblBookAuthor.Text = "Author";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(97, 31);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(13, 17);
            this.lblDash.TabIndex = 20;
            this.lblDash.Text = "-";
            // 
            // txtBookISBNRight
            // 
            this.txtBookISBNRight.Location = new System.Drawing.Point(114, 28);
            this.txtBookISBNRight.Name = "txtBookISBNRight";
            this.txtBookISBNRight.Size = new System.Drawing.Size(41, 22);
            this.txtBookISBNRight.TabIndex = 19;
            // 
            // txtBookISBNLeft
            // 
            this.txtBookISBNLeft.Location = new System.Drawing.Point(54, 28);
            this.txtBookISBNLeft.Name = "txtBookISBNLeft";
            this.txtBookISBNLeft.Size = new System.Drawing.Size(38, 22);
            this.txtBookISBNLeft.TabIndex = 18;
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(16, 31);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(39, 17);
            this.lblBookISBN.TabIndex = 17;
            this.lblBookISBN.Text = "ISBN";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(700, 24);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtProductQuantity.TabIndex = 11;
            // 
            // txtProductTitle
            // 
            this.txtProductTitle.Location = new System.Drawing.Point(404, 24);
            this.txtProductTitle.Name = "txtProductTitle";
            this.txtProductTitle.Size = new System.Drawing.Size(218, 22);
            this.txtProductTitle.TabIndex = 10;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(236, 24);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(100, 22);
            this.txtProductPrice.TabIndex = 9;
            // 
            // txtProductUPC
            // 
            this.txtProductUPC.Location = new System.Drawing.Point(68, 24);
            this.txtProductUPC.Name = "txtProductUPC";
            this.txtProductUPC.Size = new System.Drawing.Size(100, 22);
            this.txtProductUPC.TabIndex = 8;
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(26, 27);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(36, 17);
            this.lblUPC.TabIndex = 4;
            this.lblUPC.Text = "UPC";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(190, 27);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(363, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(633, 27);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSearchEditDeleteInstructions
            // 
            this.lblSearchEditDeleteInstructions.AutoSize = true;
            this.lblSearchEditDeleteInstructions.Location = new System.Drawing.Point(185, 163);
            this.lblSearchEditDeleteInstructions.Name = "lblSearchEditDeleteInstructions";
            this.lblSearchEditDeleteInstructions.Size = new System.Drawing.Size(730, 17);
            this.lblSearchEditDeleteInstructions.TabIndex = 0;
            this.lblSearchEditDeleteInstructions.Text = "To Find/SEARCH, Edit/UPDATE or DELETE, enter Product UPC and Select appropriate c" +
    "ontrol at bottomm of form.";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(951, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDataProcessing
            // 
            this.grpDataProcessing.Controls.Add(this.btnDelete);
            this.grpDataProcessing.Controls.Add(this.btnSaveEditUpdate);
            this.grpDataProcessing.Controls.Add(this.btnEdit);
            this.grpDataProcessing.Controls.Add(this.btnFind);
            this.grpDataProcessing.Controls.Add(this.btnEnterUPC);
            this.grpDataProcessing.Controls.Add(this.lblDataProcessingInstructions);
            this.grpDataProcessing.Location = new System.Drawing.Point(105, 608);
            this.grpDataProcessing.Name = "grpDataProcessing";
            this.grpDataProcessing.Size = new System.Drawing.Size(810, 115);
            this.grpDataProcessing.TabIndex = 34;
            this.grpDataProcessing.TabStop = false;
            this.grpDataProcessing.Text = "Form Controls for Data Processing";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(649, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveEditUpdate
            // 
            this.btnSaveEditUpdate.Location = new System.Drawing.Point(507, 77);
            this.btnSaveEditUpdate.Name = "btnSaveEditUpdate";
            this.btnSaveEditUpdate.Size = new System.Drawing.Size(115, 23);
            this.btnSaveEditUpdate.TabIndex = 4;
            this.btnSaveEditUpdate.Text = "Save Updates";
            this.btnSaveEditUpdate.UseVisualStyleBackColor = true;
            this.btnSaveEditUpdate.Click += new System.EventHandler(this.btnSaveEditUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(366, 77);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit/Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(236, 77);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(115, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.Location = new System.Drawing.Point(13, 77);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(201, 23);
            this.btnEnterUPC.TabIndex = 1;
            this.btnEnterUPC.Text = "Click HERE to enter a UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = true;
            this.btnEnterUPC.Click += new System.EventHandler(this.btnEnterUPC_Click);
            // 
            // lblDataProcessingInstructions
            // 
            this.lblDataProcessingInstructions.AutoSize = true;
            this.lblDataProcessingInstructions.Location = new System.Drawing.Point(26, 28);
            this.lblDataProcessingInstructions.Name = "lblDataProcessingInstructions";
            this.lblDataProcessingInstructions.Size = new System.Drawing.Size(585, 34);
            this.lblDataProcessingInstructions.TabIndex = 0;
            this.lblDataProcessingInstructions.Text = "These operations require entry of a Product UPC (see above) before they can be ex" +
    "ecuted.\r\nPress CLEAR FORM when operation is complete.";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(951, 259);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(100, 50);
            this.btnResetForm.TabIndex = 35;
            this.btnResetForm.Text = "Clear Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // frmBookCDDVDShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 753);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.grpDataProcessing);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSearchEditDeleteInstructions);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCreateInstructions);
            this.Controls.Add(this.lblDataEntryandDisplay);
            this.Name = "frmBookCDDVDShop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBookCDDVDShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpCDChamber.ResumeLayout(false);
            this.grpCDChamber.PerformLayout();
            this.grpCDOrchestra.ResumeLayout(false);
            this.grpCDOrchestra.PerformLayout();
            this.grpCDClassical.ResumeLayout(false);
            this.grpCDClassical.PerformLayout();
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.grpBookCIS.ResumeLayout(false);
            this.grpBookCIS.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpDataProcessing.ResumeLayout(false);
            this.grpDataProcessing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblDataEntryandDisplay;
        internal System.Windows.Forms.Label lblCreateInstructions;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnCreateCDChamber;
        internal System.Windows.Forms.Button btnCreateCDOrchestra;
        internal System.Windows.Forms.Button btnCreateDVD;
        internal System.Windows.Forms.Button btnCreateBookCIS;
        internal System.Windows.Forms.Button btnCreateBook;
        internal System.Windows.Forms.GroupBox grpProduct;
        internal System.Windows.Forms.TextBox txtProductQuantity;
        internal System.Windows.Forms.TextBox txtProductTitle;
        internal System.Windows.Forms.TextBox txtProductPrice;
        internal System.Windows.Forms.TextBox txtProductUPC;
        internal System.Windows.Forms.Label lblUPC;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.Label lblSearchEditDeleteInstructions;
        internal System.Windows.Forms.GroupBox grpCDChamber;
        internal System.Windows.Forms.TextBox txtCDChamberInstrumentList;
        internal System.Windows.Forms.Label lblCDChamberInstrumentList;
        internal System.Windows.Forms.GroupBox grpCDOrchestra;
        internal System.Windows.Forms.TextBox txtCDOrchestraConductor;
        internal System.Windows.Forms.Label lblCDOrchestraConductor;
        internal System.Windows.Forms.GroupBox grpCDClassical;
        internal System.Windows.Forms.TextBox txtCDClassicalArtists;
        internal System.Windows.Forms.TextBox txtCDClassicalLabel;
        internal System.Windows.Forms.Label lblCDClassicalArtists;
        internal System.Windows.Forms.Label lblCDClassicalLabel;
        internal System.Windows.Forms.GroupBox grpDVD;
        internal System.Windows.Forms.TextBox txtDVDRunTime;
        internal System.Windows.Forms.Label lblDVDRunTime;
        internal System.Windows.Forms.TextBox txtDVDReleaseDate;
        internal System.Windows.Forms.Label lblDVDReleaseDate;
        internal System.Windows.Forms.TextBox txtDVDLeadActor;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox grpBookCIS;
        internal System.Windows.Forms.TextBox txtBookCISCISArea;
        internal System.Windows.Forms.Label lblCISArea;
        internal System.Windows.Forms.GroupBox grpBook;
        internal System.Windows.Forms.TextBox txtBookPages;
        internal System.Windows.Forms.Label lblPages;
        internal System.Windows.Forms.TextBox txtBookAuthor;
        internal System.Windows.Forms.Label lblBookAuthor;
        internal System.Windows.Forms.Label lblDash;
        internal System.Windows.Forms.TextBox txtBookISBNRight;
        internal System.Windows.Forms.TextBox txtBookISBNLeft;
        internal System.Windows.Forms.Label lblBookISBN;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.GroupBox grpDataProcessing;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSaveEditUpdate;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Button btnEnterUPC;
        internal System.Windows.Forms.Label lblDataProcessingInstructions;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnResetForm;
    }
}

