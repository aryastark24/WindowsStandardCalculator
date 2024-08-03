using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StandardCalculator : Form
    {
        public StandardCalculator()
        {
            InitializeComponent();
            this.KeyPreview = true; // for keys binding 
        }

        private bool IsOperationPerformed = false;
        private bool IsScientificOperationPerformed = false;
        private double Result = 0;
        private string Operation = "";
        private double LastNumber = 0;
        private int Counter = 0;
        private bool IsEqualsPerformed = false;
        private int ButtonEqualCounter = 0; 

        /// <summary>
        /// Digits Input On Calculator(0-9).
        /// </summary>

        private void Btn0_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "0";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "1";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "2";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "3";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "4";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "5";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }

            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "6";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }
            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }
            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "7";
            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }

            if (IsEqualsPerformed && ButtonEqualCounter!=2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;
            }
            
            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "8";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Counter = 0;
            if (RtbDisplayText.Text == "0" || (IsOperationPerformed))
            {
                RtbDisplayText.Clear();
            }
            if (IsEqualsPerformed && ButtonEqualCounter != 2)
            {
                RtbDisplayText.Clear();
                ButtonEqualCounter = 2;

            }            
            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            RtbDisplayText.Text += "9";

            if (IsEqualsPerformed)
            {
                Result = double.Parse(RtbDisplayText.Text);
                Counter = 2;
            }
        }

        /// <summary>
        /// Decimal Input On Calculator.
        /// </summary>

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (!RtbDisplayText.Text.Contains("."))
            {
                RtbDisplayText.Text = RtbDisplayText.Text + ".";
            }

        }

        /// <summary>
        /// Negate Input On Calculator.
        /// </summary>

        private void BtnNegate_Click(object sender, EventArgs e)
        {
            if (double.Parse(RtbDisplayText.Text) > 0)
            {
                RtbDisplayText.Text = double.Parse("-" + RtbDisplayText.Text).ToString();
            }
            else
            {
                RtbDisplayText.Text = Math.Abs(double.Parse(RtbDisplayText.Text)).ToString();
            }
            if (IsEqualsPerformed) //when Equals affect the negate values for ex 2-9=-7+12=5 now put negate -5 then equals should give 7
            {
                Result = double.Parse(RtbDisplayText.Text);
            }
        }

        /// <summary>
        /// Basic Operator Input On Calculator.
        /// </summary>

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                Counter = 0;
                if (Result != 0 && !IsOperationPerformed && !IsEqualsPerformed)
                {
                    BtnEquals.PerformClick();
                }
                Operation = "+";
                LastNumber = double.Parse(RtbDisplayText.Text);
                Result = double.Parse(RtbDisplayText.Text);
                IsOperationPerformed = true;
                IsEqualsPerformed = false;
                IsScientificOperationPerformed = false;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }

        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                Counter = 0;
                if (Result != 0 && !IsOperationPerformed && !IsEqualsPerformed)
                {
                    BtnEquals.PerformClick();
                }
                Operation = "-";
                Result = double.Parse(RtbDisplayText.Text);
                LastNumber = double.Parse(RtbDisplayText.Text);
                IsOperationPerformed = true;
                IsEqualsPerformed = false;
                IsScientificOperationPerformed = false;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                Counter = 0;
                if (Result != 0 && !IsOperationPerformed && !IsEqualsPerformed)
                {
                    BtnEquals.PerformClick();
                }
                Operation = "*";
                LastNumber = double.Parse(RtbDisplayText.Text);
                Result = double.Parse(RtbDisplayText.Text);
                IsOperationPerformed = true;
                IsEqualsPerformed = false;
                IsScientificOperationPerformed = false;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                Counter = 0;
                if (Result != 0 && !IsOperationPerformed && !IsEqualsPerformed)
                {
                    BtnEquals.PerformClick();
                }
                Operation = "/";
                LastNumber = double.Parse(RtbDisplayText.Text);
                Result = double.Parse(RtbDisplayText.Text);
                IsOperationPerformed = true;
                IsEqualsPerformed = false;
                IsScientificOperationPerformed = false;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        /// <summary>
        /// Scientific Operator Input On Calculator.
        /// </summary>

        private void BtnPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                RtbDisplayText.Text = (Result * double.Parse(RtbDisplayText.Text) / 100).ToString();

                if (Operation == null)
                {
                    Result = double.Parse(RtbDisplayText.Text);
                }

                IsScientificOperationPerformed = true;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        private void BtnUnderRoot_Click(object sender, EventArgs e)
        {
            try
            {
                RtbDisplayText.Text = (Math.Sqrt(double.Parse(RtbDisplayText.Text))).ToString();
                if (RtbDisplayText.Text == "NaN")
                {
                    RtbDisplayText.Text = "Invalid Input!";
                }
                if (Operation == null)
                {
                    Result = double.Parse(RtbDisplayText.Text);
                }

                IsScientificOperationPerformed = true;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        private void BtnNumSquare_Click(object sender, EventArgs e)
        {
            try
            {
                RtbDisplayText.Text = (double.Parse(RtbDisplayText.Text) * double.Parse(RtbDisplayText.Text)).ToString();
                if (Operation == null)
                {
                    Result = double.Parse(RtbDisplayText.Text);
                }
                IsScientificOperationPerformed = true;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        private void BtnFraction_Click(object sender, EventArgs e)
        {
            try
            {
                if (RtbDisplayText.Text == "0")
                {
                    RtbDisplayText.Text = "Cannot divide by zero!";
                }
                else
                {
                    RtbDisplayText.Text = (1 / double.Parse(RtbDisplayText.Text)).ToString();
                }
                if (Operation == null)
                {
                    Result = double.Parse(RtbDisplayText.Text);
                }

                IsScientificOperationPerformed = true;
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        /// <summary>
        /// Equals Operator On Calculator.
        /// </summary>

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            Counter += 1;
            IsEqualsPerformed = true;
            if (IsScientificOperationPerformed && Operation == "")
            {
                return;
            }
            if (Operation == "")   //prevents from doing anything if no operations are selected
            {
                return;
            }
            OperationsCheck();
            ButtonEqualCounter = 0; //it should clear window after evry equals click for new computation
        }

        /// <summary>
        /// ClearScreen funtions Input On Calculator.
        /// </summary>

        private void BtnClear_Click(object sender, EventArgs e)
        {
            RtbDisplayText.Text = "0";
            IsOperationPerformed = false;
            IsScientificOperationPerformed = false;
            Result = 0;
            Operation = "";
            LastNumber = 0;
            Counter = 0;
            IsEqualsPerformed = false;
            ButtonEqualCounter = 0;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            //Once you CE the screen, it should be able to take lastnumber for equals button to computate further
            RtbDisplayText.Text = "0";
            Result = 0;
            Counter = 2;
            ButtonEqualCounter = 0;
        }

        /// <summary>
        /// OperationsCheck funtion Input On Calculator.
        /// Below funtion works when User uses equals multiple times (in this case "Second Number" is the main element for computation)
        /// </summary>

        private void OperationsCheck()
        {
            try
            {
                double secondNumbers = double.Parse(RtbDisplayText.Text);
                if (Counter >= 2) //When we initiate multiple equals then it will take last Second number as the input
                {
                    switch (Operation)
                    {
                        case "+":
                            RtbDisplayText.Text = (Result + LastNumber).ToString();
                            Result = double.Parse(RtbDisplayText.Text);
                            break;
                        case "-":
                            RtbDisplayText.Text = (Result - LastNumber).ToString();
                            Result = double.Parse(RtbDisplayText.Text);
                            break;
                        case "*":
                            RtbDisplayText.Text = (Result * LastNumber).ToString();
                            Result = double.Parse(RtbDisplayText.Text);
                            break;
                        case "/":
                            if (Result == 0 && LastNumber == 0)
                            {
                                RtbDisplayText.Text = "Result is undefined";
                            }
                            else if (double.Parse(RtbDisplayText.Text) != 0)
                            {
                                RtbDisplayText.Text = (Result / LastNumber).ToString();
                                Result = double.Parse(RtbDisplayText.Text);
                            }
                            else
                            {
                                RtbDisplayText.Text = "Cannot divide by zero!";
                            }
                            break;
                        default:
                            break;
                    }
                    IsOperationPerformed = false;
                }
                else
                {
                    OperationsCheckEquals(secondNumbers);
                }
            }
            catch (Exception ex)
            {
                RtbDisplayText.Text = (ex.Message);
            }
        }

        /// <summary>
        /// OperationsCheckEquals funtion Input On Calculator.
        /// User will use operators without using Equals or using equals 1 time
        /// </summary>
 
        private void OperationsCheckEquals(double secondNumber)
        {
            switch (Operation) //this case will perform computation on normal inputs
            {
                case "+":
                    RtbDisplayText.Text = (Result + secondNumber).ToString();
                    Result = double.Parse(RtbDisplayText.Text);
                    break;
                case "-":
                    RtbDisplayText.Text = (Result - secondNumber).ToString();
                    Result = double.Parse(RtbDisplayText.Text);
                    break;
                case "*":
                    RtbDisplayText.Text = (Result * secondNumber).ToString();
                    Result = double.Parse(RtbDisplayText.Text);
                    break;
                case "/":
                    if(Result==0 && secondNumber==0)
                    {
                        RtbDisplayText.Text = "Result is undefined";
                    }
                    else if (double.Parse(RtbDisplayText.Text) != 0)
                    {
                        RtbDisplayText.Text = (Result / secondNumber).ToString();
                        Result = double.Parse(RtbDisplayText.Text);
                    }
                    else
                    {
                        RtbDisplayText.Text = "Cannot divide by zero!";
                    }
                    break;
                default:
                    break;
            }
            LastNumber = secondNumber; //update last with second Number
            IsOperationPerformed = false; //reset flag for operators
        }

        /// <summary>
        /// Backspace button On Calculator.
        /// </summary>

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsScientificOperationPerformed)
                {
                    return;
                }
                if (RtbDisplayText.Text != "0" || (IsOperationPerformed))
                {
                    if (!IsEqualsPerformed) //to avoid backspacing once we calculated something
                    {
                        RtbDisplayText.Text = RtbDisplayText.Text.Remove(RtbDisplayText.TextLength - 1);
                    }
                }
                
            }
            catch (Exception)
            {
                RtbDisplayText.Text = "0";
            }

        }

        /// <summary>
        /// Keybindings On Calculator.
        /// </summary>

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //Operators Keys Binding
                case Keys.Add:
                    BtnPlus.PerformClick();
                    break;
                case Keys.Oemplus:
                    BtnPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    BtnMinus.PerformClick();
                    break;
                case Keys.OemMinus:
                    BtnMinus.PerformClick();
                    break;
                case Keys.Multiply:
                    BtnMultiplication.PerformClick();
                    break;
                case Keys.Divide:
                    BtnDivision.PerformClick();
                    break;
                case Keys.Enter:
                    BtnEquals.PerformClick();
                    break;


                //Digits Keys Binding
                case Keys.NumPad0:
                    Btn0.PerformClick();
                    break;
                case Keys.D0:
                    Btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    Btn1.PerformClick();
                    break;
                case Keys.D1:
                    Btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    Btn2.PerformClick();
                    break;
                case Keys.D2:
                    Btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    Btn3.PerformClick();
                    break;
                case Keys.D3:
                    Btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    Btn4.PerformClick();
                    break;
                case Keys.D4:
                    Btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    Btn5.PerformClick();
                    break;
                case Keys.D5:
                    Btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    Btn6.PerformClick();
                    break;
                case Keys.D6:
                    Btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    Btn7.PerformClick();
                    break;
                case Keys.D7:
                    Btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    Btn8.PerformClick();
                    break;
                case Keys.D8:
                    Btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    Btn9.PerformClick();
                    break;
                case Keys.D9:
                    Btn9.PerformClick();
                    break;

                //Operations for clear and delete
                case Keys.Back:
                    BtnBackSpace.PerformClick();
                    break;
                case Keys.Escape:
                    BtnClear.PerformClick();
                    break;
                case Keys.Delete:
                    BtnClearEntry.PerformClick();
                    break;

                //Decimal Keys binding
                case Keys.OemPeriod:
                    BtnPoint.PerformClick();
                    break;
                case Keys.Decimal:
                    BtnPoint.PerformClick();
                    break;
            }
        }

        private void BtnDisplayText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}