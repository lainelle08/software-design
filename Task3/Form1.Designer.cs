namespace Task3
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
            btnCalculateFibonacci = new Button();
            txtNumberInput = new TextBox();
            lblFibonacciResult = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtBaseInput = new TextBox();
            lblPowerResult = new Label();
            txtExponentInput = new TextBox();
            btbCalculatePower = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculateFibonacci
            // 
            btnCalculateFibonacci.Location = new Point(89, 185);
            btnCalculateFibonacci.Name = "btnCalculateFibonacci";
            btnCalculateFibonacci.Size = new Size(154, 48);
            btnCalculateFibonacci.TabIndex = 0;
            btnCalculateFibonacci.Text = "Calculate Fibonacci";
            btnCalculateFibonacci.UseVisualStyleBackColor = true;
            btnCalculateFibonacci.Click += btnCalculateFibonacci_Click;
            // 
            // txtNumberInput
            // 
            txtNumberInput.Location = new Point(101, 121);
            txtNumberInput.Name = "txtNumberInput";
            txtNumberInput.Size = new Size(125, 27);
            txtNumberInput.TabIndex = 1;
            txtNumberInput.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(101, 288);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(0, 20);
            lblFibonacciResult.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnCalculateFibonacci);
            panel1.Controls.Add(lblFibonacciResult);
            panel1.Controls.Add(txtNumberInput);
            panel1.Location = new Point(30, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 392);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 259);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Answer:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtBaseInput);
            panel2.Controls.Add(lblPowerResult);
            panel2.Controls.Add(txtExponentInput);
            panel2.Controls.Add(btbCalculatePower);
            panel2.Location = new Point(412, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 392);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 259);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Answer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 124);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 6;
            label3.Text = "Exponent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 80);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 5;
            label1.Text = "Base:";
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(178, 77);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(98, 27);
            txtBaseInput.TabIndex = 4;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(107, 288);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(0, 20);
            lblPowerResult.TabIndex = 3;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(178, 121);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(98, 27);
            txtExponentInput.TabIndex = 3;
            // 
            // btbCalculatePower
            // 
            btbCalculatePower.Location = new Point(107, 185);
            btbCalculatePower.Name = "btbCalculatePower";
            btbCalculatePower.Size = new Size(154, 48);
            btbCalculatePower.TabIndex = 3;
            btbCalculatePower.Text = "Calculate Power";
            btbCalculatePower.UseVisualStyleBackColor = true;
            btbCalculatePower.Click += btbCalculatePower_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Task 3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalculateFibonacci;
        private TextBox txtNumberInput;
        private Label lblFibonacciResult;
        private Panel panel1;
        private Panel panel2;
        private Label lblPowerResult;
        private TextBox txtExponentInput;
        private Button btbCalculatePower;
        private Label label3;
        private Label label1;
        private TextBox txtBaseInput;
        private Label label2;
        private Label label4;
    }
}
