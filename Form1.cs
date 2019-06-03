using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calulator
{
    public partial class Form1 : Form
    {
        private double _firstNumber;
        private double _secondNumber;
        private double _result;
        private string _operator;
        private bool _isOperator;

        public Form1()
        {
            InitializeComponent();
            LabelResult.Text = "0";
        }

        #region Logic
        private void setNumber(string number)
        {

                if (LabelResult.Text == "0")
                    LabelResult.Text = "";
                if (_isOperator)
                {
                    LabelResult.Text = "";
                    _isOperator = false;
                }
                LabelResult.Text += number;

        }
        private void setOperator(string @operator)
        {
            if (!_isOperator)
            {
                _firstNumber = Convert.ToDouble(LabelResult.Text);
                _isOperator = true;
            }
            _operator = @operator;
        }
        #endregion

        #region ButtonOperator
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            setOperator("+");
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            setOperator("-");
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            setOperator("*");
        }

        private void BtnDivided_Click(object sender, EventArgs e)
        {
            setOperator("/");
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            _secondNumber = Convert.ToDouble(LabelResult.Text);
            switch (_operator)
            {
                case "+":
                    _result = _firstNumber + _secondNumber;
                    break;
                case "-":
                    _result = _firstNumber - _secondNumber;
                    break;
                case "*":
                    _result = _firstNumber * _secondNumber;
                    break;
                case "/":
                    _result = _firstNumber / _secondNumber;
                    break;
                default:
                    break;
            }
            LabelResult.Text = _result.ToString();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (LabelResult.Text.Length > 1)
                LabelResult.Text = LabelResult.Text.Remove(LabelResult.Text.Length - 1);
            else
                LabelResult.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            LabelResult.Text = "0";
            LabelCompleteCalc.Text = "";
            _isOperator = false;
            _firstNumber = 0;
            _secondNumber = 0;
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            if (!LabelResult.Text.Contains(","))
                LabelResult.Text += ",";
        }
        #endregion

        #region ButtonNumber
        private void BtnZero_Click(object sender, EventArgs e)
        {
            setNumber("0");
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            setNumber("1");
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            setNumber("2");
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            setNumber("3");
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            setNumber("4");
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            setNumber("5");
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            setNumber("6");
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            setNumber("7");
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            setNumber("8");
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            setNumber("9");
        }

        #endregion
    }
}
