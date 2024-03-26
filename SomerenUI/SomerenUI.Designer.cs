namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip = new System.Windows.Forms.MenuStrip();
            menuItemApplication = new System.Windows.Forms.ToolStripMenuItem();
            menuItemDashboard = new System.Windows.Forms.ToolStripMenuItem();
            menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            menuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            menuItemLecturers = new System.Windows.Forms.ToolStripMenuItem();
            menuItemActivities = new System.Windows.Forms.ToolStripMenuItem();
            menuItemRooms = new System.Windows.Forms.ToolStripMenuItem();
            menuItemDrinksMenu = new System.Windows.Forms.ToolStripMenuItem();
            menuItemDrinks = new System.Windows.Forms.ToolStripMenuItem();
            menuItemDrinksSupplies = new System.Windows.Forms.ToolStripMenuItem();
            menuItemPlaceOrder = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            picBoxStudents = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            chFirstNameStudents = new System.Windows.Forms.ColumnHeader();
            chLastNameStudents = new System.Windows.Forms.ColumnHeader();
            chPhoneNumberStudents = new System.Windows.Forms.ColumnHeader();
            chStudentNumber = new System.Windows.Forms.ColumnHeader();
            chClassStudents = new System.Windows.Forms.ColumnHeader();
            lblStudents = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            lblRooms = new System.Windows.Forms.Label();
            picBoxRooms = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            chRoomNumber = new System.Windows.Forms.ColumnHeader();
            chRoomSize = new System.Windows.Forms.ColumnHeader();
            chTypeOfRoom = new System.Windows.Forms.ColumnHeader();
            pnlDrinks = new System.Windows.Forms.Panel();
            btnEditDrink = new System.Windows.Forms.Button();
            btnDeleteDrink = new System.Windows.Forms.Button();
            btnCreateDrink = new System.Windows.Forms.Button();
            lblDrinks = new System.Windows.Forms.Label();
            picBoxDrinks = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            chNameDrinks = new System.Windows.Forms.ColumnHeader();
            chPriceDrinks = new System.Windows.Forms.ColumnHeader();
            chTypeDrinks = new System.Windows.Forms.ColumnHeader();
            chStockDrinks = new System.Windows.Forms.ColumnHeader();
            chStockStatusDrinks = new System.Windows.Forms.ColumnHeader();
            pnlLecturers = new System.Windows.Forms.Panel();
            lblLecturers = new System.Windows.Forms.Label();
            picBoxLecturers = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            chFirstNameLecturers = new System.Windows.Forms.ColumnHeader();
            chLastNameLecturers = new System.Windows.Forms.ColumnHeader();
            chPhoneNumberLecturers = new System.Windows.Forms.ColumnHeader();
            chAgeLecturers = new System.Windows.Forms.ColumnHeader();
            pnlActivities = new System.Windows.Forms.Panel();
            lblActivities = new System.Windows.Forms.Label();
            picBoxActivities = new System.Windows.Forms.PictureBox();
            listViewActivities = new System.Windows.Forms.ListView();
            chActivityName = new System.Windows.Forms.ColumnHeader();
            chStartTime = new System.Windows.Forms.ColumnHeader();
            chEndTime = new System.Windows.Forms.ColumnHeader();
            pnlPlaceOrder = new System.Windows.Forms.Panel();
            lblPlaceOrder = new System.Windows.Forms.Label();
            picBoxPlaceOrder = new System.Windows.Forms.PictureBox();
            lblPlaceOrderChooseStudent = new System.Windows.Forms.Label();
            listViewPlaceOrderStudents = new System.Windows.Forms.ListView();
            chPlaceOrderFirstNameStudents = new System.Windows.Forms.ColumnHeader();
            chPlaceOrderLastNameStudents = new System.Windows.Forms.ColumnHeader();
            chPlaceOrderStudentNumber = new System.Windows.Forms.ColumnHeader();
            lblPlaceOrderChooseDrink = new System.Windows.Forms.Label();
            listViewPlaceOrderDrinks = new System.Windows.Forms.ListView();
            chPlaceOrderNameDrinks = new System.Windows.Forms.ColumnHeader();
            chPlaceOrderPriceDrinks = new System.Windows.Forms.ColumnHeader();
            chPlaceOrderStockDrinks = new System.Windows.Forms.ColumnHeader();
            chPlaceOrderTypeDrinks = new System.Windows.Forms.ColumnHeader();
            lblPlaceOrderQuantity = new System.Windows.Forms.Label();
            txtBoxPlaceOrderQuantity = new System.Windows.Forms.TextBox();
            lblPlaceOrderTotalPrice = new System.Windows.Forms.Label();
            lblPlaceOrderTotalPriceValue = new System.Windows.Forms.Label();
            btnPlaceOrder = new System.Windows.Forms.Button();
            menuStrip.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxStudents).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).BeginInit();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDrinks).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLecturers).BeginInit();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxActivities).BeginInit();
            pnlPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPlaceOrder).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemApplication, menuItemStudents, menuItemLecturers, menuItemActivities, menuItemRooms, menuItemDrinksMenu });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            menuStrip.Size = new System.Drawing.Size(1000, 35);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // menuItemApplication
            // 
            menuItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemDashboard, menuItemExit });
            menuItemApplication.Name = "menuItemApplication";
            menuItemApplication.Size = new System.Drawing.Size(80, 19);
            menuItemApplication.Text = "Application";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new System.Drawing.Size(131, 22);
            menuItemDashboard.Text = "Dashboard";
            menuItemDashboard.Click += menuItemDashboard_Click;
            // 
            // menuItemExit
            // 
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new System.Drawing.Size(131, 22);
            menuItemExit.Text = "Exit";
            menuItemExit.Click += menuItemExit_Click;
            // 
            // menuItemStudents
            // 
            menuItemStudents.Name = "menuItemStudents";
            menuItemStudents.Size = new System.Drawing.Size(65, 19);
            menuItemStudents.Text = "Students";
            menuItemStudents.Click += menuItemStudents_Click;
            // 
            // menuItemLecturers
            // 
            menuItemLecturers.Name = "menuItemLecturers";
            menuItemLecturers.Size = new System.Drawing.Size(67, 19);
            menuItemLecturers.Text = "Lecturers";
            menuItemLecturers.Click += menuItemLecturers_Click;
            // 
            // menuItemActivities
            // 
            menuItemActivities.Name = "menuItemActivities";
            menuItemActivities.Size = new System.Drawing.Size(67, 19);
            menuItemActivities.Text = "Activities";
            menuItemActivities.Click += menuItemActivities_Click;
            // 
            // menuItemRooms
            // 
            menuItemRooms.Name = "menuItemRooms";
            menuItemRooms.Size = new System.Drawing.Size(56, 19);
            menuItemRooms.Text = "Rooms";
            menuItemRooms.Click += menuItemRooms_Click;
            // 
            // menuItemDrinksMenu
            // 
            menuItemDrinksMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemDrinks, menuItemDrinksSupplies, menuItemPlaceOrder });
            menuItemDrinksMenu.Name = "menuItemDrinksMenu";
            menuItemDrinksMenu.Size = new System.Drawing.Size(52, 19);
            menuItemDrinksMenu.Text = "Drinks";
            // 
            // menuItemDrinks
            // 
            menuItemDrinks.Name = "menuItemDrinks";
            menuItemDrinks.Size = new System.Drawing.Size(154, 22);
            menuItemDrinks.Text = "Drinks";
            menuItemDrinks.Click += menuItemDrinks_Click;
            // 
            // menuItemDrinksSupplies
            // 
            menuItemDrinksSupplies.Name = "menuItemDrinksSupplies";
            menuItemDrinksSupplies.Size = new System.Drawing.Size(154, 22);
            menuItemDrinksSupplies.Text = "Drinks Supplies";
            menuItemDrinksSupplies.Click += menuItemDrinksSupplies_Click;
            // 
            // menuItemPlaceOrder
            // 
            menuItemPlaceOrder.Name = "menuItemPlaceOrder";
            menuItemPlaceOrder.Size = new System.Drawing.Size(154, 22);
            menuItemPlaceOrder.Text = "Place Order";
            menuItemPlaceOrder.Click += menuItemPlaceOrder_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(0, 35);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1000, 565);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(0, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Padding = new System.Windows.Forms.Padding(16, 16, 8, 8);
            lblDashboard.Size = new System.Drawing.Size(232, 39);
            lblDashboard.TabIndex = 2;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(picBoxStudents);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(lblStudents);
            pnlStudents.Location = new System.Drawing.Point(0, 35);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1000, 565);
            pnlStudents.TabIndex = 1;
            // 
            // picBoxStudents
            // 
            picBoxStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxStudents.Image = (System.Drawing.Image)resources.GetObject("picBoxStudents.Image");
            picBoxStudents.Location = new System.Drawing.Point(732, 56);
            picBoxStudents.Name = "picBoxStudents";
            picBoxStudents.Size = new System.Drawing.Size(127, 116);
            picBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxStudents.TabIndex = 2;
            picBoxStudents.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.AutoArrange = false;
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chFirstNameStudents, chLastNameStudents, chPhoneNumberStudents, chStudentNumber, chClassStudents });
            listViewStudents.FullRowSelect = true;
            listViewStudents.Location = new System.Drawing.Point(16, 56);
            listViewStudents.MultiSelect = false;
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(700, 300);
            listViewStudents.TabIndex = 2;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // chFirstNameStudents
            // 
            chFirstNameStudents.Text = "First Name";
            chFirstNameStudents.Width = 150;
            // 
            // chLastNameStudents
            // 
            chLastNameStudents.Text = "Last Name";
            chLastNameStudents.Width = 150;
            // 
            // chPhoneNumberStudents
            // 
            chPhoneNumberStudents.Text = "Phone Number";
            chPhoneNumberStudents.Width = 200;
            // 
            // chStudentNumber
            // 
            chStudentNumber.Text = "Student Number";
            chStudentNumber.Width = 150;
            // 
            // chClassStudents
            // 
            chClassStudents.Text = "Class";
            chClassStudents.Width = 75;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudents.Location = new System.Drawing.Point(16, 8);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new System.Drawing.Size(107, 32);
            lblStudents.TabIndex = 2;
            lblStudents.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(lblRooms);
            pnlRooms.Controls.Add(picBoxRooms);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Location = new System.Drawing.Point(0, 35);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1000, 565);
            pnlRooms.TabIndex = 1;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRooms.Location = new System.Drawing.Point(16, 8);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new System.Drawing.Size(86, 32);
            lblRooms.TabIndex = 2;
            lblRooms.Text = "Rooms";
            // 
            // picBoxRooms
            // 
            picBoxRooms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxRooms.Image = (System.Drawing.Image)resources.GetObject("picBoxRooms.Image");
            picBoxRooms.Location = new System.Drawing.Point(732, 56);
            picBoxRooms.Name = "picBoxRooms";
            picBoxRooms.Size = new System.Drawing.Size(127, 116);
            picBoxRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxRooms.TabIndex = 2;
            picBoxRooms.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.AutoArrange = false;
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chRoomNumber, chRoomSize, chTypeOfRoom });
            listViewRooms.FullRowSelect = true;
            listViewRooms.Location = new System.Drawing.Point(16, 56);
            listViewRooms.MultiSelect = false;
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(700, 300);
            listViewRooms.TabIndex = 2;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // chRoomNumber
            // 
            chRoomNumber.Text = "Room Number";
            chRoomNumber.Width = 150;
            // 
            // chRoomSize
            // 
            chRoomSize.Text = "Room Size";
            chRoomSize.Width = 150;
            // 
            // chTypeOfRoom
            // 
            chTypeOfRoom.Text = "Type Of Room";
            chTypeOfRoom.Width = 150;
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(btnEditDrink);
            pnlDrinks.Controls.Add(btnDeleteDrink);
            pnlDrinks.Controls.Add(btnCreateDrink);
            pnlDrinks.Controls.Add(lblDrinks);
            pnlDrinks.Controls.Add(picBoxDrinks);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Location = new System.Drawing.Point(0, 35);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1000, 565);
            pnlDrinks.TabIndex = 1;
            // 
            // btnEditDrink
            // 
            btnEditDrink.Location = new System.Drawing.Point(466, 380);
            btnEditDrink.Name = "btnEditDrink";
            btnEditDrink.Size = new System.Drawing.Size(120, 34);
            btnEditDrink.TabIndex = 6;
            btnEditDrink.Text = "Edit drink";
            btnEditDrink.UseVisualStyleBackColor = true;
            btnEditDrink.Click += btnEditDrink_Click;
            // 
            // btnDeleteDrink
            // 
            btnDeleteDrink.Location = new System.Drawing.Point(316, 380);
            btnDeleteDrink.Name = "btnDeleteDrink";
            btnDeleteDrink.Size = new System.Drawing.Size(120, 34);
            btnDeleteDrink.TabIndex = 5;
            btnDeleteDrink.Text = "Delete drink";
            btnDeleteDrink.UseVisualStyleBackColor = true;
            btnDeleteDrink.Click += btnDeleteDrink_Click;
            // 
            // btnCreateDrink
            // 
            btnCreateDrink.Location = new System.Drawing.Point(166, 380);
            btnCreateDrink.Name = "btnCreateDrink";
            btnCreateDrink.Size = new System.Drawing.Size(120, 34);
            btnCreateDrink.TabIndex = 4;
            btnCreateDrink.Text = "Create drink";
            btnCreateDrink.UseVisualStyleBackColor = true;
            btnCreateDrink.Click += btnCreateDrink_Click;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDrinks.Location = new System.Drawing.Point(16, 8);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new System.Drawing.Size(81, 32);
            lblDrinks.TabIndex = 2;
            lblDrinks.Text = "Drinks";
            // 
            // picBoxDrinks
            // 
            picBoxDrinks.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxDrinks.Image = (System.Drawing.Image)resources.GetObject("picBoxDrinks.Image");
            picBoxDrinks.Location = new System.Drawing.Point(732, 56);
            picBoxDrinks.Name = "picBoxDrinks";
            picBoxDrinks.Size = new System.Drawing.Size(127, 116);
            picBoxDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxDrinks.TabIndex = 2;
            picBoxDrinks.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.AutoArrange = false;
            listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chNameDrinks, chPriceDrinks, chTypeDrinks, chStockDrinks, chStockStatusDrinks });
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.Location = new System.Drawing.Point(16, 56);
            listViewDrinks.MultiSelect = false;
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(700, 300);
            listViewDrinks.TabIndex = 2;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // chNameDrinks
            // 
            chNameDrinks.Text = "Name";
            chNameDrinks.Width = 200;
            // 
            // chPriceDrinks
            // 
            chPriceDrinks.Text = "Price";
            chPriceDrinks.Width = 75;
            // 
            // chTypeDrinks
            // 
            chTypeDrinks.Text = "Alcoholic";
            chTypeDrinks.Width = 75;
            // 
            // chStockDrinks
            // 
            chStockDrinks.Text = "Stock";
            chStockDrinks.Width = 75;
            // 
            // chStockStatusDrinks
            // 
            chStockStatusDrinks.Text = "Stock Status";
            chStockStatusDrinks.Width = 200;
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(lblLecturers);
            pnlLecturers.Controls.Add(picBoxLecturers);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Location = new System.Drawing.Point(0, 35);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1000, 565);
            pnlLecturers.TabIndex = 1;
            // 
            // lblLecturers
            // 
            lblLecturers.AutoSize = true;
            lblLecturers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLecturers.Location = new System.Drawing.Point(16, 8);
            lblLecturers.Name = "lblLecturers";
            lblLecturers.Size = new System.Drawing.Size(110, 32);
            lblLecturers.TabIndex = 2;
            lblLecturers.Text = "Lecturers";
            // 
            // picBoxLecturers
            // 
            picBoxLecturers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxLecturers.Image = (System.Drawing.Image)resources.GetObject("picBoxLecturers.Image");
            picBoxLecturers.Location = new System.Drawing.Point(732, 56);
            picBoxLecturers.Name = "picBoxLecturers";
            picBoxLecturers.Size = new System.Drawing.Size(127, 116);
            picBoxLecturers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxLecturers.TabIndex = 2;
            picBoxLecturers.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.AutoArrange = false;
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chFirstNameLecturers, chLastNameLecturers, chPhoneNumberLecturers, chAgeLecturers });
            listViewLecturers.FullRowSelect = true;
            listViewLecturers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            listViewLecturers.Location = new System.Drawing.Point(16, 56);
            listViewLecturers.MultiSelect = false;
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(700, 300);
            listViewLecturers.TabIndex = 2;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = System.Windows.Forms.View.Details;
            // 
            // chFirstNameLecturers
            // 
            chFirstNameLecturers.Text = "First Name";
            chFirstNameLecturers.Width = 150;
            // 
            // chLastNameLecturers
            // 
            chLastNameLecturers.Text = "Last Name";
            chLastNameLecturers.Width = 150;
            // 
            // chPhoneNumberLecturers
            // 
            chPhoneNumberLecturers.Text = "Phone Number";
            chPhoneNumberLecturers.Width = 200;
            // 
            // chAgeLecturers
            // 
            chAgeLecturers.Text = "Age";
            chAgeLecturers.Width = 75;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(lblActivities);
            pnlActivities.Controls.Add(picBoxActivities);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Location = new System.Drawing.Point(0, 35);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1000, 565);
            pnlActivities.TabIndex = 1;
            // 
            // lblActivities
            // 
            lblActivities.AutoSize = true;
            lblActivities.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblActivities.Location = new System.Drawing.Point(16, 8);
            lblActivities.Name = "lblActivities";
            lblActivities.Size = new System.Drawing.Size(109, 32);
            lblActivities.TabIndex = 2;
            lblActivities.Text = "Activities";
            // 
            // picBoxActivities
            // 
            picBoxActivities.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxActivities.Image = (System.Drawing.Image)resources.GetObject("picBoxActivities.Image");
            picBoxActivities.Location = new System.Drawing.Point(732, 56);
            picBoxActivities.Name = "picBoxActivities";
            picBoxActivities.Size = new System.Drawing.Size(127, 116);
            picBoxActivities.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxActivities.TabIndex = 2;
            picBoxActivities.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.AutoArrange = false;
            listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chActivityName, chStartTime, chEndTime });
            listViewActivities.FullRowSelect = true;
            listViewActivities.Location = new System.Drawing.Point(16, 56);
            listViewActivities.MultiSelect = false;
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(700, 300);
            listViewActivities.TabIndex = 2;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // chActivityName
            // 
            chActivityName.Text = "Name";
            chActivityName.Width = 200;
            // 
            // chStartTime
            // 
            chStartTime.Text = "Start Time";
            chStartTime.Width = 225;
            // 
            // chEndTime
            // 
            chEndTime.Text = "End Time";
            chEndTime.Width = 225;
            // 
            // pnlPlaceOrder
            // 
            pnlPlaceOrder.Controls.Add(lblPlaceOrder);
            pnlPlaceOrder.Controls.Add(picBoxPlaceOrder);
            pnlPlaceOrder.Controls.Add(lblPlaceOrderChooseStudent);
            pnlPlaceOrder.Controls.Add(listViewPlaceOrderStudents);
            pnlPlaceOrder.Controls.Add(lblPlaceOrderChooseDrink);
            pnlPlaceOrder.Controls.Add(listViewPlaceOrderDrinks);
            pnlPlaceOrder.Controls.Add(lblPlaceOrderQuantity);
            pnlPlaceOrder.Controls.Add(txtBoxPlaceOrderQuantity);
            pnlPlaceOrder.Controls.Add(lblPlaceOrderTotalPrice);
            pnlPlaceOrder.Controls.Add(lblPlaceOrderTotalPriceValue);
            pnlPlaceOrder.Controls.Add(btnPlaceOrder);
            pnlPlaceOrder.Location = new System.Drawing.Point(0, 35);
            pnlPlaceOrder.Name = "pnlPlaceOrder";
            pnlPlaceOrder.Size = new System.Drawing.Size(980, 565);
            pnlPlaceOrder.TabIndex = 1;
            // 
            // lblPlaceOrder
            // 
            lblPlaceOrder.AutoSize = true;
            lblPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlaceOrder.Location = new System.Drawing.Point(16, 8);
            lblPlaceOrder.Name = "lblPlaceOrder";
            lblPlaceOrder.Size = new System.Drawing.Size(137, 32);
            lblPlaceOrder.TabIndex = 2;
            lblPlaceOrder.Text = "Place Order";
            // 
            // picBoxPlaceOrder
            // 
            picBoxPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxPlaceOrder.Image = (System.Drawing.Image)resources.GetObject("picBoxPlaceOrder.Image");
            picBoxPlaceOrder.Location = new System.Drawing.Point(732, 56);
            picBoxPlaceOrder.Name = "picBoxPlaceOrder";
            picBoxPlaceOrder.Size = new System.Drawing.Size(127, 116);
            picBoxPlaceOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxPlaceOrder.TabIndex = 2;
            picBoxPlaceOrder.TabStop = false;
            // 
            // lblPlaceOrderChooseStudent
            // 
            lblPlaceOrderChooseStudent.AutoSize = true;
            lblPlaceOrderChooseStudent.Location = new System.Drawing.Point(16, 52);
            lblPlaceOrderChooseStudent.Name = "lblPlaceOrderChooseStudent";
            lblPlaceOrderChooseStudent.Size = new System.Drawing.Size(93, 15);
            lblPlaceOrderChooseStudent.TabIndex = 2;
            lblPlaceOrderChooseStudent.Text = "Choose student:";
            // 
            // listViewPlaceOrderStudents
            // 
            listViewPlaceOrderStudents.AutoArrange = false;
            listViewPlaceOrderStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chPlaceOrderFirstNameStudents, chPlaceOrderLastNameStudents, chPlaceOrderStudentNumber });
            listViewPlaceOrderStudents.FullRowSelect = true;
            listViewPlaceOrderStudents.Location = new System.Drawing.Point(16, 75);
            listViewPlaceOrderStudents.MultiSelect = false;
            listViewPlaceOrderStudents.Name = "listViewPlaceOrderStudents";
            listViewPlaceOrderStudents.Size = new System.Drawing.Size(700, 200);
            listViewPlaceOrderStudents.TabIndex = 2;
            listViewPlaceOrderStudents.UseCompatibleStateImageBehavior = false;
            listViewPlaceOrderStudents.View = System.Windows.Forms.View.Details;
            // 
            // chPlaceOrderFirstNameStudents
            // 
            chPlaceOrderFirstNameStudents.Text = "First Name";
            chPlaceOrderFirstNameStudents.Width = 150;
            // 
            // chPlaceOrderLastNameStudents
            // 
            chPlaceOrderLastNameStudents.Text = "Last Name";
            chPlaceOrderLastNameStudents.Width = 150;
            // 
            // chPlaceOrderStudentNumber
            // 
            chPlaceOrderStudentNumber.Text = "Student Number";
            chPlaceOrderStudentNumber.Width = 150;
            // 
            // lblPlaceOrderChooseDrink
            // 
            lblPlaceOrderChooseDrink.AutoSize = true;
            lblPlaceOrderChooseDrink.Location = new System.Drawing.Point(16, 300);
            lblPlaceOrderChooseDrink.Name = "lblPlaceOrderChooseDrink";
            lblPlaceOrderChooseDrink.Size = new System.Drawing.Size(80, 15);
            lblPlaceOrderChooseDrink.TabIndex = 2;
            lblPlaceOrderChooseDrink.Text = "Choose drink:";
            // 
            // listViewPlaceOrderDrinks
            // 
            listViewPlaceOrderDrinks.AutoArrange = false;
            listViewPlaceOrderDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chPlaceOrderNameDrinks, chPlaceOrderPriceDrinks, chPlaceOrderStockDrinks, chPlaceOrderTypeDrinks });
            listViewPlaceOrderDrinks.FullRowSelect = true;
            listViewPlaceOrderDrinks.Location = new System.Drawing.Point(16, 323);
            listViewPlaceOrderDrinks.MultiSelect = false;
            listViewPlaceOrderDrinks.Name = "listViewPlaceOrderDrinks";
            listViewPlaceOrderDrinks.Size = new System.Drawing.Size(700, 200);
            listViewPlaceOrderDrinks.TabIndex = 2;
            listViewPlaceOrderDrinks.UseCompatibleStateImageBehavior = false;
            listViewPlaceOrderDrinks.View = System.Windows.Forms.View.Details;
            listViewPlaceOrderDrinks.ItemSelectionChanged += calculateTotalPricePlaceOrder_Event;
            // 
            // chPlaceOrderNameDrinks
            // 
            chPlaceOrderNameDrinks.Text = "Name";
            chPlaceOrderNameDrinks.Width = 200;
            // 
            // chPlaceOrderPriceDrinks
            // 
            chPlaceOrderPriceDrinks.Text = "Price";
            chPlaceOrderPriceDrinks.Width = 75;
            // 
            // chPlaceOrderStockDrinks
            // 
            chPlaceOrderStockDrinks.Text = "Stock";
            chPlaceOrderStockDrinks.Width = 75;
            // 
            // chPlaceOrderTypeDrinks
            // 
            chPlaceOrderTypeDrinks.Text = "Alcoholic";
            chPlaceOrderTypeDrinks.Width = 75;
            // 
            // lblPlaceOrderQuantity
            // 
            lblPlaceOrderQuantity.AutoSize = true;
            lblPlaceOrderQuantity.Location = new System.Drawing.Point(732, 326);
            lblPlaceOrderQuantity.Name = "lblPlaceOrderQuantity";
            lblPlaceOrderQuantity.Size = new System.Drawing.Size(56, 15);
            lblPlaceOrderQuantity.TabIndex = 1;
            lblPlaceOrderQuantity.Text = "Quantity:";
            // 
            // txtBoxPlaceOrderQuantity
            // 
            txtBoxPlaceOrderQuantity.Location = new System.Drawing.Point(810, 323);
            txtBoxPlaceOrderQuantity.Name = "txtBoxPlaceOrderQuantity";
            txtBoxPlaceOrderQuantity.Size = new System.Drawing.Size(100, 23);
            txtBoxPlaceOrderQuantity.TabIndex = 2;
            txtBoxPlaceOrderQuantity.TextChanged += calculateTotalPricePlaceOrder_Event;
            // 
            // lblPlaceOrderTotalPrice
            // 
            lblPlaceOrderTotalPrice.AutoSize = true;
            lblPlaceOrderTotalPrice.Location = new System.Drawing.Point(732, 365);
            lblPlaceOrderTotalPrice.Name = "lblPlaceOrderTotalPrice";
            lblPlaceOrderTotalPrice.Size = new System.Drawing.Size(64, 15);
            lblPlaceOrderTotalPrice.TabIndex = 4;
            lblPlaceOrderTotalPrice.Text = "Total price:";
            // 
            // lblPlaceOrderTotalPriceValue
            // 
            lblPlaceOrderTotalPriceValue.Location = new System.Drawing.Point(810, 365);
            lblPlaceOrderTotalPriceValue.Name = "lblPlaceOrderTotalPriceValue";
            lblPlaceOrderTotalPriceValue.Size = new System.Drawing.Size(70, 15);
            lblPlaceOrderTotalPriceValue.TabIndex = 5;
            lblPlaceOrderTotalPriceValue.Text = "0";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(732, 404);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(100, 30);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Add purchase";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // SomerenUI
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(menuStrip);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlPlaceOrder);
            MainMenuStrip = menuStrip;
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxStudents).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).EndInit();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDrinks).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLecturers).EndInit();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxActivities).EndInit();
            pnlPlaceOrder.ResumeLayout(false);
            pnlPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPlaceOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemApplication;
        private System.Windows.Forms.ToolStripMenuItem menuItemDashboard;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemStudents;
        private System.Windows.Forms.ToolStripMenuItem menuItemLecturers;
        private System.Windows.Forms.ToolStripMenuItem menuItemActivities;
        private System.Windows.Forms.ToolStripMenuItem menuItemRooms;
        private System.Windows.Forms.ToolStripMenuItem menuItemDrinksMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemDrinks;
        private System.Windows.Forms.ToolStripMenuItem menuItemDrinksSupplies;
        private System.Windows.Forms.ToolStripMenuItem menuItemPlaceOrder;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.PictureBox picBoxStudents;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader chFirstNameStudents;
        private System.Windows.Forms.ColumnHeader chLastNameStudents;
        private System.Windows.Forms.ColumnHeader chPhoneNumberStudents;
        private System.Windows.Forms.ColumnHeader chStudentNumber;
        private System.Windows.Forms.ColumnHeader chClassStudents;
        private System.Windows.Forms.Panel pnlLecturers;
        private System.Windows.Forms.Label lblLecturers;
        private System.Windows.Forms.PictureBox picBoxLecturers;
        private System.Windows.Forms.ListView listViewLecturers;
        private System.Windows.Forms.ColumnHeader chFirstNameLecturers;
        private System.Windows.Forms.ColumnHeader chLastNameLecturers;
        private System.Windows.Forms.ColumnHeader chPhoneNumberLecturers;
        private System.Windows.Forms.ColumnHeader chAgeLecturers;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.PictureBox picBoxRooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader chRoomNumber;
        private System.Windows.Forms.ColumnHeader chRoomSize;
        private System.Windows.Forms.ColumnHeader chTypeOfRoom;
        private System.Windows.Forms.Panel pnlActivities;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.PictureBox picBoxActivities;
        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader chActivityName;
        private System.Windows.Forms.ColumnHeader chStartTime;
        private System.Windows.Forms.ColumnHeader chEndTime;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.PictureBox picBoxDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader chNameDrinks;
        private System.Windows.Forms.ColumnHeader chPriceDrinks;
        private System.Windows.Forms.ColumnHeader chTypeDrinks;
        private System.Windows.Forms.ColumnHeader chStockDrinks;
        private System.Windows.Forms.ColumnHeader chStockStatusDrinks;
        private System.Windows.Forms.Panel pnlPlaceOrder;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Label lblPlaceOrderChooseStudent;
        private System.Windows.Forms.PictureBox picBoxPlaceOrder;
        private System.Windows.Forms.ListView listViewPlaceOrderStudents;
        private System.Windows.Forms.ColumnHeader chPlaceOrderFirstNameStudents;
        private System.Windows.Forms.ColumnHeader chPlaceOrderLastNameStudents;
        private System.Windows.Forms.ColumnHeader chPlaceOrderStudentNumber;
        private System.Windows.Forms.Label lblPlaceOrderChooseDrink;
        private System.Windows.Forms.ListView listViewPlaceOrderDrinks;
        private System.Windows.Forms.ColumnHeader chPlaceOrderNameDrinks;
        private System.Windows.Forms.ColumnHeader chPlaceOrderPriceDrinks;
        private System.Windows.Forms.ColumnHeader chPlaceOrderStockDrinks;
        private System.Windows.Forms.ColumnHeader chPlaceOrderTypeDrinks;
        private System.Windows.Forms.Label lblPlaceOrderQuantity;
        private System.Windows.Forms.TextBox txtBoxPlaceOrderQuantity;
        private System.Windows.Forms.Label lblPlaceOrderTotalPrice;
        private System.Windows.Forms.Label lblPlaceOrderTotalPriceValue;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnEditDrink;
        private System.Windows.Forms.Button btnDeleteDrink;
        private System.Windows.Forms.Button btnCreateDrink;
    }
}