
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.returnBescrijving = new System.Windows.Forms.RichTextBox();
            this.ReturnScreenCancelButton = new System.Windows.Forms.Button();
            this.ReturnScreenEditDeviceButton = new System.Windows.Forms.Button();
            this.ReturnScreenEditLendingButton = new System.Windows.Forms.Button();
            this.ReturnScreenText = new System.Windows.Forms.TextBox();
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
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(163, 366);
            this.sideBarPanel.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(14, 310);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 36);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(13, 14);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(125, 50);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(13, 80);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(126, 50);
            this.addDeviceButton.TabIndex = 0;
            this.addDeviceButton.Text = "button1";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.AddDevice);
            // 
            // Devices
            // 
            this.Devices.Controls.Add(this.listViewDevices);
            this.Devices.Location = new System.Drawing.Point(200, 36);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(391, 319);
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
            listViewGroup4.Header = "ListViewGroup";
            listViewGroup4.Name = "Name";
            this.listViewDevices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4});
            this.listViewDevices.HideSelection = false;
            this.listViewDevices.Location = new System.Drawing.Point(0, 0);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(391, 319);
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
            this.AddScreenPanel.Location = new System.Drawing.Point(160, -1);
            this.AddScreenPanel.Name = "AddScreenPanel";
            this.AddScreenPanel.Size = new System.Drawing.Size(447, 377);
            this.AddScreenPanel.TabIndex = 2;
            this.AddScreenPanel.Visible = false;
            // 
            // AddScreenSave
            // 
            this.AddScreenSave.Location = new System.Drawing.Point(255, 306);
            this.AddScreenSave.Name = "AddScreenSave";
            this.AddScreenSave.Size = new System.Drawing.Size(154, 40);
            this.AddScreenSave.TabIndex = 4;
            this.AddScreenSave.Text = "Save";
            this.AddScreenSave.UseVisualStyleBackColor = true;
            this.AddScreenSave.Click += new System.EventHandler(this.AddScreenSave_Click);
            // 
            // AddScreenCancel
            // 
            this.AddScreenCancel.Location = new System.Drawing.Point(38, 310);
            this.AddScreenCancel.Name = "AddScreenCancel";
            this.AddScreenCancel.Size = new System.Drawing.Size(154, 40);
            this.AddScreenCancel.TabIndex = 3;
            this.AddScreenCancel.Text = "Cancel";
            this.AddScreenCancel.UseVisualStyleBackColor = true;
            this.AddScreenCancel.Click += new System.EventHandler(this.AddScreenCancel_Click);
            // 
            // AddScreenDescription
            // 
            this.AddScreenDescription.Location = new System.Drawing.Point(38, 130);
            this.AddScreenDescription.Name = "AddScreenDescription";
            this.AddScreenDescription.Size = new System.Drawing.Size(371, 115);
            this.AddScreenDescription.TabIndex = 2;
            this.AddScreenDescription.Text = "";
            // 
            // AddScreenType
            // 
            this.AddScreenType.Location = new System.Drawing.Point(255, 37);
            this.AddScreenType.Multiline = true;
            this.AddScreenType.Name = "AddScreenType";
            this.AddScreenType.Size = new System.Drawing.Size(154, 54);
            this.AddScreenType.TabIndex = 1;
            // 
            // AddScreenName
            // 
            this.AddScreenName.Location = new System.Drawing.Point(38, 37);
            this.AddScreenName.Multiline = true;
            this.AddScreenName.Name = "AddScreenName";
            this.AddScreenName.Size = new System.Drawing.Size(154, 54);
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
            this.EditScreenDevice.Location = new System.Drawing.Point(160, -1);
            this.EditScreenDevice.Name = "EditScreenDevice";
            this.EditScreenDevice.Size = new System.Drawing.Size(446, 374);
            this.EditScreenDevice.TabIndex = 2;
            this.EditScreenDevice.Visible = false;
            // 
            // EditScreenDeviceSaveButton
            // 
            this.EditScreenDeviceSaveButton.Location = new System.Drawing.Point(279, 305);
            this.EditScreenDeviceSaveButton.Name = "EditScreenDeviceSaveButton";
            this.EditScreenDeviceSaveButton.Size = new System.Drawing.Size(113, 40);
            this.EditScreenDeviceSaveButton.TabIndex = 5;
            this.EditScreenDeviceSaveButton.Text = "Save";
            this.EditScreenDeviceSaveButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceSaveButton.Click += new System.EventHandler(this.EditScreenDeviceSaveButton_Click);
            // 
            // EditScreenDeviceDeleteButton
            // 
            this.EditScreenDeviceDeleteButton.Location = new System.Drawing.Point(160, 305);
            this.EditScreenDeviceDeleteButton.Name = "EditScreenDeviceDeleteButton";
            this.EditScreenDeviceDeleteButton.Size = new System.Drawing.Size(113, 40);
            this.EditScreenDeviceDeleteButton.TabIndex = 4;
            this.EditScreenDeviceDeleteButton.Text = "Delete";
            this.EditScreenDeviceDeleteButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceDeleteButton.Click += new System.EventHandler(this.EditScreenDeviceDeleteButton_Click);
            // 
            // EditScreenDeviceCancelButton
            // 
            this.EditScreenDeviceCancelButton.Location = new System.Drawing.Point(42, 305);
            this.EditScreenDeviceCancelButton.Name = "EditScreenDeviceCancelButton";
            this.EditScreenDeviceCancelButton.Size = new System.Drawing.Size(113, 40);
            this.EditScreenDeviceCancelButton.TabIndex = 3;
            this.EditScreenDeviceCancelButton.Text = "Cancel";
            this.EditScreenDeviceCancelButton.UseVisualStyleBackColor = true;
            this.EditScreenDeviceCancelButton.Click += new System.EventHandler(this.EditScreenDeviceCancelButton_Click);
            // 
            // EditScreenLendOutButton
            // 
            this.EditScreenLendOutButton.Location = new System.Drawing.Point(120, 203);
            this.EditScreenLendOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditScreenLendOutButton.Name = "EditScreenLendOutButton";
            this.EditScreenLendOutButton.Size = new System.Drawing.Size(85, 32);
            this.EditScreenLendOutButton.TabIndex = 4;
            this.EditScreenLendOutButton.Text = "Lend Out!";
            this.EditScreenLendOutButton.UseVisualStyleBackColor = true;
            this.EditScreenLendOutButton.Click += new System.EventHandler(this.EditScreenDeviceLendOut_Click);
            // 
            // EditScreenDeviceDescription
            // 
            this.EditScreenDeviceDescription.Location = new System.Drawing.Point(38, 96);
            this.EditScreenDeviceDescription.Name = "EditScreenDeviceDescription";
            this.EditScreenDeviceDescription.Size = new System.Drawing.Size(354, 129);
            this.EditScreenDeviceDescription.TabIndex = 2;
            this.EditScreenDeviceDescription.Text = "";
            // 
            // EditScreenDeviceType
            // 
            this.EditScreenDeviceType.Location = new System.Drawing.Point(242, 40);
            this.EditScreenDeviceType.Multiline = true;
            this.EditScreenDeviceType.Name = "EditScreenDeviceType";
            this.EditScreenDeviceType.Size = new System.Drawing.Size(150, 41);
            this.EditScreenDeviceType.TabIndex = 1;
            // 
            // EditScreenDeviceName
            // 
            this.EditScreenDeviceName.Location = new System.Drawing.Point(42, 40);
            this.EditScreenDeviceName.Multiline = true;
            this.EditScreenDeviceName.Name = "EditScreenDeviceName";
            this.EditScreenDeviceName.Size = new System.Drawing.Size(150, 41);
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
            this.LendingScreenPanel.Location = new System.Drawing.Point(160, -1);
            this.LendingScreenPanel.Name = "LendingScreenPanel";
            this.LendingScreenPanel.Size = new System.Drawing.Size(447, 374);
            this.LendingScreenPanel.TabIndex = 6;
            this.LendingScreenPanel.Visible = false;
            // 
            // LendingScreenSaveButton
            // 
            this.LendingScreenSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenSaveButton.Location = new System.Drawing.Point(261, 305);
            this.LendingScreenSaveButton.Name = "LendingScreenSaveButton";
            this.LendingScreenSaveButton.Size = new System.Drawing.Size(131, 38);
            this.LendingScreenSaveButton.TabIndex = 5;
            this.LendingScreenSaveButton.Text = "Save";
            this.LendingScreenSaveButton.UseVisualStyleBackColor = true;
            this.LendingScreenSaveButton.Click += new System.EventHandler(this.LendingScreenSaveButton_Click);
            // 
            // LendingScreenCancelButton
            // 
            this.LendingScreenCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenCancelButton.Location = new System.Drawing.Point(43, 306);
            this.LendingScreenCancelButton.Name = "LendingScreenCancelButton";
            this.LendingScreenCancelButton.Size = new System.Drawing.Size(131, 38);
            this.LendingScreenCancelButton.TabIndex = 4;
            this.LendingScreenCancelButton.Text = "Cancel";
            this.LendingScreenCancelButton.UseVisualStyleBackColor = true;
            this.LendingScreenCancelButton.Click += new System.EventHandler(this.LendingScreenCancelButton_Click);
            // 
            // LendingScreenClass
            // 
            this.LendingScreenClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenClass.Location = new System.Drawing.Point(261, 186);
            this.LendingScreenClass.Name = "LendingScreenClass";
            this.LendingScreenClass.Size = new System.Drawing.Size(131, 31);
            this.LendingScreenClass.TabIndex = 3;
            this.LendingScreenClass.Text = "Klas";
            this.LendingScreenClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenStudentNum
            // 
            this.LendingScreenStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LendingScreenStudentNum.Location = new System.Drawing.Point(43, 186);
            this.LendingScreenStudentNum.Multiline = true;
            this.LendingScreenStudentNum.Name = "LendingScreenStudentNum";
            this.LendingScreenStudentNum.Size = new System.Drawing.Size(131, 31);
            this.LendingScreenStudentNum.TabIndex = 2;
            this.LendingScreenStudentNum.Text = "Studenten Nummer";
            this.LendingScreenStudentNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenLastName
            // 
            this.LendingScreenLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenLastName.Location = new System.Drawing.Point(261, 60);
            this.LendingScreenLastName.Name = "LendingScreenLastName";
            this.LendingScreenLastName.Size = new System.Drawing.Size(131, 31);
            this.LendingScreenLastName.TabIndex = 1;
            this.LendingScreenLastName.Text = "Achternaam";
            this.LendingScreenLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LendingScreenFirstName
            // 
            this.LendingScreenFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.LendingScreenFirstName.Location = new System.Drawing.Point(43, 59);
            this.LendingScreenFirstName.Name = "LendingScreenFirstName";
            this.LendingScreenFirstName.Size = new System.Drawing.Size(131, 31);
            this.LendingScreenFirstName.TabIndex = 0;
            this.LendingScreenFirstName.Text = "Voornaam";
            this.LendingScreenFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReturnScreenPanel
            // 
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenReturnButton);
            this.ReturnScreenPanel.Controls.Add(this.returnBescrijving);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenCancelButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenEditDeviceButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenEditLendingButton);
            this.ReturnScreenPanel.Controls.Add(this.ReturnScreenText);
            this.ReturnScreenPanel.Location = new System.Drawing.Point(160, -1);
            this.ReturnScreenPanel.Name = "ReturnScreenPanel";
            this.ReturnScreenPanel.Size = new System.Drawing.Size(446, 371);
            this.ReturnScreenPanel.TabIndex = 3;
            this.ReturnScreenPanel.Visible = false;
            // 
            // ReturnScreenReturnButton
            // 
            this.ReturnScreenReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenReturnButton.Location = new System.Drawing.Point(255, 298);
            this.ReturnScreenReturnButton.Name = "ReturnScreenReturnButton";
            this.ReturnScreenReturnButton.Size = new System.Drawing.Size(131, 44);
            this.ReturnScreenReturnButton.TabIndex = 4;
            this.ReturnScreenReturnButton.Text = "Retourneren";
            this.ReturnScreenReturnButton.UseVisualStyleBackColor = true;
            this.ReturnScreenReturnButton.Click += new System.EventHandler(this.ReturnScreenReturnButton_Click);
            // 
            // returnBescrijving
            // 
            this.returnBescrijving.Location = new System.Drawing.Point(125, 140);
            this.returnBescrijving.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.returnBescrijving.Name = "returnBescrijving";
            this.returnBescrijving.Size = new System.Drawing.Size(209, 56);
            this.returnBescrijving.TabIndex = 7;
            this.returnBescrijving.Text = "Beschrijving";
            // 
            // ReturnScreenCancelButton
            // 
            this.ReturnScreenCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenCancelButton.Location = new System.Drawing.Point(61, 298);
            this.ReturnScreenCancelButton.Name = "ReturnScreenCancelButton";
            this.ReturnScreenCancelButton.Size = new System.Drawing.Size(131, 44);
            this.ReturnScreenCancelButton.TabIndex = 3;
            this.ReturnScreenCancelButton.Text = "Cancel";
            this.ReturnScreenCancelButton.UseVisualStyleBackColor = true;
            this.ReturnScreenCancelButton.Click += new System.EventHandler(this.ReturnScreenCancelButton_Click);
            // 
            // ReturnScreenEditDeviceButton
            // 
            this.ReturnScreenEditDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenEditDeviceButton.Location = new System.Drawing.Point(255, 220);
            this.ReturnScreenEditDeviceButton.Name = "ReturnScreenEditDeviceButton";
            this.ReturnScreenEditDeviceButton.Size = new System.Drawing.Size(131, 44);
            this.ReturnScreenEditDeviceButton.TabIndex = 2;
            this.ReturnScreenEditDeviceButton.Text = "Device Bewerken";
            this.ReturnScreenEditDeviceButton.UseVisualStyleBackColor = true;
            this.ReturnScreenEditDeviceButton.Click += new System.EventHandler(this.ReturnScreenEditDeviceButton_Click);
            // 
            // ReturnScreenEditLendingButton
            // 
            this.ReturnScreenEditLendingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.ReturnScreenEditLendingButton.Location = new System.Drawing.Point(61, 220);
            this.ReturnScreenEditLendingButton.Name = "ReturnScreenEditLendingButton";
            this.ReturnScreenEditLendingButton.Size = new System.Drawing.Size(131, 44);
            this.ReturnScreenEditLendingButton.TabIndex = 1;
            this.ReturnScreenEditLendingButton.Text = "Lening Bewerken";
            this.ReturnScreenEditLendingButton.UseVisualStyleBackColor = true;
            this.ReturnScreenEditLendingButton.Click += new System.EventHandler(this.ReturnScreenEditLendingButton_Click);
            // 
            // ReturnScreenText
            // 
            this.ReturnScreenText.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ReturnScreenText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnScreenText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnScreenText.Location = new System.Drawing.Point(38, 20);
            this.ReturnScreenText.Multiline = true;
            this.ReturnScreenText.Name = "ReturnScreenText";
            this.ReturnScreenText.Size = new System.Drawing.Size(390, 117);
            this.ReturnScreenText.TabIndex = 0;
            this.ReturnScreenText.Text = "Dit apparaat is al uitgeleend!";
            this.ReturnScreenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.Controls.Add(this.ErrorButton);
            this.ErrorPanel.Controls.Add(this.ErrorMessage);
            this.ErrorPanel.Controls.Add(this.ErrorTitle);
            this.ErrorPanel.Location = new System.Drawing.Point(190, 13);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(390, 348);
            this.ErrorPanel.TabIndex = 1;
            this.ErrorPanel.Visible = false;
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(92, 229);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(184, 52);
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
            this.ErrorMessage.Location = new System.Drawing.Point(32, 79);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(312, 106);
            this.ErrorMessage.TabIndex = 1;
            this.ErrorMessage.Text = "Something went wrong.";
            // 
            // ErrorTitle
            // 
            this.ErrorTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ErrorTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTitle.Location = new System.Drawing.Point(14, 19);
            this.ErrorTitle.Name = "ErrorTitle";
            this.ErrorTitle.Size = new System.Drawing.Size(349, 37);
            this.ErrorTitle.TabIndex = 0;
            this.ErrorTitle.Text = "Something went wrong!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(606, 373);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.EditScreenDevice);
            this.Controls.Add(this.AddScreenPanel);
            this.Controls.Add(this.LendingScreenPanel);
            this.Controls.Add(this.ReturnScreenPanel);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox ReturnScreenText;
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
        private System.Windows.Forms.RichTextBox returnBescrijving;
    }
}

