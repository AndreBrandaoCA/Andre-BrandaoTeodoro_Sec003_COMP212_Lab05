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
            this.eveOddTextBox = new System.Windows.Forms.TextBox();
            this.evenOddLabel = new System.Windows.Forms.Label();
            this.displayListGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateGroupBox.SuspendLayout();
            this.checkGroupBox.SuspendLayout();
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
            this.checkGroupBox.Controls.Add(this.eveOddTextBox);
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
            // 
            // eveOddTextBox
            // 
            this.eveOddTextBox.Location = new System.Drawing.Point(98, 46);
            this.eveOddTextBox.Name = "eveOddTextBox";
            this.eveOddTextBox.Size = new System.Drawing.Size(164, 20);
            this.eveOddTextBox.TabIndex = 1;
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
            // displayListGroupBox
            // 
            this.displayListGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.displayListGroupBox.Location = new System.Drawing.Point(301, 13);
            this.displayListGroupBox.Name = "displayListGroupBox";
            this.displayListGroupBox.Size = new System.Drawing.Size(487, 291);
            this.displayListGroupBox.TabIndex = 2;
            this.displayListGroupBox.TabStop = false;
            this.displayListGroupBox.Text = "(3) Display List of Values and Search";
            // 
            // AsynchronousProgrammingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.displayListGroupBox);
            this.Controls.Add(this.checkGroupBox);
            this.Controls.Add(this.calculateGroupBox);
            this.Name = "AsynchronousProgrammingForm";
            this.Text = "Asynchronous Programming";
            this.calculateGroupBox.ResumeLayout(false);
            this.calculateGroupBox.PerformLayout();
            this.checkGroupBox.ResumeLayout(false);
            this.checkGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateGroupBox;
        private System.Windows.Forms.GroupBox checkGroupBox;
        private System.Windows.Forms.Label factorialLabel;
        private System.Windows.Forms.GroupBox displayListGroupBox;
        private System.Windows.Forms.Label factorialResultLabel;
        private System.Windows.Forms.Button calculateFactorialButton;
        private System.Windows.Forms.TextBox factorialTextBox;
        private System.Windows.Forms.Label evenOddResultLabel;
        private System.Windows.Forms.Button checkEvenOddButton;
        private System.Windows.Forms.TextBox eveOddTextBox;
        private System.Windows.Forms.Label evenOddLabel;
    }
}

