namespace VisualSorter
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
            BubbleSort = new RadioButton();
            QuickSort = new RadioButton();
            ShellSort = new RadioButton();
            InsertionSort = new RadioButton();
            SelectionSort = new RadioButton();
            SuspendLayout();
            // 
            // BubbleSort
            // 
            BubbleSort.AutoSize = true;
            BubbleSort.Checked = true;
            BubbleSort.Location = new Point(636, 70);
            BubbleSort.Name = "BubbleSort";
            BubbleSort.Size = new Size(86, 19);
            BubbleSort.TabIndex = 0;
            BubbleSort.TabStop = true;
            BubbleSort.Text = "Bubble Sort";
            BubbleSort.UseVisualStyleBackColor = true;
            // 
            // QuickSort
            // 
            QuickSort.AutoSize = true;
            QuickSort.Location = new Point(636, 95);
            QuickSort.Name = "QuickSort";
            QuickSort.Size = new Size(80, 19);
            QuickSort.TabIndex = 1;
            QuickSort.TabStop = true;
            QuickSort.Text = "Quick Sort";
            QuickSort.UseVisualStyleBackColor = true;
            // 
            // ShellSort
            // 
            ShellSort.AutoSize = true;
            ShellSort.Location = new Point(636, 120);
            ShellSort.Name = "ShellSort";
            ShellSort.Size = new Size(74, 19);
            ShellSort.TabIndex = 2;
            ShellSort.TabStop = true;
            ShellSort.Text = "Shell Sort";
            ShellSort.UseVisualStyleBackColor = true;
            // 
            // InsertionSort
            // 
            InsertionSort.AutoSize = true;
            InsertionSort.Location = new Point(636, 145);
            InsertionSort.Name = "InsertionSort";
            InsertionSort.Size = new Size(95, 19);
            InsertionSort.TabIndex = 3;
            InsertionSort.TabStop = true;
            InsertionSort.Text = "Insertion Sort";
            InsertionSort.UseVisualStyleBackColor = true;
            // 
            // SelectionSort
            // 
            SelectionSort.AutoSize = true;
            SelectionSort.Location = new Point(636, 170);
            SelectionSort.Name = "SelectionSort";
            SelectionSort.Size = new Size(97, 19);
            SelectionSort.TabIndex = 4;
            SelectionSort.TabStop = true;
            SelectionSort.Text = "Selection Sort";
            SelectionSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectionSort);
            Controls.Add(InsertionSort);
            Controls.Add(ShellSort);
            Controls.Add(QuickSort);
            Controls.Add(BubbleSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton BubbleSort;
        private RadioButton QuickSort;
        private RadioButton ShellSort;
        private RadioButton InsertionSort;
        private RadioButton SelectionSort;
    }
}
