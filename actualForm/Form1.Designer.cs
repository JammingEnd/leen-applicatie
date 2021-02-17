
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
            this.optionButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addNameTextbox = new System.Windows.Forms.TextBox();
            this.addStudentnumTextbox = new System.Windows.Forms.TextBox();
            this.addApparaatNaamTextbox = new System.Windows.Forms.TextBox();
            this.addTypeApparaatTextbox = new System.Windows.Forms.TextBox();
            this.uitleenPicker = new System.Windows.Forms.DateTimePicker();
            this.retourPicker = new System.Windows.Forms.DateTimePicker();
            this.addOmschrijvingTextbox = new System.Windows.Forms.TextBox();
            this.addUitleenButton = new System.Windows.Forms.Button();
            this.addApparaatButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(2, 24);
            this.optionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(161, 34);
            this.optionButton.TabIndex = 0;
            this.optionButton.Text = "options";
            this.optionButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 76);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 34);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(2, 126);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(161, 34);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(2, 176);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(161, 36);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(57, 339);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(108, 20);
            this.filterTextBox.TabIndex = 5;
            this.filterTextBox.Text = "search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.filterTextBox);
            this.panel2.Controls.Add(this.optionButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.removeButton);
            this.panel2.Location = new System.Drawing.Point(-1, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 374);
            this.panel2.TabIndex = 6;
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPanel.Controls.Add(this.addApparaatButton);
            this.addPanel.Controls.Add(this.addUitleenButton);
            this.addPanel.Controls.Add(this.addOmschrijvingTextbox);
            this.addPanel.Controls.Add(this.retourPicker);
            this.addPanel.Controls.Add(this.uitleenPicker);
            this.addPanel.Controls.Add(this.addTypeApparaatTextbox);
            this.addPanel.Controls.Add(this.addApparaatNaamTextbox);
            this.addPanel.Controls.Add(this.addStudentnumTextbox);
            this.addPanel.Controls.Add(this.addNameTextbox);
            this.addPanel.Location = new System.Drawing.Point(202, 19);
            this.addPanel.Margin = new System.Windows.Forms.Padding(2);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(386, 336);
            this.addPanel.TabIndex = 1;
            // 
            // addNameTextbox
            // 
            this.addNameTextbox.Location = new System.Drawing.Point(14, 13);
            this.addNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addNameTextbox.Name = "addNameTextbox";
            this.addNameTextbox.Size = new System.Drawing.Size(118, 20);
            this.addNameTextbox.TabIndex = 0;
            this.addNameTextbox.Text = "name";
            this.addNameTextbox.TextChanged += new System.EventHandler(this.addNameTextbox_TextChanged);
            // 
            // addStudentnumTextbox
            // 
            this.addStudentnumTextbox.Location = new System.Drawing.Point(14, 65);
            this.addStudentnumTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentnumTextbox.Name = "addStudentnumTextbox";
            this.addStudentnumTextbox.Size = new System.Drawing.Size(118, 20);
            this.addStudentnumTextbox.TabIndex = 1;
            this.addStudentnumTextbox.Text = "student number";
            this.addStudentnumTextbox.TextChanged += new System.EventHandler(this.addStudentnumTextbox_TextChanged);
            this.addStudentnumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addStudentnumTextbox_KeyPress);
            // 
            // addApparaatNaamTextbox
            // 
            this.addApparaatNaamTextbox.Location = new System.Drawing.Point(274, 14);
            this.addApparaatNaamTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addApparaatNaamTextbox.Name = "addApparaatNaamTextbox";
            this.addApparaatNaamTextbox.Size = new System.Drawing.Size(97, 20);
            this.addApparaatNaamTextbox.TabIndex = 2;
            this.addApparaatNaamTextbox.Text = "name";
            // 
            // addTypeApparaatTextbox
            // 
            this.addTypeApparaatTextbox.Location = new System.Drawing.Point(274, 65);
            this.addTypeApparaatTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addTypeApparaatTextbox.Name = "addTypeApparaatTextbox";
            this.addTypeApparaatTextbox.Size = new System.Drawing.Size(97, 20);
            this.addTypeApparaatTextbox.TabIndex = 3;
            this.addTypeApparaatTextbox.Text = "type";
            // 
            // uitleenPicker
            // 
            this.uitleenPicker.Location = new System.Drawing.Point(14, 99);
            this.uitleenPicker.Margin = new System.Windows.Forms.Padding(2);
            this.uitleenPicker.Name = "uitleenPicker";
            this.uitleenPicker.Size = new System.Drawing.Size(151, 20);
            this.uitleenPicker.TabIndex = 4;
            // 
            // retourPicker
            // 
            this.retourPicker.Location = new System.Drawing.Point(14, 149);
            this.retourPicker.Margin = new System.Windows.Forms.Padding(2);
            this.retourPicker.Name = "retourPicker";
            this.retourPicker.Size = new System.Drawing.Size(151, 20);
            this.retourPicker.TabIndex = 5;
            // 
            // addOmschrijvingTextbox
            // 
            this.addOmschrijvingTextbox.Location = new System.Drawing.Point(274, 101);
            this.addOmschrijvingTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.addOmschrijvingTextbox.Multiline = true;
            this.addOmschrijvingTextbox.Name = "addOmschrijvingTextbox";
            this.addOmschrijvingTextbox.Size = new System.Drawing.Size(76, 106);
            this.addOmschrijvingTextbox.TabIndex = 6;
            this.addOmschrijvingTextbox.Text = "omschrijving";
            // 
            // addUitleenButton
            // 
            this.addUitleenButton.Location = new System.Drawing.Point(14, 284);
            this.addUitleenButton.Margin = new System.Windows.Forms.Padding(2);
            this.addUitleenButton.Name = "addUitleenButton";
            this.addUitleenButton.Size = new System.Drawing.Size(150, 36);
            this.addUitleenButton.TabIndex = 7;
            this.addUitleenButton.Text = "Uitlenen!";
            this.addUitleenButton.UseVisualStyleBackColor = true;
            this.addUitleenButton.Click += new System.EventHandler(this.addUitleenButton_Click);
            // 
            // addApparaatButton
            // 
            this.addApparaatButton.Location = new System.Drawing.Point(220, 284);
            this.addApparaatButton.Margin = new System.Windows.Forms.Padding(2);
            this.addApparaatButton.Name = "addApparaatButton";
            this.addApparaatButton.Size = new System.Drawing.Size(150, 36);
            this.addApparaatButton.TabIndex = 8;
            this.addApparaatButton.Text = "Toevoegen!";
            this.addApparaatButton.UseVisualStyleBackColor = true;
            this.addApparaatButton.Click += new System.EventHandler(this.addApparaatButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(202, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 335);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button optionButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Button addApparaatButton;
        private System.Windows.Forms.Button addUitleenButton;
        private System.Windows.Forms.TextBox addOmschrijvingTextbox;
        private System.Windows.Forms.DateTimePicker retourPicker;
        private System.Windows.Forms.DateTimePicker uitleenPicker;
        private System.Windows.Forms.TextBox addTypeApparaatTextbox;
        private System.Windows.Forms.TextBox addApparaatNaamTextbox;
        private System.Windows.Forms.TextBox addStudentnumTextbox;
        private System.Windows.Forms.TextBox addNameTextbox;
        private System.Windows.Forms.ListView listView1;
    }
}

