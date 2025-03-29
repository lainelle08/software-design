namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] numbers = { 3, 1, 5, 2, 4 };
            Sort sort = new Sort();
            int[] sortedNumbers = sort.ProceduralSort(numbers);
            listBoxResults.DataSource = sortedNumbers;
        }
    }
    
    //Applying OOP
    public class Sort
    {
        public int[] ProceduralSort(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers;
        }
    }
}
