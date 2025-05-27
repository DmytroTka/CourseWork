namespace CourseWork
{
    partial class UserControlSizeInput
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelSizeMatrix = new Label();
            sizeInputGroupBox = new GroupBox();
            SizeTextBox = new TextBox();
            errorLabel = new Label();
            labelSizeMatrixInfo = new Label();
            buttonSizeMatrix = new Button();
            sizeInputGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // labelSizeMatrix
            // 
            labelSizeMatrix.AutoSize = true;
            labelSizeMatrix.Font = new Font("Segoe UI", 12F);
            labelSizeMatrix.Location = new Point(345, 84);
            labelSizeMatrix.Name = "labelSizeMatrix";
            labelSizeMatrix.Size = new Size(249, 28);
            labelSizeMatrix.TabIndex = 0;
            labelSizeMatrix.Text = "Введіть розмірність СЛАР.\r\n";
            // 
            // sizeInputGroupBox
            // 
            sizeInputGroupBox.Controls.Add(SizeTextBox);
            sizeInputGroupBox.Controls.Add(errorLabel);
            sizeInputGroupBox.Controls.Add(labelSizeMatrixInfo);
            sizeInputGroupBox.Controls.Add(buttonSizeMatrix);
            sizeInputGroupBox.Controls.Add(labelSizeMatrix);
            sizeInputGroupBox.Font = new Font("Segoe UI", 12F);
            sizeInputGroupBox.Location = new Point(3, 8);
            sizeInputGroupBox.Name = "sizeInputGroupBox";
            sizeInputGroupBox.Size = new Size(972, 640);
            sizeInputGroupBox.TabIndex = 1;
            sizeInputGroupBox.TabStop = false;
            sizeInputGroupBox.Text = "Введення розмірності СЛАР";
            sizeInputGroupBox.VisibleChanged += sizeInputGroupBox_Enter;
            // 
            // SizeTextBox
            // 
            SizeTextBox.Location = new Point(379, 148);
            SizeTextBox.Name = "SizeTextBox";
            SizeTextBox.Size = new Size(175, 34);
            SizeTextBox.TabIndex = 6;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Tomato;
            errorLabel.Location = new Point(20, 345);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 28);
            errorLabel.TabIndex = 5;
            // 
            // labelSizeMatrixInfo
            // 
            labelSizeMatrixInfo.AutoSize = true;
            labelSizeMatrixInfo.Location = new Point(20, 290);
            labelSizeMatrixInfo.Name = "labelSizeMatrixInfo";
            labelSizeMatrixInfo.Size = new Size(952, 28);
            labelSizeMatrixInfo.TabIndex = 4;
            labelSizeMatrixInfo.Text = "При заданні роміру використовуйте цілі числа в діапазоні від {SLAE.MIN_VALUE} до {SLAE.MAX_VALUE}";
            // 
            // buttonSizeMatrix
            // 
            buttonSizeMatrix.Font = new Font("Segoe UI", 12F);
            buttonSizeMatrix.Location = new Point(392, 208);
            buttonSizeMatrix.Name = "buttonSizeMatrix";
            buttonSizeMatrix.Size = new Size(146, 42);
            buttonSizeMatrix.TabIndex = 1;
            buttonSizeMatrix.Text = "Продовжити";
            buttonSizeMatrix.UseVisualStyleBackColor = true;
            buttonSizeMatrix.Click += buttonSizeMatrix_Click;
            // 
            // UserControlSizeInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sizeInputGroupBox);
            Name = "UserControlSizeInput";
            Size = new Size(978, 651);
            sizeInputGroupBox.ResumeLayout(false);
            sizeInputGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelSizeMatrix;
        private GroupBox sizeInputGroupBox;
        private Label labelSizeMatrixInfo;
        private Button buttonSizeMatrix;
        private Label errorLabel;
        private TextBox SizeTextBox;
    }
}
