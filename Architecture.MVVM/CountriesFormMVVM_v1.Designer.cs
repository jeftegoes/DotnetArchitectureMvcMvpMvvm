﻿namespace Architecture.MVVM
{
    partial class CountriesFormMVVM_v1
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
            getCountriesButton = new Button();
            countriesListBox = new ListBox();
            label1 = new Label();
            showV2FormButton = new Button();
            SuspendLayout();
            // 
            // getCountriesButton
            // 
            getCountriesButton.Location = new Point(58, 337);
            getCountriesButton.Name = "getCountriesButton";
            getCountriesButton.Size = new Size(75, 23);
            getCountriesButton.TabIndex = 0;
            getCountriesButton.Text = "Get Countries";
            getCountriesButton.UseVisualStyleBackColor = true;
            getCountriesButton.Click += getCountriesButton_Click;
            // 
            // countriesListBox
            // 
            countriesListBox.FormattingEnabled = true;
            countriesListBox.ItemHeight = 15;
            countriesListBox.Location = new Point(12, 27);
            countriesListBox.Name = "countriesListBox";
            countriesListBox.Size = new Size(241, 304);
            countriesListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "List of countries";
            // 
            // showV2FormButton
            // 
            showV2FormButton.Location = new Point(139, 337);
            showV2FormButton.Name = "showV2FormButton";
            showV2FormButton.Size = new Size(114, 23);
            showV2FormButton.TabIndex = 3;
            showV2FormButton.Text = "Show V2 Form";
            showV2FormButton.UseVisualStyleBackColor = true;
            showV2FormButton.Click += showV2FormButton_Click;
            // 
            // CountriesFormMVVM_v1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 379);
            Controls.Add(showV2FormButton);
            Controls.Add(label1);
            Controls.Add(countriesListBox);
            Controls.Add(getCountriesButton);
            Name = "CountriesFormMVVM_v1";
            Text = "MVVM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getCountriesButton;
        private ListBox countriesListBox;
        private Label label1;
        private Button showV2FormButton;
    }
}