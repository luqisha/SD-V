namespace CSE3200_Offline_190104140
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            
            if ( !ValidateTexts() )
            {
                return;
            }

            List<(int, double)> Numbers = new List<(int, double)>();
            Numbers.Add((Convert.ToInt32(CSE1200Mark.Value), 1.50));
            Numbers.Add((Convert.ToInt32(CSE1203Mark.Value), 3.00));
            Numbers.Add((Convert.ToInt32(CSE1205Mark.Value), 3.00));
            Numbers.Add((Convert.ToInt32(CSE1206Mark.Value), 1.50));
            Numbers.Add((Convert.ToInt32(EEE1241Mark.Value), 3.00));
            Numbers.Add((Convert.ToInt32(EEE1242Mark.Value), 1.50));
            Numbers.Add((Convert.ToInt32(MATH1219Mark.Value), 3.00));
            Numbers.Add((Convert.ToInt32(ME1211Mark.Value), 3.00));
            Numbers.Add((Convert.ToInt32(ME1214Mark.Value), 0.75));


            double sum= 0;
            foreach(var number in Numbers)
            {
                sum += CalculateGrade(number.Item1) * number.Item2;
            }

            double GPA = sum / 20.25;

            Form2 newWindow = new Form2(this, NameTBox.Text, GPA); 
            this.Hide();
            newWindow.Show();


        }

        bool ValidateTexts()
        {
            if (String.IsNullOrEmpty(NameTBox.Text) || String.IsNullOrEmpty(IDTBox.Text))
            {
                MessageBox.Show("One or More TextBox(s) empty !", "Empty Textbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IDTBox.Text.Length != 9 || !IDTBox.Text.All(char.IsDigit) || !IDTBox.Text.StartsWith("190104"))
            {
                MessageBox.Show("ID Not Valid for CSE 1.2 !", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        double CalculateGrade(int marks)
        {
            if (marks >= 80)
                return 4.0;
            else if (marks >= 75)
                return 3.75;
            else if (marks >= 70)
                return 3.50;
            else if (marks >= 65)
                return 3.25;
            else if (marks >= 60)
                return 3.00;
            else if (marks >= 55)
                return 2.75;
            else if (marks >= 50)
                return 2.5;
            else if (marks >= 45)
                return 2.25;
            else if (marks >= 40)
                return 2.0;
            else
                return 0.0;
        }


        private void marksValidate(object sender, System.ComponentModel.CancelEventArgs e)
        {
            NumericUpDown CurrentMarks = (NumericUpDown)sender;
            if (CurrentMarks.Value > 100)
            {
                CurrentMarks.Value = 100;
                MessageBox.Show("Entered Marks is >100. Resetting Marks to 100 !", "Resetting", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (CurrentMarks.Value < 0)
            {
                CurrentMarks.Value = 0;
                MessageBox.Show("Entered Marks is < 0. Resetting Marks to 0 !", "Resetting", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}