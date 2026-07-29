namespace ClientValidations
{
    partial class Form1
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
            label1 = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            accountBalanceText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            createButton = new Button();
            errosListBox = new ListBox();
            label5 = new Label();
            dateOfBirthPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // firstNameText
            // 
            firstNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameText.Location = new Point(137, 12);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(293, 29);
            firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameText.Location = new Point(137, 47);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(293, 29);
            lastNameText.TabIndex = 2;
            // 
            // accountBalanceText
            // 
            accountBalanceText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountBalanceText.Location = new Point(137, 82);
            accountBalanceText.Name = "accountBalanceText";
            accountBalanceText.Size = new Size(122, 29);
            accountBalanceText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 50);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 85);
            label3.Name = "label3";
            label3.Size = new Size(123, 21);
            label3.TabIndex = 7;
            label3.Text = "Account balance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 117);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 8;
            label4.Text = "Date of birth";
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(137, 152);
            createButton.Name = "createButton";
            createButton.Size = new Size(91, 35);
            createButton.TabIndex = 9;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // errosListBox
            // 
            errosListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errosListBox.FormattingEnabled = true;
            errosListBox.ItemHeight = 21;
            errosListBox.Location = new Point(137, 236);
            errosListBox.Name = "errosListBox";
            errosListBox.Size = new Size(633, 130);
            errosListBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 236);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 11;
            label5.Text = "Error list";
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateOfBirthPicker.Location = new Point(137, 117);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(293, 29);
            dateOfBirthPicker.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 380);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(label5);
            Controls.Add(errosListBox);
            Controls.Add(createButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(accountBalanceText);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(label1);
            Name = "principalForm";
            Text = "Client validations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox accountBalanceText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button createButton;
        private ListBox errosListBox;
        private Label label5;
        private DateTimePicker dateOfBirthPicker;
    }
}