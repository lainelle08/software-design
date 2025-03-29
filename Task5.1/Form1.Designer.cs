namespace Task5._1
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
            btnBubbleSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(77, 62);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(152, 51);
            btnBubbleSort.TabIndex = 0;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(319, 62);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(411, 324);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnBubbleSort);
            Name = "Form1";
            Text = "Bubble Sort";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBubbleSort;
        private ListBox listBoxResults;
    }
}
