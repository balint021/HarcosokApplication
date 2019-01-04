namespace HarcosokApplication
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
            this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
            this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.harcosokListBox = new System.Windows.Forms.ListBox();
            this.kepessegekListBox = new System.Windows.Forms.ListBox();
            this.leirasTextBox = new System.Windows.Forms.TextBox();
            this.kepessegLeirasTextBox = new System.Windows.Forms.TextBox();
            this.Nev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // harcosNeveTextBox
            // 
            this.harcosNeveTextBox.Location = new System.Drawing.Point(54, 30);
            this.harcosNeveTextBox.Name = "harcosNeveTextBox";
            this.harcosNeveTextBox.Size = new System.Drawing.Size(152, 20);
            this.harcosNeveTextBox.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(224, 30);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Letrehozas";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // hasznaloComboBox
            // 
            this.hasznaloComboBox.FormattingEnabled = true;
            this.hasznaloComboBox.Location = new System.Drawing.Point(78, 78);
            this.hasznaloComboBox.Name = "hasznaloComboBox";
            this.hasznaloComboBox.Size = new System.Drawing.Size(192, 21);
            this.hasznaloComboBox.TabIndex = 2;
            // 
            // kepessegNeveTextBox
            // 
            this.kepessegNeveTextBox.Location = new System.Drawing.Point(78, 117);
            this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
            this.kepessegNeveTextBox.Size = new System.Drawing.Size(192, 20);
            this.kepessegNeveTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 152);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Hozzaad";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // harcosokListBox
            // 
            this.harcosokListBox.FormattingEnabled = true;
            this.harcosokListBox.Location = new System.Drawing.Point(28, 197);
            this.harcosokListBox.Name = "harcosokListBox";
            this.harcosokListBox.Size = new System.Drawing.Size(120, 212);
            this.harcosokListBox.TabIndex = 5;
            this.harcosokListBox.SelectedIndexChanged += new System.EventHandler(this.harcosokListBox_SelectedIndexChanged);
            // 
            // kepessegekListBox
            // 
            this.kepessegekListBox.FormattingEnabled = true;
            this.kepessegekListBox.Location = new System.Drawing.Point(179, 197);
            this.kepessegekListBox.Name = "kepessegekListBox";
            this.kepessegekListBox.Size = new System.Drawing.Size(120, 212);
            this.kepessegekListBox.TabIndex = 6;
            this.kepessegekListBox.SelectedIndexChanged += new System.EventHandler(this.kepessegekListBox_SelectedIndexChanged);
            // 
            // leirasTextBox
            // 
            this.leirasTextBox.Location = new System.Drawing.Point(309, 85);
            this.leirasTextBox.Multiline = true;
            this.leirasTextBox.Name = "leirasTextBox";
            this.leirasTextBox.Size = new System.Drawing.Size(256, 52);
            this.leirasTextBox.TabIndex = 7;
            // 
            // kepessegLeirasTextBox
            // 
            this.kepessegLeirasTextBox.Location = new System.Drawing.Point(355, 197);
            this.kepessegLeirasTextBox.Multiline = true;
            this.kepessegLeirasTextBox.Name = "kepessegLeirasTextBox";
            this.kepessegLeirasTextBox.Size = new System.Drawing.Size(210, 68);
            this.kepessegLeirasTextBox.TabIndex = 8;
            // 
            // Nev
            // 
            this.Nev.AutoSize = true;
            this.Nev.Location = new System.Drawing.Point(16, 30);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(30, 13);
            this.Nev.TabIndex = 9;
            this.Nev.Text = "Nev:";
            this.Nev.Click += new System.EventHandler(this.Nev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hasznalo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nev:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Leiras:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(179, 435);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(91, 21);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Torles";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(475, 285);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 14;
            this.modifyButton.Text = "Modositas";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 468);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nev);
            this.Controls.Add(this.kepessegLeirasTextBox);
            this.Controls.Add(this.leirasTextBox);
            this.Controls.Add(this.kepessegekListBox);
            this.Controls.Add(this.harcosokListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.kepessegNeveTextBox);
            this.Controls.Add(this.hasznaloComboBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.harcosNeveTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox harcosNeveTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox hasznaloComboBox;
        private System.Windows.Forms.TextBox kepessegNeveTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox harcosokListBox;
        private System.Windows.Forms.ListBox kepessegekListBox;
        private System.Windows.Forms.TextBox leirasTextBox;
        private System.Windows.Forms.TextBox kepessegLeirasTextBox;
        private System.Windows.Forms.Label Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button modifyButton;
    }
}

