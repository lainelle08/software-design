namespace Task5._2
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
            btnDescendingSort = new Button();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // btnDescendingSort
            // 
            btnDescendingSort.Location = new Point(81, 65);
            btnDescendingSort.Name = "btnDescendingSort";
            btnDescendingSort.Size = new Size(143, 51);
            btnDescendingSort.TabIndex = 0;
            btnDescendingSort.Text = "Descending Sort";
            btnDescendingSort.UseVisualStyleBackColor = true;
            btnDescendingSort.Click += btnDescendingSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(305, 65);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(413, 324);
            listBoxResults.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResults);
            Controls.Add(btnDescendingSort);
            Name = "Form1";
            Text = "Descending Sort";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDescendingSort;
        private ListBox listBoxResults;
    }
}
