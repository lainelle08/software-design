namespace Task5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnDescendingSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            CustomSorter sorter = new CustomSorter();
            int[] sortedNumbers = sorter.DescendingSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
}
