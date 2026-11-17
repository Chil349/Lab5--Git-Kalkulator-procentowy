using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form1 : Form
    {
        private SolutionCalculator calculator = new SolutionCalculator();

        public Form1()
        {
            InitializeComponent();
            comboDishes.DataSource = new List<string>(calculator.TypicalVessels.Keys);
            comboSolutions.DataSource = new List<string>(calculator.TypicalSolutions.Keys);
            textQuantity.Text = "1";
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

        private void comboDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calculator.TypicalVessels.TryGetValue(comboDishes.Text, out double capacity))
            {
                textCapacity.Text = capacity > 0 ? capacity.ToString() : string.Empty;
            }
        }

        private void comboSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (calculator.TypicalSolutions.TryGetValue(comboSolutions.Text, out double percentage))
            {
                textPercent.Text = percentage > 0 ? percentage.ToString() : string.Empty;
            }
        }
    }
}
