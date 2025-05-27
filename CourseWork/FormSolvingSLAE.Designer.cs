namespace CourseWork
{
    partial class FormSolvingSLAE
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
            userControlSizeInput1 = new UserControlSizeInput();
            userControlMatrixInput1 = new UserControlMatrixInput();
            userControlResultsOutput1 = new UserControlResultsOutput();
            SuspendLayout();
            // 
            // userControlSizeInput1
            // 
            userControlSizeInput1.Location = new Point(0, -1);
            userControlSizeInput1.Name = "userControlSizeInput1";
            userControlSizeInput1.Size = new Size(983, 609);
            userControlSizeInput1.TabIndex = 0;
            // 
            // userControlMatrixInput1
            // 
            userControlMatrixInput1.Location = new Point(0, -1);
            userControlMatrixInput1.MatrixSize = 0;
            userControlMatrixInput1.Name = "userControlMatrixInput1";
            userControlMatrixInput1.Size = new Size(983, 617);
            userControlMatrixInput1.TabIndex = 1;
            userControlMatrixInput1.Visible = false;
            // 
            // userControlResultsOutput1
            // 
            userControlResultsOutput1.Location = new Point(0, -1);
            userControlResultsOutput1.Name = "userControlResultsOutput1";
            userControlResultsOutput1.Size = new Size(983, 617);
            userControlResultsOutput1.TabIndex = 2;
            userControlResultsOutput1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 611);
            Controls.Add(userControlResultsOutput1);
            Controls.Add(userControlMatrixInput1);
            Controls.Add(userControlSizeInput1);
            Name = "Form1";
            Text = "Розв'язок СЛАР точними методами на комплексній площині";
            ResumeLayout(false);
        }

        #endregion

        private UserControlSizeInput userControlSizeInput1;
        private UserControlMatrixInput userControlMatrixInput1;
        private UserControlResultsOutput userControlResultsOutput1;
    }
}
