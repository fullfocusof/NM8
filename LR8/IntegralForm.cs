using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LR8
{
    public partial class IntegralForm : Form  // f(x) = (x^2 + 1)(sin (x-0,5))
    {
        int method, targetParts = 10, cntPts;
        float left, right, eps, exactResult, answer;

        List<(float, float)> tempData;
        List<float> squares;

        static Random rand;

        class PointGen
        {
            private double x, y;

            public PointGen(double xInput, double yInput)
            {
                x = xInput;
                y = yInput;
            }

            public bool isBelong()
            {
                float yFunc = getValueFunc((float)x);
                if (y <= yFunc) return true;
                else return false;
            }
        }

        static float GetRandomNumber(float minimum, float maximum)
        {
            return (float)rand.NextDouble() * (maximum - minimum) + minimum;
        }

        public IntegralForm()
        {
            InitializeComponent(); 
        }

        private void buttonRectangleMethod_Click(object sender, EventArgs e)
        {
            inputSection(1);
        }

        private void buttonTrapezMethod_Click(object sender, EventArgs e)
        {
            inputSection(2);
        }

        private void buttonParabolaMethod_Click(object sender, EventArgs e)
        {
            inputSection(3);
        }

        private void buttonMonteKarloMethod_Click(object sender, EventArgs e)
        {
            inputSection(4);
        }

        private void buttonExecInput_Click(object sender, EventArgs e)
        {
            if (method == 4)
            {
                if (textBoxLeftData.Text == string.Empty || textBoxRightData.Text == string.Empty || textBoxCntPts.Text == string.Empty)
                {
                    labelErrorInput.Visible = true;
                    return;
                }

                left = float.Parse(textBoxLeftData.Text);
                right = float.Parse(textBoxRightData.Text);
                cntPts = int.Parse(textBoxCntPts.Text);

                if (left > right)
                {
                    labelLeftData.ForeColor = Color.Red;
                    labelRightData.ForeColor = Color.Red;
                    labelErrorInput.Visible = true;
                    return;
                }
                else if (cntPts == 0)
                {
                    labelEps.ForeColor = Color.Red;
                    labelErrorInput.Visible = true;
                    return;
                }

                setResult();

                monteKarloMethod();
            }
            else
            {
                if (textBoxLeftData.Text == string.Empty || textBoxRightData.Text == string.Empty || textBoxEps.Text == string.Empty)
                {
                    labelErrorInput.Visible = true;
                    return;
                }

                left = float.Parse(textBoxLeftData.Text);
                right = float.Parse(textBoxRightData.Text);
                eps = float.Parse(textBoxEps.Text);

                if (left > right)
                {
                    labelLeftData.ForeColor = Color.Red;
                    labelRightData.ForeColor = Color.Red;
                    labelErrorInput.Visible = true;
                    return;
                }

                setResult();
                //targetParts = 1;

                if (method == 1) rectangleMethod();
                else if (method == 2) trapezMethod();
                else if (method == 3) parabolMethod();
            }   
        }

        private void methodSection()
        {
            buttonParabolaMethod.Visible = true;
            buttonRectangleMethod.Visible = true;
            buttonTrapezMethod.Visible = true;
            buttonMonteKarloMethod.Visible = true;

            labelMethod.Text = "Выберите метод интегрирования:";
            labelLeftData.Visible = false;
            labelRightData.Visible = false;
            labelEps.Visible = false;
            labelErrorInput.Visible = false;

            textBoxLeftData.Visible = false;
            textBoxRightData.Visible = false;
            textBoxEps.Visible = false;
            textBoxCntPts.Visible = false;

            buttonExecInput.Visible = false;
            buttonReturn.Visible = false;
        }

        private void inputSection(int choice)
        {
            method = choice;

            buttonParabolaMethod.Visible = false;
            buttonRectangleMethod.Visible = false;
            buttonTrapezMethod.Visible = false;
            buttonMonteKarloMethod.Visible = false;

            labelLeftData.ForeColor = Color.Black;
            labelRightData.ForeColor = Color.Black;
            labelEps.ForeColor = Color.Black;

            if (method == 4)
            {
                labelMethod.Text = "Выберите отрезок интегрирования:";

                labelLeftData.Visible = true;
                labelRightData.Visible = true;
                labelEps.Visible = true;
                labelEps.Text = "- общее количество точек";
                textBoxLeftData.Visible = true;
                textBoxRightData.Visible = true;
                textBoxCntPts.Visible = true;          
            }
            else
            {
                labelMethod.Text = "Выберите отрезок интегрирования:";

                labelLeftData.Visible = true;
                labelRightData.Visible = true;
                labelEps.Visible = true;
                labelEps.Text = "- точность";
                textBoxLeftData.Visible = true;
                textBoxRightData.Visible = true;
                textBoxEps.Visible = true;
            }
  
            buttonExecInput.Visible = true;
            buttonReturn.Visible = true;
        }

        private void textBoxLeftData_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != ',' || textBox.Text.Contains(",") || textBox.SelectionStart == 0) &&
                (e.KeyChar != '-' || textBox.Text.Contains("-") || textBox.SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        static private float getValueFunc(float x)
        {
            return (float)((Math.Pow(x, 2) + 1) * Math.Sin(x - 0.5));
        }

        static private float getValueFunc1(float x)
        {
            return (float)(-Math.Cos(x-0.5)*x*x + 2*Math.Sin(x-0.5)*x + Math.Cos(x-0.5));
        }

        private void textBoxCntPts_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            methodSection();
        }

        private void setResult()
        {
            float t1 = getValueFunc1(left);
            float t2 = getValueFunc1(right);
            exactResult = t2 - t1;
        }

        private void rectangleMethod()
        {
            float tempEps = 0.0f;

            do
            {
                tempData = new List<(float, float)>();
                squares = new List<float>();

                float step = (right - left) / targetParts;
                float x0 = (left + step + left) / 2, y0 = getValueFunc(x0);
                tempData.Add((x0, y0));

                for (int i = 0; i < targetParts - 1; i++)
                {
                    float xTemp = x0 + step;
                    float yTemp = getValueFunc(xTemp);
                    tempData.Add((xTemp, yTemp));
                    squares.Add(yTemp * step);
                    x0 = xTemp;
                }

                float tempSum = squares.Sum();
                tempEps = Math.Abs(exactResult - tempSum);

                if (tempEps > eps) targetParts *= 2;
                else answer = tempSum;

            } while (tempEps > eps);

            MessageBox.Show("Число разбиений = " + targetParts + "\nЗначение интеграла = " + answer + "\nПогрешность = " + tempEps, "Ответ");
            targetParts = 10;
        }

        private void trapezMethod()
        {
            float tempEps = 0.0f;

            do
            {
                tempData = new List<(float, float)>();

                float step = (right - left) / targetParts;
                float x0 = left, y0 = getValueFunc(x0);
                tempData.Add((x0, y0));

                for (int i = 0; i < targetParts; i++)
                {
                    float xTemp = x0 + step;
                    float yTemp = getValueFunc(xTemp);
                    tempData.Add((xTemp, yTemp));
                    x0 = xTemp;
                }

                float tempSum = 0.0f;
                for (int i = 0; i < tempData.Count; i++)
                {
                    if (i == 0 || i == tempData.Count - 1) tempSum += tempData[i].Item2 / 2;
                    else tempSum += tempData[i].Item2;
                }
                tempSum *= step;
                tempEps = Math.Abs(exactResult - tempSum);

                if (tempEps > eps) targetParts *= 2;
                else answer = tempSum;

            } while (tempEps > eps);

            MessageBox.Show("Число разбиений = " + targetParts + "\nЗначение интеграла = " + answer + "\nПогрешность = " + tempEps, "Ответ");
            targetParts = 10;
        }

        private void parabolMethod()
        {
            float tempEps = 0.0f;
            targetParts *= 2;

            do
            {
                tempData = new List<(float, float)>();

                float step = (right - left) / targetParts;
                float x0 = left, y0 = getValueFunc(x0);
                tempData.Add((x0, y0));

                for (int i = 0; i < targetParts; i++)
                {
                    float xTemp = x0 + step;
                    float yTemp = getValueFunc(xTemp);
                    tempData.Add((xTemp, yTemp));
                    x0 = xTemp;
                }

                float tempSum = 0.0f, tempSumEven = 0.0f, tempSumOdd = 0.0f;
                for (int i = 0; i < tempData.Count; i++)
                {
                    if (i == 0 || i == tempData.Count - 1) tempSum += tempData[i].Item2;
                    else if (i % 2 == 0) tempSumEven += tempData[i].Item2;
                    else if (i % 2 == 1) tempSumOdd += tempData[i].Item2;
                }
                tempSum = (tempSum + tempSumEven * 2 + tempSumOdd * 4) * step / 3;
                tempEps = Math.Abs(exactResult - tempSum) / 15;

                if (tempEps > eps) targetParts *= 2;
                else answer = tempSum;

            } while (tempEps > eps);

            MessageBox.Show("Число разбиений = " + targetParts + "\nЗначение интеграла = " + answer + "\nПогрешность = " + tempEps, "Ответ");
            targetParts = 10;
        }

        private void monteKarloMethod()
        {
            float height = getMaxY(left, right);
            float generalSquare = (right - left) * (height - 0);
            int cntBelong = 0;

            rand = new Random();
            PointGen[] ptsGen = new PointGen[cntPts];        
            for (int i = 0; i < cntPts; i++)
            {
                PointGen p = new PointGen(GetRandomNumber(left, right), GetRandomNumber(0, height));
                ptsGen[i] = p;
            }
            for (int i = 0; i < cntPts; i++)
            {
                PointGen pTemp = ptsGen[i];
                if (pTemp.isBelong()) cntBelong++;
            }

            answer = generalSquare * cntBelong / cntPts;
            MessageBox.Show("Значение интеграла = " + answer + "\nКоличество точек под графиком = " + cntBelong + "\nОбщее количество точек = " + cntPts, "Ответ");
        }

        private float getMaxY(float left, float right)
        {
            float result = float.MinValue;
            while (left < right)
            {
                float yTemp = getValueFunc(left);
                if (yTemp > result) result = yTemp;
                left += 0.01f;
            }

            return result;
        }

        private float getMinY(float left, float right)
        {
            float result = float.MaxValue;
            while (left < right)
            {
                float yTemp = getValueFunc(left);
                if (yTemp < result) result = yTemp;
                left += 0.01f;
            }

            return result;
        }
        
    }
}
