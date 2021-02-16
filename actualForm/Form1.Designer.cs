
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
            this.dataPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addPanel = new System.Windows.Forms.Panel();
            this.addApparaatButton = new System.Windows.Forms.Button();
            this.addUitleenButton = new System.Windows.Forms.Button();
            this.addOmschrijvingTextbox = new System.Windows.Forms.TextBox();
            this.retourPicker = new System.Windows.Forms.DateTimePicker();
            this.uitleenPicker = new System.Windows.Forms.DateTimePicker();
            this.addTypeApparaatTextbox = new System.Windows.Forms.TextBox();
            this.addApparaatNaamTextbox = new System.Windows.Forms.TextBox();
            this.addStudentnumTextbox = new System.Windows.Forms.TextBox();
            this.addNameTextbox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.addPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionButton
            // 
            this.optionButton.Location = new System.Drawing.Point(3, 30);
            this.optionButton.Name = "optionButton";
            this.optionButton.Size = new System.Drawing.Size(215, 42);
            this.optionButton.TabIndex = 0;
            this.optionButton.Text = "options";
            this.optionButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 93);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 42);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(3, 155);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(215, 42);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(3, 216);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(215, 44);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(76, 417);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(142, 22);
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
            this.panel2.Location = new System.Drawing.Point(-1, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 460);
            this.panel2.TabIndex = 6;
            // 
            // dataPanel
            // 
            this.dataPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dataPanel.Controls.Add(this.addPanel);
            this.dataPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dataPanel.Location = new System.Drawing.Point(268, 24);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(520, 414);
            this.dataPanel.TabIndex = 7;
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
            this.addPanel.Location = new System.Drawing.Point(3, 3);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(517, 411);
            this.addPanel.TabIndex = 1;
            // 
            // addApparaatButton
            // 
            this.addApparaatButton.Location = new System.Drawing.Point(294, 349);
            this.addApparaatButton.Name = "addApparaatButton";
            this.addApparaatButton.Size = new System.Drawing.Size(200, 44);
            this.addApparaatButton.TabIndex = 8;
            this.addApparaatButton.Text = "Toevoegen!";
            this.addApparaatButton.UseVisualStyleBackColor = true;
            this.addApparaatButton.Click += new System.EventHandler(this.addApparaatButton_Click);
            // 
            // addUitleenButton
            // 
            this.addUitleenButton.Location = new System.Drawing.Point(18, 349);
            this.addUitleenButton.Name = "addUitleenButton";
            this.addUitleenButton.Size = new System.Drawing.Size(200, 44);
            this.addUitleenButton.TabIndex = 7;
            this.addUitleenButton.Text = "Uitlenen!";
            this.addUitleenButton.UseVisualStyleBackColor = true;
            this.addUitleenButton.Click += new System.EventHandler(this.addUitleenButton_Click);
            // 
            // addOmschrijvingTextbox
            // 
            this.addOmschrijvingTextbox.Location = new System.Drawing.Point(366, 132);
            this.addOmschrijvingTextbox.Multiline = true;
            this.addOmschrijvingTextbox.Name = "addOmschrijvingTextbox";
            this.addOmschrijvingTextbox.Size = new System.Drawing.Size(100, 129);
            this.addOmschrijvingTextbox.TabIndex = 6;
            this.addOmschrijvingTextbox.Text = "omschrijving";
            // 
            // retourPicker
            // 
            this.retourPicker.Location = new System.Drawing.Point(18, 183);
            this.retourPicker.Name = "retourPicker";
            this.retourPicker.Size = new System.Drawing.Size(200, 22);
            this.retourPicker.TabIndex = 5;
            // 
            // uitleenPicker
            // 
            this.uitleenPicker.Location = new System.Drawing.Point(18, 122);
            this.uitleenPicker.Name = "uitleenPicker";
            this.uitleenPicker.Size = new System.Drawing.Size(200, 22);
            this.uitleenPicker.TabIndex = 4;
            // 
            // addTypeApparaatTextbox
            // 
            this.addTypeApparaatTextbox.Location = new System.Drawing.Point(366, 80);
            this.addTypeApparaatTextbox.Name = "addTypeApparaatTextbox";
            this.addTypeApparaatTextbox.Size = new System.Drawing.Size(128, 22);
            this.addTypeApparaatTextbox.TabIndex = 3;
            this.addTypeApparaatTextbox.Text = "type";
            // 
            // addApparaatNaamTextbox
            // 
            this.addApparaatNaamTextbox.Location = new System.Drawing.Point(366, 17);
            this.addApparaatNaamTextbox.Name = "addApparaatNaamTextbox";
            this.addApparaatNaamTextbox.Size = new System.Drawing.Size(128, 22);
            this.addApparaatNaamTextbox.TabIndex = 2;
            this.addApparaatNaamTextbox.Text = "name";
            // 
            // addStudentnumTextbox
            // 
            this.addStudentnumTextbox.Location = new System.Drawing.Point(18, 80);
            this.addStudentnumTextbox.Name = "addStudentnumTextbox";
            this.addStudentnumTextbox.Size = new System.Drawing.Size(156, 22);
            this.addStudentnumTextbox.TabIndex = 1;
            this.addStudentnumTextbox.Text = "student number";
            this.addStudentnumTextbox.TextChanged += new System.EventHandler(this.addStudentnumTextbox_TextChanged);
            this.addStudentnumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addStudentnumTextbox_KeyPress);
            // 
            // addNameTextbox
            // 
            this.addNameTextbox.Location = new System.Drawing.Point(18, 16);
            this.addNameTextbox.Name = "addNameTextbox";
            this.addNameTextbox.Size = new System.Drawing.Size(156, 22);
            this.addNameTextbox.TabIndex = 0;
            this.addNameTextbox.Text = "name";
            this.addNameTextbox.TextChanged += new System.EventHandler(this.addNameTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.dataPanel.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel dataPanel;
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
    }
}

