﻿
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Devices = new System.Windows.Forms.Panel();
            this.listViewDevices = new System.Windows.Forms.ListView();
            this.LvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sideBarPanel.SuspendLayout();
            this.Devices.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.Controls.Add(this.DeleteButton);
            this.sideBarPanel.Controls.Add(this.textBox1);
            this.sideBarPanel.Controls.Add(this.button1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Name";
            this.listViewDevices.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewDevices.HideSelection = false;
            this.listViewDevices.Location = new System.Drawing.Point(0, 0);
            this.listViewDevices.Name = "listViewDevices";
            this.listViewDevices.Size = new System.Drawing.Size(391, 319);
            this.listViewDevices.TabIndex = 0;
            this.listViewDevices.UseCompatibleStateImageBehavior = false;
            this.listViewDevices.View = System.Windows.Forms.View.Details;
            this.listViewDevices.ItemActivate += new System.EventHandler(this.listViewDevices_ItemActivate);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.sideBarPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Uitleen applicatie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideBarPanel.ResumeLayout(false);
            this.sideBarPanel.PerformLayout();
            this.Devices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Devices;
        private System.Windows.Forms.ListView listViewDevices;
        private System.Windows.Forms.ColumnHeader LvName;
        private System.Windows.Forms.ColumnHeader LvType;
        private System.Windows.Forms.ColumnHeader LvStatus;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader ColumId;
        private System.Windows.Forms.Button DeleteButton;
    }
}

