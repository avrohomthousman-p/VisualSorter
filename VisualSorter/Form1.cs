using System.Windows.Forms;
using VisualSorter.SortingLogic;
using static System.Windows.Forms.AxHost;

namespace VisualSorter
{
    public partial class MainWindow : Form
    {
        private static readonly int DATA_SIZE = 14; //how many numbers will be sorted

        private static readonly int BAR_WIDTH = 20;
        private static readonly int GAP_BETWEEN_BARS = 20;

        private IStepByStepSorter sortBeingUsed = new BubbleSorter(DATA_SIZE);



        public MainWindow()
        {
            InitializeComponent();

            sortBeingUsed.Reset(DATA_SIZE);
        }




        private void DataPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 10;

            int TextHeight = 15;

            for (int i = 0; i < DATA_SIZE; i++)
            {
                int barHeight = sortBeingUsed.GetDataAt(i) * 2;
                Rectangle rect = new Rectangle(x, DataPanel.Height - barHeight - TextHeight, BAR_WIDTH, barHeight);
                g.FillRectangle(Brushes.Blue, rect);

                g.DrawString(sortBeingUsed.GetDataAt(i).ToString(), Font, Brushes.Black, new PointF(x, DataPanel.Height - TextHeight));

                x += BAR_WIDTH + GAP_BETWEEN_BARS;
            }
        }




        /// <summary>
        /// Instantiates a sorting algorithm based on the selected radio buttons.
        /// </summary>
        /// <returns>an instance of the sorting algorithm that was selected by the user</returns>
        /// <exception cref="Exception">if non of the radio buttons were selected</exception>
        private IStepByStepSorter ChooseSortingAlgorithm()
        {
            if (this.BubbleSort.Checked)
            {
                return new BubbleSorter(DATA_SIZE);
            }
            else if (this.QuickSort.Checked)
            {
                return new QuickSorter(DATA_SIZE);
            }
            else if (this.ShellSort.Checked)
            {
                return new ShellSorter(DATA_SIZE);
            }
            else if (this.InsertionSort.Checked)
            {
                return new InsertionSorter(DATA_SIZE);
            }
            else if (this.SelectionSort.Checked)
            {
                return new SelectionSorter(DATA_SIZE);
            }
            else
            {
                throw new Exception("None of the radio buttons were selected");
            }
        }



        private void SortBtn_Click(object sender, EventArgs e)
        {
            this.SortBtn.Enabled = false;
            this.ResetBtn.Enabled = false;


            
            //Setup the selected sorting algorithm
            var newSorter = ChooseSortingAlgorithm();
            if (this.sortBeingUsed.GetType() != newSorter.GetType()) //if we are not using the right algo
            {
                //switch to the new algorithim
                newSorter.SetData(this.sortBeingUsed.GetData());
                this.sortBeingUsed = newSorter;
            }




            //Start the sorting on another thread
            Thread t = new Thread(() => {
                var swaps = this.sortBeingUsed.Sort();

                foreach(Tuple<int, int> unused in swaps)
                {
                    DataPanel.Invalidate();
                    Thread.Sleep(500);
                }


                Invoke(() => this.ResetBtn.Enabled = true);
                
            });

            t.Start();
        }



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            this.sortBeingUsed.Reset(DATA_SIZE);

            DataPanel.Invalidate();

            this.SortBtn.Enabled = true;
        }

    }
}
