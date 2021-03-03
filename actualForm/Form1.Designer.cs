
namespace actualForm
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.Devices = new System.Windows.Forms.Panel();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.LvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddScreenPanel = new System.Windows.Forms.Panel();
            this.AddScreenSave = new System.Windows.Forms.Button();
            this.AddScreenCancel = new System.Windows.Forms.Button();
            this.AddScreenDescription = new System.Windows.Forms.RichTextBox();
            this.AddScreenType = new System.Windows.Forms.TextBox();
            this.AddScreenName = new System.Windows.Forms.TextBox();
            this.EditScreenDevice = new System.Windows.Forms.Panel();
            this.EditScreenDeviceSaveButton = new System.Windows.Forms.Button();
            this.EditScreenDeviceDeleteButton = new System.Windows.Forms.Button();
            this.EditScreenDeviceCancelButton = new System.Windows.Forms.Button();
            this.EditScreenLendOutButton = new System.Windows.Forms.Button();
            this.EditScreenDeviceDescription = new System.Windows.Forms.RichTextBox();
            this.EditScreenDeviceType = new System.Windows.Forms.TextBox();
            this.EditScreenDeviceName = new System.Windows.Forms.TextBox();
            this.LendingScreenPanel = new System.Windows.Forms.Panel();
            this.LendingScreenSaveButton = new System.Windows.Forms.Button();
            this.LendingScreenCancelButton = new System.Windows.Forms.Button();
            this.LendingScreenClass = new System.Windows.Forms.TextBox();
            this.LendingScreenStudentNum = new System.Windows.Forms.TextBox();
            this.LendingScreenLastName = new System.Windows.Forms.TextBox();
            this.LendingScreenFirstName = new System.Windows.Forms.TextBox();
            this.ReturnScreenPanel = new System.Windows.Forms.Panel();
            this.ReturnScreenReturnButton = new System.Windows.Forms.Button();
            this.ReturnScreenCancelButton = new System.Windows.Forms.Button();
            this.ReturnScreenEditDeviceButton = new System.Windows.Forms.Button();
            this.ReturnScreenEditLendingButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorButton = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.RichTextBox();
            this.ErrorTitle = new System.Windows.Forms.TextBox();
            this.sideBarPanel.SuspendLayout();
            this.Devices.SuspendLayout();
            this.AddScreenPanel.SuspendLayout();
            this.EditScreenDevice.SuspendLayout();
            this.LendingScreenPanel.SuspendLayout();
            this.ReturnScreenPanel.SuspendLayout();
            this.ErrorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.DeleteButton);
            this.sideBarPanel.Controls.Add(this.searchBox);
            this.sideBarPanel.Controls.Add(this.addDeviceButton);
            this.sideBarPanel.Location = new System.Drawing.Point(0, -1);
            this.sideBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(217, 450);
            this.sideBarPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(19, 382);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(167, 44);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(17, 17);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(165, 61);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(17, 98);
            this.addDeviceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(168, 62);
            this.addDeviceButton.TabIndex = 0;
            this.addDeviceButton.Text = "button1";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.AddDevice);
            // 
            // Devices
            // 
            this.Devices.Controls.Add(this.listViewDevices);
            this.Devices.Location = new System.Drawing.Point(267, 44);
            this.Devices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(521, 393);
            this.Devices.TabIndex = 1;
            // 
            // listViewDevices
            // 
            this.listViewDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvName,
            this.LvType,
            this.LvStatus,
            this.Remark,
            this.ColumId});
            this.listViewDevices.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Name";
            this.listViewDevices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewDevices.HideSelection = false;
            this.listViewDevices.Location = new System.Drawing.Point(0, 0);
            this.listViewDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(520, 392);
            this.listViewDevices.TabIndex = 0;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            this.listViewDevices.Click += new System.EventHandler(this.listViewDevices_CLICK);
            // 
            // LvName
            // 
            this.LvName.Text = "Name";
            this.LvName.Width = 120;
            // 
            // LvType
            // 
            this.LvType.Text = "Type";
            this.LvType.Width = 80;
            // 
            // LvStatus
            // 
            this.LvStatus.Text = "Status";
            this.LvStatus.Width = 80;
            // 
            // Remark
            // 
            this.Remark.Text = "Remark";
            this.Remark.Width = 200;
            // 
            // ColumId
            // 
            this.ColumId.Width = 10;
            // 
            // AddScreenPanel
            // 
            this.AddScreenPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddScreenPanel.Controls.Add(this.AddScreenSave);
            this.AddScreenPanel.Controls.Add(this.AddScreenCancel);
            this.AddScreenPanel.Controls.Add(this.AddScreenDescription);
            this.AddScreenPanel.Controls.Add(this.AddScreenType);
            this.AddScreenPanel.Controls.Add(this.AddScreenName);
            this.AddScreenPanel.Location = new System.Drawing.Point(213, -1);
            this.AddScreenPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenPanel.Name = "AddScreenPanel";
            this.AddScreenPanel.Size = new System.Drawing.Size(596, 464);
            this.AddScreenPanel.TabIndex = 2;
            this.AddScreenPanel.Visible = false;
            // 
            // AddScreenSave
            // 
            this.AddScreenSave.Location = new System.Drawing.Point(340, 377);
            this.AddScreenSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenSave.Name = "AddScreenSave";
            this.AddScreenSave.Size = new System.Drawing.Size(205, 49);
            this.AddScreenSave.TabIndex = 4;
            this.AddScreenSave.Text = "Save";
            this.AddScreenSave.UseVisualStyleBackColor = true;
            this.AddScreenSave.Click += new System.EventHandler(this.AddScreenSave_Click);
            // 
            // AddScreenCancel
            // 
            this.AddScreenCancel.Location = new System.Drawing.Point(51, 382);
            this.AddScreenCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenCancel.Name = "AddScreenCancel";
            this.AddScreenCancel.Size = new System.Drawing.Size(205, 49);
            this.AddScreenCancel.TabIndex = 3;
            this.AddScreenCancel.Text = "Cancel";
            this.AddScreenCancel.UseVisualStyleBackColor = true;
            this.AddScreenCancel.Click += new System.EventHandler(this.AddScreenCancel_Click);
            // 
            // AddScreenDescription
            // 
            this.AddScreenDescription.Location = new System.Drawing.Point(51, 160);
            this.AddScreenDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenDescription.Name = "AddScreenDescription";
            this.AddScreenDescription.Size = new System.Drawing.Size(493, 141);
            this.AddScreenDescription.TabIndex = 2;
            this.AddScreenDescription.Text = "";
            // 
            // AddScreenType
            // 
            this.AddScreenType.Location = new System.Drawing.Point(340, 46);
            this.AddScreenType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenType.Multiline = true;
            this.AddScreenType.Name = "AddScreenType";
            this.AddScreenType.Size = new System.Drawing.Size(204, 66);
            this.AddScreenType.TabIndex = 1;
            // 
            // AddScreenName
            // 
            this.AddScreenName.Location = new System.Drawing.Point(51, 46);
            this.AddScreenName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddScreenName.Multiline = true;
            this.AddScreenName.Name = "AddScreenName";
            this.AddScreenName.Size = new System.Drawing.Size(204, 66);
            this.AddScreenName.TabIndex = 0;
            // 
            // EditScreenDevice
            // 
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceSaveButton);
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceDeleteButton);
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceCancelButton);
            this.EditScreenDevice.Controls.Add(this.EditScreenLendOutButton);
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceDescription);
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceType);
            this.EditScreenDevice.Controls.Add(this.EditScreenDeviceName);
            this.EditScreenDevice.Location = new System.Drawing.Point(213, -1);
            this.EditScreenDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDevice.Name = "EditScreenDevice";
            this.EditScreenDevice.Size = new System.Drawing.Size(595, 460);
            this.EditScreenDevice.TabIndex = 2;
            this.EditScreenDevice.Visible = false;
            // 
            // EditScreenDeviceSaveButton
            // 
            this.EditScreenDeviceSaveButton.Location = new System.Drawing.Point(372, 375);
            this.EditScreenDeviceSaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceSaveButton.Name = "EditScreenDeviceSaveButton";
            this.EditScreenDeviceSaveButton.Size = new System.Drawing.Size(151, 49);
            this.EditScreenDeviceSaveButton.TabIndex = 5;
            this.EditScreenDeviceSaveButton.Text = "Save";
            this.EditScreenDeviceSaveButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceSaveButton.Click += new System.EventHandler(this.EditScreenDeviceSaveButton_Click);
            // 
            // EditScreenDeviceDeleteButton
            // 
            this.EditScreenDeviceDeleteButton.Location = new System.Drawing.Point(213, 375);
            this.EditScreenDeviceDeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceDeleteButton.Name = "EditScreenDeviceDeleteButton";
            this.EditScreenDeviceDeleteButton.Size = new System.Drawing.Size(151, 49);
            this.EditScreenDeviceDeleteButton.TabIndex = 4;
            this.EditScreenDeviceDeleteButton.Text = "Delete";
            this.EditScreenDeviceDeleteButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceDeleteButton.Click += new System.EventHandler(this.EditScreenDeviceDeleteButton_Click);
            // 
            // EditScreenDeviceCancelButton
            // 
            this.EditScreenDeviceCancelButton.Location = new System.Drawing.Point(56, 375);
            this.EditScreenDeviceCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceCancelButton.Name = "EditScreenDeviceCancelButton";
            this.EditScreenDeviceCancelButton.Size = new System.Drawing.Size(151, 49);
            this.EditScreenDeviceCancelButton.TabIndex = 3;
            this.EditScreenDeviceCancelButton.Text = "Cancel";
            this.EditScreenDeviceCancelButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceCancelButton.Click += new System.EventHandler(this.EditScreenDeviceCancelButton_Click);
            // 
            // EditScreenLendOutButton
            // 
            this.EditScreenLendOutButton.Location = new System.Drawing.Point(160, 250);
            this.EditScreenLendOutButton.Name = "EditScreenLendOutButton";
            this.EditScreenLendOutButton.Size = new System.Drawing.Size(113, 40);
            this.EditScreenLendOutButton.TabIndex = 4;
            this.EditScreenLendOutButton.Text = "Lend Out!";
            this.EditScreenLendOutButton.UseVisualStyleBackColor = true;
            this.EditScreenLendOutButton.Click += new System.EventHandler(this.EditScreenDeviceLendOut_Click);
            // 
            // EditScreenDeviceDescription
            // 
            this.EditScreenDeviceDescription.Location = new System.Drawing.Point(51, 118);
            this.EditScreenDeviceDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceDescription.Name = "EditScreenDeviceDescription";
            this.EditScreenDeviceDescription.Size = new System.Drawing.Size(471, 158);
            this.EditScreenDeviceDescription.TabIndex = 2;
            this.EditScreenDeviceDescription.Text = "";
            // 
            // EditScreenDeviceType
            // 
            this.EditScreenDeviceType.Location = new System.Drawing.Point(323, 49);
            this.EditScreenDeviceType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceType.Multiline = true;
            this.EditScreenDeviceType.Name = "EditScreenDeviceType";
            this.EditScreenDeviceType.Size = new System.Drawing.Size(199, 50);
            this.EditScreenDeviceType.TabIndex = 1;
            // 
            // EditScreenDeviceName
            // 
            this.EditScreenDeviceName.Location = new System.Drawing.Point(56, 49);
            this.EditScreenDeviceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditScreenDeviceName.Multiline = true;
            this.EditScreenDeviceName.Name = "EditScreenDeviceName";
            this.EditScreenDeviceName.Size = new System.Drawing.Size(199, 50);
            this.EditScreenDeviceName.TabIndex = 0;
            // 
            // LendingScreenPanel
            // 
            this.LendingScreenPanel.Controls.Add(this.LendingScreenSaveButton);
            this.LendingScreenPanel.Controls.Add(this.LendingScreenCancelButton);
            this.LendingScreenPanel.Controls.Add(this.LendingScreenClass);
            this.LendingScreenPanel.Controls.Add(this.LendingScreenStudentNum);
            this.LendingScreenPanel.Controls.Add(this.LendingScreenLastName);
            this.LendingScreenPanel.Controls.Add(this.LendingScreenFirstName);
            this.LendingScreenPanel.Location = new System.Drawing.Point(213, -1);
            this.LendingScreenPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenPanel.Name = "LendingScreenPanel";
            this.LendingScreenPanel.Size = new System.Drawing.Size(596, 460);
            this.LendingScreenPanel.TabIndex = 6;
            this.LendingScreenPanel.Visible = false;
            // 
            // LendingScreenSaveButton
            // 
            this.LendingScreenSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenSaveButton.Location = new System.Drawing.Point(348, 375);
            this.LendingScreenSaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenSaveButton.Name = "LendingScreenSaveButton";
            this.LendingScreenSaveButton.Size = new System.Drawing.Size(175, 47);
            this.LendingScreenSaveButton.TabIndex = 5;
            this.LendingScreenSaveButton.Text = "Save";
            this.LendingScreenSaveButton.UseVisualStyleBackColor = true;
            this.LendingScreenSaveButton.Click += new System.EventHandler(this.LendingScreenSaveButton_Click);
            // 
            // LendingScreenCancelButton
            // 
            this.LendingScreenCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenCancelButton.Location = new System.Drawing.Point(57, 377);
            this.LendingScreenCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenCancelButton.Name = "LendingScreenCancelButton";
            this.LendingScreenCancelButton.Size = new System.Drawing.Size(175, 47);
            this.LendingScreenCancelButton.TabIndex = 4;
            this.LendingScreenCancelButton.Text = "Cancel";
            this.LendingScreenCancelButton.UseVisualStyleBackColor = true;
            this.LendingScreenCancelButton.Click += new System.EventHandler(this.LendingScreenCancelButton_Click);
            // 
            // LendingScreenClass
            // 
            this.LendingScreenClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenClass.Location = new System.Drawing.Point(348, 229);
            this.LendingScreenClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenClass.Name = "LendingScreenClass";
            this.LendingScreenClass.Size = new System.Drawing.Size(173, 36);
            this.LendingScreenClass.TabIndex = 3;
            this.LendingScreenClass.Text = "Klas";
            this.LendingScreenClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenStudentNum
            // 
            this.LendingScreenStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LendingScreenStudentNum.Location = new System.Drawing.Point(57, 229);
            this.LendingScreenStudentNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenStudentNum.Multiline = true;
            this.LendingScreenStudentNum.Name = "LendingScreenStudentNum";
            this.LendingScreenStudentNum.Size = new System.Drawing.Size(173, 37);
            this.LendingScreenStudentNum.TabIndex = 2;
            this.LendingScreenStudentNum.Text = "Studenten Nummer";
            this.LendingScreenStudentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenLastName
            // 
            this.LendingScreenLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenLastName.Location = new System.Drawing.Point(348, 74);
            this.LendingScreenLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenLastName.Name = "LendingScreenLastName";
            this.LendingScreenLastName.Size = new System.Drawing.Size(173, 36);
            this.LendingScreenLastName.TabIndex = 1;
            this.LendingScreenLastName.Text = "Achternaam";
            this.LendingScreenLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenFirstName
            // 
            this.LendingScreenFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenFirstName.Location = new System.Drawing.Point(57, 73);
            this.LendingScreenFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LendingScreenFirstName.Name = "LendingScreenFirstName";
            this.LendingScreenFirstName.Size = new System.Drawing.Size(173, 36);
            this.LendingScreenFirstName.TabIndex = 0;
            this.LendingScreenFirstName.Text = "Voornaam";
            this.LendingScreenFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReturnScreenPanel
            // 
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenReturnButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenCancelButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenEditDeviceButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenEditLendingButton);
            this.ReturnScreenPanel.Controls.Add(this.textBox2);
            this.ReturnScreenPanel.Location = new System.Drawing.Point(213, -1);
            this.ReturnScreenPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnScreenPanel.Name = "ReturnScreenPanel";
            this.ReturnScreenPanel.Size = new System.Drawing.Size(595, 457);
            this.ReturnScreenPanel.TabIndex = 3;
            this.ReturnScreenPanel.Visible = false;
            // 
            // ReturnScreenReturnButton
            // 
            this.ReturnScreenReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenReturnButton.Location = new System.Drawing.Point(340, 367);
            this.ReturnScreenReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnScreenReturnButton.Name = "ReturnScreenReturnButton";
            this.ReturnScreenReturnButton.Size = new System.Drawing.Size(175, 54);
            this.ReturnScreenReturnButton.TabIndex = 4;
            this.ReturnScreenReturnButton.Text = "Retourneren";
            this.ReturnScreenReturnButton.UseVisualStyleBackColor = true;
            this.ReturnScreenReturnButton.Click += new System.EventHandler(this.ReturnScreenReturnButton_Click);
            // 
            // ReturnScreenCancelButton
            // 
            this.ReturnScreenCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenCancelButton.Location = new System.Drawing.Point(81, 367);
            this.ReturnScreenCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnScreenCancelButton.Name = "ReturnScreenCancelButton";
            this.ReturnScreenCancelButton.Size = new System.Drawing.Size(175, 54);
            this.ReturnScreenCancelButton.TabIndex = 3;
            this.ReturnScreenCancelButton.Text = "Cancel";
            this.ReturnScreenCancelButton.UseVisualStyleBackColor = true;
            this.ReturnScreenCancelButton.Click += new System.EventHandler(this.ReturnScreenCancelButton_Click);
            // 
            // ReturnScreenEditDeviceButton
            // 
            this.ReturnScreenEditDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenEditDeviceButton.Location = new System.Drawing.Point(340, 244);
            this.ReturnScreenEditDeviceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnScreenEditDeviceButton.Name = "ReturnScreenEditDeviceButton";
            this.ReturnScreenEditDeviceButton.Size = new System.Drawing.Size(175, 54);
            this.ReturnScreenEditDeviceButton.TabIndex = 2;
            this.ReturnScreenEditDeviceButton.Text = "Device Bewerken";
            this.ReturnScreenEditDeviceButton.UseVisualStyleBackColor = true;
            this.ReturnScreenEditDeviceButton.Click += new System.EventHandler(this.ReturnScreenEditDeviceButton_Click);
            // 
            // ReturnScreenEditLendingButton
            // 
            this.ReturnScreenEditLendingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenEditLendingButton.Location = new System.Drawing.Point(81, 244);
            this.ReturnScreenEditLendingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnScreenEditLendingButton.Name = "ReturnScreenEditLendingButton";
            this.ReturnScreenEditLendingButton.Size = new System.Drawing.Size(175, 54);
            this.ReturnScreenEditLendingButton.TabIndex = 1;
            this.ReturnScreenEditLendingButton.Text = "Lening Bewerken";
            this.ReturnScreenEditLendingButton.UseVisualStyleBackColor = true;
            this.ReturnScreenEditLendingButton.Click += new System.EventHandler(this.ReturnScreenEditLendingButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(51, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(520, 144);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Dit apparaat is al uitgeleend!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.ErrorButton);
            this.ErrorPanel.Controls.Add(this.ErrorMessage);
            this.ErrorPanel.Controls.Add(this.ErrorTitle);
            this.ErrorPanel.Location = new System.Drawing.Point(253, 16);
            this.ErrorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(520, 428);
            this.ErrorPanel.TabIndex = 1;
            this.ErrorPanel.Visible = false;
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(123, 282);
            this.ErrorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(245, 64);
            this.ErrorButton.TabIndex = 2;
            this.ErrorButton.Text = "Change";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(43, 97);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(416, 130);
            this.ErrorMessage.TabIndex = 1;
            this.ErrorMessage.Text = "Something went wrong.";
            // 
            // ErrorTitle
            // 
            this.ErrorTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ErrorTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTitle.Location = new System.Drawing.Point(19, 23);
            this.ErrorTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorTitle.Name = "ErrorTitle";
            this.ErrorTitle.Size = new System.Drawing.Size(465, 46);
            this.ErrorTitle.TabIndex = 0;
            this.ErrorTitle.Text = "Something went wrong!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(808, 459);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.EditScreenDevice);
            this.Controls.Add(this.AddScreenPanel);
            this.Controls.Add(this.LendingScreenPanel);
            this.Controls.Add(this.ReturnScreenPanel);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Uitleen applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            this.Devices.ResumeLayout(false);
            this.AddScreenPanel.ResumeLayout(false);
            this.AddScreenPanel.PerformLayout();
            this.EditScreenDevice.ResumeLayout(false);
            this.EditScreenDevice.PerformLayout();
            this.LendingScreenPanel.ResumeLayout(false);
            this.LendingScreenPanel.PerformLayout();
            this.ReturnScreenPanel.ResumeLayout(false);
            this.ReturnScreenPanel.PerformLayout();
            this.ErrorPanel.ResumeLayout(false);
            this.ErrorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Panel Devices;
        private System.Windows.Forms.ListView listViewDevices;
        private System.Windows.Forms.ColumnHeader LvName;
        private System.Windows.Forms.ColumnHeader LvType;
        private System.Windows.Forms.ColumnHeader LvStatus;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader ColumId;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Panel AddScreenPanel;
        private System.Windows.Forms.Button AddScreenSave;
        private System.Windows.Forms.Button AddScreenCancel;
        private System.Windows.Forms.RichTextBox AddScreenDescription;
        private System.Windows.Forms.TextBox AddScreenType;
        private System.Windows.Forms.TextBox AddScreenName;
        private System.Windows.Forms.Panel EditScreenDevice;
        private System.Windows.Forms.Button EditScreenDeviceSaveButton;
        private System.Windows.Forms.Button EditScreenDeviceDeleteButton;
        private System.Windows.Forms.Button EditScreenDeviceCancelButton;
        private System.Windows.Forms.Button EditScreenLendOutButton;
        private System.Windows.Forms.RichTextBox EditScreenDeviceDescription;
        private System.Windows.Forms.TextBox EditScreenDeviceType;
        private System.Windows.Forms.TextBox EditScreenDeviceName;
        private System.Windows.Forms.Panel ReturnScreenPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ReturnScreenReturnButton;
        private System.Windows.Forms.Button ReturnScreenCancelButton;
        private System.Windows.Forms.Button ReturnScreenEditDeviceButton;
        private System.Windows.Forms.Button ReturnScreenEditLendingButton;
        private System.Windows.Forms.Panel LendingScreenPanel;
        private System.Windows.Forms.Button LendingScreenSaveButton;
        private System.Windows.Forms.Button LendingScreenCancelButton;
        private System.Windows.Forms.TextBox LendingScreenClass;
        private System.Windows.Forms.TextBox LendingScreenStudentNum;
        private System.Windows.Forms.TextBox LendingScreenLastName;
        private System.Windows.Forms.TextBox LendingScreenFirstName;
        private System.Windows.Forms.Panel ErrorPanel;
        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.RichTextBox ErrorMessage;
        private System.Windows.Forms.TextBox ErrorTitle;
    }
}

