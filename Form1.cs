namespace Calc
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private string Operator;
        private double FirstInput = 0.0;
        private double SecondInput = 0.0;
        private double Result = 0.0;
        private int OperatorCounter = 0;
        private int LabelCounter = 0;
        private bool Cleared = false;
        private bool LabelClear = false;
        private int LabelClearCount = 0;
        private bool EqualPressed = false;
        private int EqualCounter = 0;
        private bool inverse = false;
        private bool sqrt = false;
        private bool OneEquations = false;
        private bool SquareUsed = false;
        private bool OperatorUsed = true;


        private void ListBox()
        {
            if (TextBox.Text.Contains("0") == true && LabelCounter > 0)
            {
                listBox1.Text = " ";
            }

            if (inverse == true)
            {
                listBox1.Items.Add("1/ " + FirstInput + " = " + Result);

            }
            else if (sqrt == true)
            {
                listBox1.Items.Add("Sqrt(" + FirstInput + ")" + " =" + Result);
            }
            else if (SquareUsed == true)
            {
                listBox1.Items.Add(FirstInput + Operator + " = " + Result);

            }
            else
            {
                listBox1.Items.Add(FirstInput + Operator + SecondInput + " = " + Result);
            }
            inverse = false;
            SquareUsed = false;
            sqrt = false;

        }

        private void History()
        {
            if (LabelClear == true)
            {
                TextBox.Clear();
                label1.Text = " ";
                LabelClearCount++;       

            }

            else if (EqualPressed == true)
            {
                if (EqualPressed == true && EqualCounter == 1)
                {
                    label1.Text = " ";
                    label1.Text = TextBox.Text;
                }

                label1.Text = " ";
                label1.Text = TextBox.Text;
                switch (Operator)
                {
                    case "+":
                        label1.Text = FirstInput.ToString() + "+" + SecondInput.ToString() + "=";
                        break;
                    case "-":
                        label1.Text = FirstInput.ToString() + "-" + SecondInput.ToString() + "=";
                        break;
                    case "/":
                        label1.Text = FirstInput.ToString() + "/" + SecondInput.ToString() + "=";
                        break;
                    case "*":
                        label1.Text = FirstInput.ToString() + "*" + SecondInput.ToString() + "=";
                        break;
                    case "^":
                        label1.Text = FirstInput.ToString() + "^" + SecondInput.ToString() + "=";
                        break;

                }

            }
            else if (LabelCounter > 0 && EqualCounter == 0)
            {

                label1.Text = TextBox.Text;
                switch (Operator)
                {
                    case "+":
                        label1.Text = FirstInput.ToString() + "+";
                        break;
                    case "-":
                        label1.Text = FirstInput.ToString() + "-";
                        break;
                    case "/":
                        label1.Text = FirstInput.ToString() + "/";
                        break;
                    case "*":
                        label1.Text = FirstInput.ToString() + "*";
                        break;
                    case "^":
                        label1.Text = FirstInput.ToString() + "^";
                        break;
                }

            }


            EqualCounter = 0;
            LabelClear = false;

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || LabelClearCount > 0)
            {
                TextBox.Clear();
                LabelCounter++;
                TextBox.Text = "";
            }
            if (LabelClearCount > 0)
            {
                TextBox.Clear();
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;


        }

        private void One_Click(object sender, EventArgs e)
        {

            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
                listBox1.Text = " ";


            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;

        }

        private void Two_Click(object sender, EventArgs e)
        {

            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
                listBox1.Text = " ";


            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Three_Click(object sender, EventArgs e)
        {


            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
                listBox1.Text = " ";


            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
                listBox1.Text = " ";

            }
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
            }
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
            }
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();
            }


            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (OperatorCounter != 0 || EqualPressed == true || OneEquations == true)
            {
                TextBox.Clear();

            }

            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }

            OperatorCounter = 0;
            LabelCounter++;
            History();
            EqualPressed = false;
            OneEquations = false;
        }

        private int DotCounter = 0;
        private void Dot_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";

            }
            else if(DotCounter == 0)
            {
                DotCounter++;
                TextBox.Text += ".";
                  
            }
            
        }
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            if (Double.Parse(TextBox.Text) > 0)
            {
                TextBox.Text = "-" + TextBox.Text;
            }
            else
            {
                if (Double.Parse(TextBox.Text) != 0)
                {
                    double x = -1 * Double.Parse(TextBox.Text);
                    TextBox.Text = x.ToString();
                }
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {

            FirstInput = double.Parse(TextBox.Text);
            TextBox.Text = FirstInput.ToString();

            Operator = "+";
            OperatorCounter++;
            History();



    }

    private void Minus_Click(object sender, EventArgs e)
        {
            History();
            FirstInput = double.Parse(TextBox.Text);
            TextBox.Text = FirstInput.ToString();
            Operator = "-";
            OperatorCounter++;
            OperatorUsed = true;

        }

        private void Times_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            TextBox.Text = FirstInput.ToString();
            Operator = "*";
            OperatorCounter++;
            OperatorUsed = true;

        }

        private void Divide_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            TextBox.Text = FirstInput.ToString();
            Operator = "/";
            OperatorCounter++;
                        OperatorUsed = true;

        }


        private void Sqrt_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            Result = Math.Sqrt(double.Parse(TextBox.Text));
            TextBox.Text = Result.ToString();
            OneEquations = true;
            sqrt = true;
            ListBox();
            OperatorUsed = true;



        }

        private void Square_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            Result = Math.Pow(double.Parse(TextBox.Text), 2);
            TextBox.Text = Result.ToString();
            Operator = "^" + "2";
            SquareUsed = true;
            OneEquations = true;
            ListBox();
            OperatorUsed = true;


        }

        private void Power_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            Operator = "^";
            OperatorCounter++;

        }
        private void Inverse_Click(object sender, EventArgs e)
        {
            FirstInput = double.Parse(TextBox.Text);
            Result = 1 / double.Parse(TextBox.Text);
            TextBox.Text = Result.ToString();
            inverse = true;
            OneEquations = true;

            ListBox();

        }

        private string holder;
        private void ClearElement_Click(object sender, EventArgs e)
        {
            SecondInput = 0;
            TextBox.Text = SecondInput.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            DotCounter = 0;
            TextBox.Clear();
            listBox1.Text = " ";
            Cleared = true;
            LabelClear = true;
            History();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int stringLength = TextBox.Text.Length;
            if (stringLength > 1)
            {
                TextBox.Text = TextBox.Text.Substring(0, stringLength - 1);
            }
            else
            {
                TextBox.Text = "0";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            DotCounter = 0;
            listBox1.Text = " ";
            EqualPressed = true;
            if (TextBox.Text.Equals("0") == false)
            {
                switch (Operator)
                {
                    case "+":
                        SecondInput = double.Parse(TextBox.Text);
                        Result = FirstInput + SecondInput;
                        TextBox.Text = Result.ToString();
                        break;
                    case "-":
                        SecondInput = double.Parse(TextBox.Text);
                        Result = FirstInput - SecondInput;
                        TextBox.Text = Result.ToString();
                        break;
                    case "/":
                        SecondInput = double.Parse(TextBox.Text);
                        Result = FirstInput / SecondInput;
                        TextBox.Text = Result.ToString();
                        break;
                    case "*":
                        SecondInput = double.Parse(TextBox.Text);
                        Result = FirstInput * SecondInput;
                        TextBox.Text = Result.ToString();
                        break;
                    case "^":
                        SecondInput = double.Parse(TextBox.Text);
                        Result = Math.Pow(FirstInput, SecondInput);
                        TextBox.Text = Result.ToString();
                        break;

                }
            }
            History();
            EqualCounter = 1;
            ListBox();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    One.PerformClick();
                    break;
                case Keys.D1:
                    One.PerformClick();
                    break;
                case Keys.NumPad2:
                    Two.PerformClick();
                    break;
                case Keys.D2:
                    Two.PerformClick();
                    break;
                case Keys.NumPad3:
                    Three.PerformClick();
                    break;
                case Keys.D3:
                    Three.PerformClick();
                    break;
                case Keys.NumPad4:
                    Four.PerformClick();
                    break;
                case Keys.D4:
                    Four.PerformClick();
                    break;
                case Keys.NumPad5:
                    Five.PerformClick();
                    break;
                case Keys.D5:
                    Five.PerformClick();
                    break;
                case Keys.NumPad6:
                    Six.PerformClick();
                    break;
                case Keys.D6:
                    Six.PerformClick();
                    break;
                case Keys.NumPad7:
                    Seven.PerformClick();
                    break;
                case Keys.D7:
                    Seven.PerformClick();
                    break;
                case Keys.NumPad8:
                    Eight.PerformClick();
                    break;
                case Keys.D8:
                    Eight.PerformClick();
                    break;
                case Keys.NumPad9:
                    Nine.PerformClick();
                    break;
                case Keys.D9:
                    Nine.PerformClick();
                    break;
                case Keys.D0:
                    Zero.PerformClick();
                    break;
                case Keys.NumPad0:
                    Zero.PerformClick();
                    break;
               
                   
                default:
                    break;
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    Delete.PerformClick();
                    break;
               case Keys.Enter:
                    Equals.PerformClick();
                   break;
               
                     
                
                default:
                    break;
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "+")
            {
                Plus.PerformClick();
            }
            if (e.KeyChar.ToString() == "*")
            {
                Times.PerformClick();
            }
            if (e.KeyChar.ToString() == "-")
            {
                Minus.PerformClick();
            }
            if (e.KeyChar.ToString() == "^")
            {
                Power.PerformClick();
            }
            if (e.KeyChar.ToString() == "/")
            {
                Divide.PerformClick();
            }
            if (e.KeyChar.ToString() == ".")
            {
                Dot.PerformClick();

            }
         
        }
      
        static void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Equals.ToString();
                //enter key is down
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}