
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
            this.panel2.SuspendLayout();
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
            this.dataPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.dataPanel.Location = new System.Drawing.Point(268, 24);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(520, 414);
            this.dataPanel.TabIndex = 7;
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
    }
}

