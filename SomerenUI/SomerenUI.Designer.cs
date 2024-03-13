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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lblDashboard = new System.Windows.Forms.Label();
            pnlDashboard = new System.Windows.Forms.Panel();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            pnlRooms = new System.Windows.Forms.Panel();
            picBoxRooms = new System.Windows.Forms.PictureBox();
            listViewRooms = new System.Windows.Forms.ListView();
            chRoomNumber = new System.Windows.Forms.ColumnHeader();
            chRoomSize = new System.Windows.Forms.ColumnHeader();
            chTypeOfRoom = new System.Windows.Forms.ColumnHeader();
            lblRooms = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            menuStrip1.Size = new System.Drawing.Size(1787, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 38);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 38);
            activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(106, 38);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(24, 28);
            lblDashboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(421, 32);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(22, 58);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            pnlDashboard.TabIndex = 1;
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(22, 58);
            pnlStudents.Margin = new System.Windows.Forms.Padding(6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1742, 994);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1495, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(241, 262);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.AutoArrange = false;
            listViewStudents.Location = new System.Drawing.Point(30, 90);
            listViewStudents.Margin = new System.Windows.Forms.Padding(6);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1419, 650);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 15);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 65);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(picBoxRooms);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(lblRooms);
            pnlRooms.Location = new System.Drawing.Point(22, 58);
            pnlRooms.Margin = new System.Windows.Forms.Padding(6);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1742, 994);
            pnlRooms.TabIndex = 1;
            // 
            // picBoxRooms
            // 
            picBoxRooms.Image = (System.Drawing.Image)resources.GetObject("picBoxRooms.Image");
            picBoxRooms.Location = new System.Drawing.Point(1495, 0);
            picBoxRooms.Margin = new System.Windows.Forms.Padding(6);
            picBoxRooms.Name = "picBoxRooms";
            picBoxRooms.Size = new System.Drawing.Size(241, 262);
            picBoxRooms.TabIndex = 2;
            picBoxRooms.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.AutoArrange = false;
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { chRoomNumber, chRoomSize, chTypeOfRoom });
            listViewRooms.FullRowSelect = true;
            listViewRooms.Location = new System.Drawing.Point(30, 90);
            listViewRooms.Margin = new System.Windows.Forms.Padding(6);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1419, 650);
            listViewRooms.TabIndex = 1;
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
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRooms.Location = new System.Drawing.Point(24, 15);
            lblRooms.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new System.Drawing.Size(173, 65);
            lblRooms.TabIndex = 0;
            lblRooms.Text = "Rooms";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1787, 1077);
            Controls.Add(menuStrip1);
            Controls.Add(pnlRooms);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.PictureBox picBoxRooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.ColumnHeader chRoomNumber;
        private System.Windows.Forms.ColumnHeader chRoomSize;
        private System.Windows.Forms.ColumnHeader chTypeOfRoom;
    }
}