namespace CourseWork
{
    partial class FormFileSaving
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
            writeToFileButton = new Button();
            titleLabel = new Label();
            fileNameTextBox = new TextBox();
            errorLabel = new Label();
            resultsLabel = new Label();
            SuspendLayout();
            // 
            // writeToFileButton
            // 
            writeToFileButton.Font = new Font("Segoe UI", 12F);
            writeToFileButton.Location = new Point(282, 206);
            writeToFileButton.Name = "writeToFileButton";
            writeToFileButton.Size = new Size(237, 40);
            writeToFileButton.TabIndex = 0;
            writeToFileButton.Text = "Зберегти СЛАР у файл";
            writeToFileButton.UseVisualStyleBackColor = true;
            writeToFileButton.Click += writeToFileButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F);
            titleLabel.Location = new Point(185, 74);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(439, 28);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Введіть назву файлу, у який збережеться СЛАР";
            // 
            // fileNameTextBox
            // 
            fileNameTextBox.Font = new Font("Segoe UI", 12F);
            fileNameTextBox.Location = new Point(245, 139);
            fileNameTextBox.Name = "fileNameTextBox";
            fileNameTextBox.Size = new Size(312, 34);
            fileNameTextBox.TabIndex = 2;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F);
            errorLabel.ForeColor = Color.Tomato;
            errorLabel.Location = new Point(12, 275);
            errorLabel.MaximumSize = new Size(700, 0);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(95, 28);
            errorLabel.TabIndex = 3;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Font = new Font("Segoe UI", 12F);
            resultsLabel.Location = new Point(12, 315);
            resultsLabel.MaximumSize = new Size(700, 0);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(112, 28);
            resultsLabel.TabIndex = 4;
            // 
            // FormFileSaving
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsLabel);
            Controls.Add(errorLabel);
            Controls.Add(fileNameTextBox);
            Controls.Add(titleLabel);
            Controls.Add(writeToFileButton);
            Name = "FormFileSaving";
            Text = "Збереження СЛАР у файлі";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button writeToFileButton;
        private Label titleLabel;
        private TextBox fileNameTextBox;
        private Label errorLabel;
        private Label resultsLabel;
    }
}