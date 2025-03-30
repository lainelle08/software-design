namespace lab2
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
            txtInput = new TextBox();
            btnCalculateFactorial = new Button();
            lblResult = new Label();
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(82, 120);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(146, 27);
            txtInput.TabIndex = 0;
            txtInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(280, 108);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(199, 50);
            btnCalculateFactorial.TabIndex = 1;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(280, 176);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 3;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(82, 267);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(146, 27);
            txtArrayInput.TabIndex = 4;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(280, 255);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(199, 50);
            btnCalculateSum.TabIndex = 5;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(280, 321);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(0, 20);
            lblSumResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 454);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(lblResult);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(txtInput);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnCalculateFactorial;
        private Label lblResult;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
    }
}
