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
            menuItemDrinks = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            picBoxStudents = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            lblStudents = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            pnlDrinks = new System.Windows.Forms.Panel();
            lblDrinks = new System.Windows.Forms.Label();
            picBoxDrinks = new System.Windows.Forms.PictureBox();
            listViewDrinks = new System.Windows.Forms.ListView();
            chNameDrinks = new System.Windows.Forms.ColumnHeader();
            chPriceDrinks = new System.Windows.Forms.ColumnHeader();
            chTypeDrinks = new System.Windows.Forms.ColumnHeader();
            chStockDrinks = new System.Windows.Forms.ColumnHeader();
            chStockStatusDrinks = new System.Windows.Forms.ColumnHeader();
            lblRooms = new System.Windows.Forms.Label();
            picBoxRooms = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            chRoomNumber = new System.Windows.Forms.ColumnHeader();
            chRoomSize = new System.Windows.Forms.ColumnHeader();
            chTypeOfRoom = new System.Windows.Forms.ColumnHeader();
            pnlLecturers = new System.Windows.Forms.Panel();
            lblLecturers = new System.Windows.Forms.Label();
            picBoxLecturers = new System.Windows.Forms.PictureBox();
            listViewLecturers = new System.Windows.Forms.ListView();
            chFirstNameLecturers = new System.Windows.Forms.ColumnHeader();
            chLastNameLecturers = new System.Windows.Forms.ColumnHeader();
            chPhoneNumberLecturers = new System.Windows.Forms.ColumnHeader();
            chAgeLecturers = new System.Windows.Forms.ColumnHeader();
            menuStrip.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxStudents).BeginInit();
            pnlRooms.SuspendLayout();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDrinks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLecturers).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemApplication, menuItemStudents, menuItemLecturers, menuItemActivities, menuItemRooms, menuItemDrinks });
            menuStrip.Location = new System.Drawing.Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            menuStrip.Size = new System.Drawing.Size(1000, 45);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // menuItemApplication
            // 
            menuItemApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { menuItemDashboard, menuItemExit });
            menuItemApplication.Name = "menuItemApplication";
            menuItemApplication.Size = new System.Drawing.Size(118, 29);
            menuItemApplication.Text = "Application";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new System.Drawing.Size(202, 34);
            menuItemDashboard.Text = "Dashboard";
            menuItemDashboard.Click += dashboardToolStripMenuItem_Click;
            // 
            // menuItemExit
            // 
            menuItemExit.Name = "menuItemExit";
            menuItemExit.Size = new System.Drawing.Size(202, 34);
            menuItemExit.Text = "Exit";
            menuItemExit.Click += exitToolStripMenuItem_Click;
            // 
            // menuItemStudents
            // 
            menuItemStudents.Name = "menuItemStudents";
            menuItemStudents.Size = new System.Drawing.Size(97, 29);
            menuItemStudents.Text = "Students";
            menuItemStudents.Click += studentsToolStripMenuItem_Click;
            // 
            // menuItemLecturers
            // 
            menuItemLecturers.Name = "menuItemLecturers";
            menuItemLecturers.Size = new System.Drawing.Size(98, 29);
            menuItemLecturers.Text = "Lecturers";
            menuItemLecturers.Click += lecturersToolStripMenuItem_Click;
            // 
            // menuItemActivities
            // 
            menuItemActivities.Name = "menuItemActivities";
            menuItemActivities.Size = new System.Drawing.Size(98, 29);
            menuItemActivities.Text = "Activities";
            // 
            // menuItemRooms
            // 
            menuItemRooms.Name = "menuItemRooms";
            menuItemRooms.Size = new System.Drawing.Size(84, 29);
            menuItemRooms.Text = "Rooms";
            menuItemRooms.Click += roomsToolStripMenuItem_Click;
            // 
            // menuItemDrinks
            // 
            menuItemDrinks.Name = "menuItemDrinks";
            menuItemDrinks.Size = new System.Drawing.Size(98, 29);
            menuItemDrinks.Text = "Drinks";
            menuItemDrinks.Click += menuItemDrinks_Click;
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
            lblDashboard.Size = new System.Drawing.Size(337, 49);
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
            picBoxStudents.Image = Properties.Resources.someren;
            picBoxStudents.InitialImage = Properties.Resources.someren;
            picBoxStudents.Location = new System.Drawing.Point(732, 56);
            picBoxStudents.Name = "picBoxStudents";
            picBoxStudents.Size = new System.Drawing.Size(127, 116);
            picBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBoxStudents.TabIndex = 2;
            picBoxStudents.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(16, 56);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(700, 300);
            listViewStudents.TabIndex = 2;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // lblStudents
            // 
            lblStudents.AutoSize = true;
            lblStudents.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStudents.Location = new System.Drawing.Point(16, 8);
            lblStudents.Name = "lblStudents";
            lblStudents.Size = new System.Drawing.Size(157, 48);
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
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(lblDrinks);
            pnlDrinks.Controls.Add(picBoxDrinks);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Location = new System.Drawing.Point(0, 35);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1000, 565);
            pnlDrinks.TabIndex = 1;
            // 
            // lblDrinks
            // 
            lblDrinks.AutoSize = true;
            lblDrinks.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDrinks.Location = new System.Drawing.Point(16, 8);
            lblDrinks.Name = "lblDrinks";
            lblDrinks.Size = new System.Drawing.Size(157, 48);
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
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(700, 300);
            listViewDrinks.TabIndex = 2;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // chNameDrinks
            // 
            chNameDrinks.Text = "Name";
            chNameDrinks.Width = 150;
            // 
            // chPriceDrinks
            // 
            chPriceDrinks.Text = "Price";
            chPriceDrinks.Width = 75;
            // 
            // chTypeDrinks
            // 
            chTypeDrinks.Text = "Alcholic";
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
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRooms.Location = new System.Drawing.Point(16, 8);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new System.Drawing.Size(129, 48);
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
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(700, 300);
            listViewRooms.TabIndex = 2;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // chRoomNumber
            // 
            chRoomNumber.Text = "Room Number";
            chRoomNumber.Width = 200;
            // 
            // chRoomSize
            // 
            chRoomSize.Text = "Room Size";
            chRoomSize.Width = 200;
            // 
            // chTypeOfRoom
            // 
            chTypeOfRoom.Text = "Type Of Room";
            chTypeOfRoom.Width = 200;
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
            lblLecturers.Size = new System.Drawing.Size(165, 48);
            lblLecturers.TabIndex = 2;
            lblLecturers.Text = "Lecturers";
            // 
            // picBoxLecturers
            // 
            picBoxLecturers.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            picBoxLecturers.Image = Properties.Resources.someren;
            picBoxLecturers.InitialImage = Properties.Resources.someren;
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
            // SomerenUI
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1000, 600);
            Controls.Add(menuStrip);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlDrinks);
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
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDrinks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLecturers).EndInit();
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
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.PictureBox picBoxStudents;
        private System.Windows.Forms.ListView listViewStudents;
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
        private System.Windows.Forms.ToolStripMenuItem menuItemDrinks;
        private System.Windows.Forms.Panel pnlDrinks;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.PictureBox picBoxDrinks;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.ColumnHeader chNameDrinks;
        private System.Windows.Forms.ColumnHeader chPriceDrinks;
        private System.Windows.Forms.ColumnHeader chTypeDrinks;
        private System.Windows.Forms.ColumnHeader chStockDrinks;
        private System.Windows.Forms.ColumnHeader chStockStatusDrinks;
    }
}