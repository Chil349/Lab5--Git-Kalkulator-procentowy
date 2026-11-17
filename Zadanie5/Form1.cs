namespace Zadanie5
{
    public partial class Form1 : Form
    {
        private SolutionCalculator calculator = new SolutionCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double capacity = double.Parse(textCapacity.Text.Replace('.', ','));
                double percentage = double.Parse(textPercent.Text.Replace('.', ','));
                int vesselCount = int.Parse(textQuantity.Text);

                var result = calculator.Calculate(capacity, percentage, vesselCount);

                textTotalVolume.Text = Math.Round(result.totalVolume, 2).ToString();
                textPureSubstance.Text = Math.Round(result.pureSubstanceVolume, 2).ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Wpisz poprawne liczby.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboDishes.SelectedIndex = comboDishes.Items.Count - 1;
            comboSolutions.SelectedIndex = comboSolutions.Items.Count - 1;
            textCapacity.Clear();
            textPercent.Clear();
            textQuantity.Text = "1";
            textTotalVolume.Clear();
            textPureSubstance.Clear();
        }
    }
}
