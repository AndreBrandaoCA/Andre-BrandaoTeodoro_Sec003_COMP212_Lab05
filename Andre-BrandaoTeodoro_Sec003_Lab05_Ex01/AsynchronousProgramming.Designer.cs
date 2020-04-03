namespace Andre_BrandaoTeodoro_Sec003_Lab05_Ex01
{
    partial class AsynchronousProgrammingForm
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
            this.calculateGroupBox = new System.Windows.Forms.GroupBox();
            this.factorialResultLabel = new System.Windows.Forms.Label();
            this.calculateFactorialButton = new System.Windows.Forms.Button();
            this.factorialTextBox = new System.Windows.Forms.TextBox();
            this.factorialLabel = new System.Windows.Forms.Label();
            this.checkGroupBox = new System.Windows.Forms.GroupBox();
            this.evenOddResultLabel = new System.Windows.Forms.Label();
            this.checkEvenOddButton = new System.Windows.Forms.Button();
            this.evenOddTextBox = new System.Windows.Forms.TextBox();
            this.evenOddLabel = new System.Windows.Forms.Label();
            this.displayValueSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.generateValuesButton = new System.Windows.Forms.Button();
            this.OutputValueSearchTextBox = new System.Windows.Forms.TextBox();
            this.OutputValueSearchLabel = new System.Windows.Forms.Label();
            this.highIndexTextBox = new System.Windows.Forms.TextBox();
            this.highIndexLabel = new System.Windows.Forms.Label();
            this.lowIndexTextBox = new System.Windows.Forms.TextBox();
            this.lowIndexLabel = new System.Windows.Forms.Label();
            this.valueForSearchTextBox = new System.Windows.Forms.TextBox();
            this.valueForSearchLabel = new System.Windows.Forms.Label();
            this.charRadioButton = new System.Windows.Forms.RadioButton();
            this.doubleRadioButton = new System.Windows.Forms.RadioButton();
            this.integerRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateGroupBox.SuspendLayout();
            this.checkGroupBox.SuspendLayout();
            this.displayValueSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateGroupBox
            // 
            this.calculateGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.calculateGroupBox.Controls.Add(this.factorialResultLabel);
            this.calculateGroupBox.Controls.Add(this.calculateFactorialButton);
            this.calculateGroupBox.Controls.Add(this.factorialTextBox);
            this.calculateGroupBox.Controls.Add(this.factorialLabel);
            this.calculateGroupBox.Location = new System.Drawing.Point(12, 12);
            this.calculateGroupBox.Name = "calculateGroupBox";
            this.calculateGroupBox.Size = new System.Drawing.Size(282, 147);
            this.calculateGroupBox.TabIndex = 0;
            this.calculateGroupBox.TabStop = false;
            this.calculateGroupBox.Text = "(1) Calculate Asyndhronously";
            // 
            // factorialResultLabel
            // 
            this.factorialResultLabel.Location = new System.Drawing.Point(99, 83);
            this.factorialResultLabel.Name = "factorialResultLabel";
            this.factorialResultLabel.Size = new System.Drawing.Size(164, 23);
            this.factorialResultLabel.TabIndex = 3;
            // 
            // calculateFactorialButton
            // 
            this.calculateFactorialButton.Location = new System.Drawing.Point(14, 83);
            this.calculateFactorialButton.Name = "calculateFactorialButton";
            this.calculateFactorialButton.Size = new System.Drawing.Size(75, 23);
            this.calculateFactorialButton.TabIndex = 2;
            this.calculateFactorialButton.Text = "Calculate";
            this.calculateFactorialButton.UseVisualStyleBackColor = true;
            this.calculateFactorialButton.Click += new System.EventHandler(this.calculateFactorialButton_Click);
            // 
            // factorialTextBox
            // 
            this.factorialTextBox.Location = new System.Drawing.Point(99, 40);
            this.factorialTextBox.Name = "factorialTextBox";
            this.factorialTextBox.Size = new System.Drawing.Size(164, 20);
            this.factorialTextBox.TabIndex = 1;
            // 
            // factorialLabel
            // 
            this.factorialLabel.AutoSize = true;
            this.factorialLabel.Location = new System.Drawing.Point(10, 40);
            this.factorialLabel.Name = "factorialLabel";
            this.factorialLabel.Size = new System.Drawing.Size(82, 13);
            this.factorialLabel.TabIndex = 0;
            this.factorialLabel.Text = "Get Factorial of:";
            // 
            // checkGroupBox
            // 
            this.checkGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkGroupBox.Controls.Add(this.evenOddResultLabel);
            this.checkGroupBox.Controls.Add(this.checkEvenOddButton);
            this.checkGroupBox.Controls.Add(this.evenOddTextBox);
            this.checkGroupBox.Controls.Add(this.evenOddLabel);
            this.checkGroupBox.Location = new System.Drawing.Point(13, 166);
            this.checkGroupBox.Name = "checkGroupBox";
            this.checkGroupBox.Size = new System.Drawing.Size(281, 138);
            this.checkGroupBox.TabIndex = 1;
            this.checkGroupBox.TabStop = false;
            this.checkGroupBox.Text = "(2) Check for Even/Odd";
            // 
            // evenOddResultLabel
            // 
            this.evenOddResultLabel.Location = new System.Drawing.Point(154, 95);
            this.evenOddResultLabel.Name = "evenOddResultLabel";
            this.evenOddResultLabel.Size = new System.Drawing.Size(100, 23);
            this.evenOddResultLabel.TabIndex = 3;
            // 
            // checkEvenOddButton
            // 
            this.checkEvenOddButton.Location = new System.Drawing.Point(13, 95);
            this.checkEvenOddButton.Name = "checkEvenOddButton";
            this.checkEvenOddButton.Size = new System.Drawing.Size(134, 23);
            this.checkEvenOddButton.TabIndex = 2;
            this.checkEvenOddButton.Text = "Check for Even or Odd";
            this.checkEvenOddButton.UseVisualStyleBackColor = true;
            this.checkEvenOddButton.Click += new System.EventHandler(this.checkEvenOddButton_Click);
            // 
            // evenOddTextBox
            // 
            this.evenOddTextBox.Location = new System.Drawing.Point(98, 46);
            this.evenOddTextBox.Name = "evenOddTextBox";
            this.evenOddTextBox.Size = new System.Drawing.Size(164, 20);
            this.evenOddTextBox.TabIndex = 1;
            // 
            // evenOddLabel
            // 
            this.evenOddLabel.AutoSize = true;
            this.evenOddLabel.Location = new System.Drawing.Point(12, 46);
            this.evenOddLabel.Name = "evenOddLabel";
            this.evenOddLabel.Size = new System.Drawing.Size(74, 13);
            this.evenOddLabel.TabIndex = 0;
            this.evenOddLabel.Text = "Input Number:";
            // 
            // displayValueSearchGroupBox
            // 
            this.displayValueSearchGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.displayValueSearchGroupBox.Controls.Add(this.valuesListBox);
            this.displayValueSearchGroupBox.Controls.Add(this.displayButton);
            this.displayValueSearchGroupBox.Controls.Add(this.searchButton);
            this.displayValueSearchGroupBox.Controls.Add(this.generateValuesButton);
            this.displayValueSearchGroupBox.Controls.Add(this.OutputValueSearchTextBox);
            this.displayValueSearchGroupBox.Controls.Add(this.OutputValueSearchLabel);
            this.displayValueSearchGroupBox.Controls.Add(this.highIndexTextBox);
            this.displayValueSearchGroupBox.Controls.Add(this.highIndexLabel);
            this.displayValueSearchGroupBox.Controls.Add(this.lowIndexTextBox);
            this.displayValueSearchGroupBox.Controls.Add(this.lowIndexLabel);
            this.displayValueSearchGroupBox.Controls.Add(this.valueForSearchTextBox);
            this.displayValueSearchGroupBox.Controls.Add(this.valueForSearchLabel);
            this.displayValueSearchGroupBox.Controls.Add(this.charRadioButton);
            this.displayValueSearchGroupBox.Controls.Add(this.doubleRadioButton);
            this.displayValueSearchGroupBox.Controls.Add(this.integerRadioButton);
            this.displayValueSearchGroupBox.Location = new System.Drawing.Point(301, 13);
            this.displayValueSearchGroupBox.Name = "displayValueSearchGroupBox";
            this.displayValueSearchGroupBox.Size = new System.Drawing.Size(487, 291);
            this.displayValueSearchGroupBox.TabIndex = 2;
            this.displayValueSearchGroupBox.TabStop = false;
            this.displayValueSearchGroupBox.Text = "(3) Display List of Values and Search";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(17, 44);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(63, 225);
            this.valuesListBox.TabIndex = 15;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.valuesListBox_SelectedIndexChanged);
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(332, 108);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(127, 23);
            this.displayButton.TabIndex = 14;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(332, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(127, 23);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // generateValuesButton
            // 
            this.generateValuesButton.Location = new System.Drawing.Point(332, 20);
            this.generateValuesButton.Name = "generateValuesButton";
            this.generateValuesButton.Size = new System.Drawing.Size(127, 23);
            this.generateValuesButton.TabIndex = 12;
            this.generateValuesButton.Text = "Generate Values";
            this.generateValuesButton.UseVisualStyleBackColor = true;
            this.generateValuesButton.Click += new System.EventHandler(this.generateValuesButton_Click);
            // 
            // OutputValueSearchTextBox
            // 
            this.OutputValueSearchTextBox.Location = new System.Drawing.Point(99, 164);
            this.OutputValueSearchTextBox.Multiline = true;
            this.OutputValueSearchTextBox.Name = "OutputValueSearchTextBox";
            this.OutputValueSearchTextBox.Size = new System.Drawing.Size(360, 107);
            this.OutputValueSearchTextBox.TabIndex = 11;
            // 
            // OutputValueSearchLabel
            // 
            this.OutputValueSearchLabel.AutoSize = true;
            this.OutputValueSearchLabel.Location = new System.Drawing.Point(99, 147);
            this.OutputValueSearchLabel.Name = "OutputValueSearchLabel";
            this.OutputValueSearchLabel.Size = new System.Drawing.Size(201, 13);
            this.OutputValueSearchLabel.TabIndex = 10;
            this.OutputValueSearchLabel.Text = "Output of values between Low and High:";
            // 
            // highIndexTextBox
            // 
            this.highIndexTextBox.Location = new System.Drawing.Point(219, 111);
            this.highIndexTextBox.Name = "highIndexTextBox";
            this.highIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.highIndexTextBox.TabIndex = 9;
            // 
            // highIndexLabel
            // 
            this.highIndexLabel.AutoSize = true;
            this.highIndexLabel.Location = new System.Drawing.Point(99, 119);
            this.highIndexLabel.Name = "highIndexLabel";
            this.highIndexLabel.Size = new System.Drawing.Size(85, 13);
            this.highIndexLabel.TabIndex = 8;
            this.highIndexLabel.Text = "Input High Index";
            // 
            // lowIndexTextBox
            // 
            this.lowIndexTextBox.Location = new System.Drawing.Point(219, 85);
            this.lowIndexTextBox.Name = "lowIndexTextBox";
            this.lowIndexTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowIndexTextBox.TabIndex = 7;
            // 
            // lowIndexLabel
            // 
            this.lowIndexLabel.AutoSize = true;
            this.lowIndexLabel.Location = new System.Drawing.Point(99, 93);
            this.lowIndexLabel.Name = "lowIndexLabel";
            this.lowIndexLabel.Size = new System.Drawing.Size(83, 13);
            this.lowIndexLabel.TabIndex = 6;
            this.lowIndexLabel.Text = "Input Low Index";
            // 
            // valueForSearchTextBox
            // 
            this.valueForSearchTextBox.Location = new System.Drawing.Point(219, 55);
            this.valueForSearchTextBox.Name = "valueForSearchTextBox";
            this.valueForSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueForSearchTextBox.TabIndex = 5;
            // 
            // valueForSearchLabel
            // 
            this.valueForSearchLabel.AutoSize = true;
            this.valueForSearchLabel.Location = new System.Drawing.Point(99, 63);
            this.valueForSearchLabel.Name = "valueForSearchLabel";
            this.valueForSearchLabel.Size = new System.Drawing.Size(113, 13);
            this.valueForSearchLabel.TabIndex = 4;
            this.valueForSearchLabel.Text = "Input Value for Search";
            // 
            // charRadioButton
            // 
            this.charRadioButton.AutoSize = true;
            this.charRadioButton.Location = new System.Drawing.Point(170, 20);
            this.charRadioButton.Name = "charRadioButton";
            this.charRadioButton.Size = new System.Drawing.Size(47, 17);
            this.charRadioButton.TabIndex = 2;
            this.charRadioButton.TabStop = true;
            this.charRadioButton.Text = "Char";
            this.charRadioButton.UseVisualStyleBackColor = true;
            // 
            // doubleRadioButton
            // 
            this.doubleRadioButton.AutoSize = true;
            this.doubleRadioButton.Location = new System.Drawing.Point(99, 20);
            this.doubleRadioButton.Name = "doubleRadioButton";
            this.doubleRadioButton.Size = new System.Drawing.Size(64, 17);
            this.doubleRadioButton.TabIndex = 1;
            this.doubleRadioButton.TabStop = true;
            this.doubleRadioButton.Text = "Doubles";
            this.doubleRadioButton.UseVisualStyleBackColor = true;
            // 
            // integerRadioButton
            // 
            this.integerRadioButton.AutoSize = true;
            this.integerRadioButton.Location = new System.Drawing.Point(17, 20);
            this.integerRadioButton.Name = "integerRadioButton";
            this.integerRadioButton.Size = new System.Drawing.Size(63, 17);
            this.integerRadioButton.TabIndex = 0;
            this.integerRadioButton.TabStop = true;
            this.integerRadioButton.Text = "Integers";
            this.integerRadioButton.UseVisualStyleBackColor = true;
            // 
            // AsynchronousProgrammingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.displayValueSearchGroupBox);
            this.Controls.Add(this.checkGroupBox);
            this.Controls.Add(this.calculateGroupBox);
            this.Name = "AsynchronousProgrammingForm";
            this.Text = "Asynchronous Programming";
            this.calculateGroupBox.ResumeLayout(false);
            this.calculateGroupBox.PerformLayout();
            this.checkGroupBox.ResumeLayout(false);
            this.checkGroupBox.PerformLayout();
            this.displayValueSearchGroupBox.ResumeLayout(false);
            this.displayValueSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateGroupBox;
        private System.Windows.Forms.GroupBox checkGroupBox;
        private System.Windows.Forms.Label factorialLabel;
        private System.Windows.Forms.GroupBox displayValueSearchGroupBox;
        private System.Windows.Forms.Label factorialResultLabel;
        private System.Windows.Forms.Button calculateFactorialButton;
        private System.Windows.Forms.TextBox factorialTextBox;
        private System.Windows.Forms.Label evenOddResultLabel;
        private System.Windows.Forms.Button checkEvenOddButton;
        private System.Windows.Forms.TextBox evenOddTextBox;
        private System.Windows.Forms.Label evenOddLabel;
        private System.Windows.Forms.Label OutputValueSearchLabel;
        private System.Windows.Forms.TextBox highIndexTextBox;
        private System.Windows.Forms.Label highIndexLabel;
        private System.Windows.Forms.TextBox lowIndexTextBox;
        private System.Windows.Forms.Label lowIndexLabel;
        private System.Windows.Forms.TextBox valueForSearchTextBox;
        private System.Windows.Forms.Label valueForSearchLabel;
        private System.Windows.Forms.RadioButton charRadioButton;
        private System.Windows.Forms.RadioButton doubleRadioButton;
        private System.Windows.Forms.RadioButton integerRadioButton;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button generateValuesButton;
        private System.Windows.Forms.TextBox OutputValueSearchTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
    }
}

