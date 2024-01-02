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

        private IStepByStepSorter sortBeingUsed = new MockSorter(); //FIXME: should default to bubble sort



        public MainWindow()
        {
            InitializeComponent();
            InitializeDataAndBars();
        }



        /// <summary>
        /// Initilization/Resets the numbers to be sorted and draws the bars on the GUI.
        /// </summary>
        private void InitializeDataAndBars()
        {
            sortBeingUsed.Reset(DATA_SIZE);

            DataPanel.Paint += DataPanel_Paint;
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
        private void ChooseSortingAlgorithm()
        {
            //TODO: complete this function
            if (this.BubbleSort.Checked)
            {

            }
            else if (this.QuickSort.Checked)
            {

            }
            else if (this.ShellSort.Checked)
            {

            }
            else if (this.InsertionSort.Checked)
            {

            }
            else if (this.SelectionSort.Checked)
            {

            }
        }

    }
}
