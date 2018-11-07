using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Application
{   
    /// <summary>
    /// This class represents full code of Windows Form Application
    /// </summary>
    public partial class Form1 : Form
    {
        // Variables for calculating points og graphs
        private double x0 = 0.0, y0 = 1.0, xF = 9.5, h = 0.1;

        // Variables for presenting total approximation with steps from n0 to nF
        private int n0 = 10, nF = 1001;

        // Lists for containing points of different graphs
        List<double> xPoints;
        List<double> yEulerPoints;

        List<double> yImEulerPoints;

        List<double> yRungePoints;

        List<double> yAnSolutionPoints;

        List<double> yEulerErrorPoints;

        List<double> yImEulerErrorPoints;

        List<double> yRungeErrorPoints;

        List<double> xEulerTotalErrorPoints;
        List<double> yEulerTotalErrorPoints;

        List<double> xImEulerTotalErrorPoints;
        List<double> yImEulerTotalErrorPoints;

        List<double> xRungeTotalErrorPoints;
        List<double> yRungeTotalErrorPoints;

        // booleaan variable is used to know if funct has already been calculated
        bool not_calculated = true;

        // Initialization of Windows Form Application
        public Form1()
        {
            InitializeComponent();
        }

        // On loading the application our initial values (variant) should be presented in textboxes
        private void Form1_Load(object sender, EventArgs e)
        {
            InitXtextbox.Text = x0.ToString();
            IninYtextbox.Text = y0.ToString();
            FinalXtextbox.Text = xF.ToString();
            StepHtextbox.Text = h.ToString();
            NumOfSteps1.Text = n0.ToString();
            NumOfSteps2.Text = nF.ToString();
        }

        // Button exit
        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // Generation button
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            // Each textbox must be filled
            if (InitXtextbox.Text.Length == 0 || IninYtextbox.Text.Length == 0 || FinalXtextbox.Text.Length == 0 || StepHtextbox.Text.Length == 0)
            {
                string message = "Sorry, but you did not enter any number in one of TEXTBOX.";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                return;
            }
            else
            {
                // Format of input must be acceptable in order to convert it into double
                try
                {
                    x0 = Double.Parse(InitXtextbox.Text);
                    y0 = Double.Parse(IninYtextbox.Text);
                    xF = Double.Parse(FinalXtextbox.Text);
                    h = Double.Parse(StepHtextbox.Text);
                    n0 = Int32.Parse(NumOfSteps1.Text);
                    nF = Int32.Parse(NumOfSteps2.Text);

                    // Step and number of steps must be greater than 0
                    if (h <= 0 || n0 <= 0 || nF <= 0)
                    {
                        string message = "Sorry, Step or number of Steps cannot be equal to 0 or negative. Now h = 0.01";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        h = 0.01;
                        StepHtextbox.Text = h.ToString();
                    }

                    // Initial X must not be greater than Final X
                    if (xF < x0)
                    {
                        string message = "Sorry, Initial X cannot be bigger than Final X";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        return;
                    }

                    // Initial number of steps must not be greater than Final number of steps
                    if (nF < n0)
                    {
                        string message = "Sorry, Initial N cannot be bigger than Final N";
                        string caption = "Error Detected in Input";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        return;
                    }

                    // if new arguments accepted, we must calculate points again
                    not_calculated = true;
                }
                catch (FormatException)
                {
                    string message = "Sorry, but you entered wrong format into TEXTBOX. (In real numbers use symbol ',')";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                    return;
                }
            }

            if (not_calculated)
            {
                FunctCalculation();
            }

            // Bind point into the graphs
            GraphOfMethods.Series["Euler"].Points.DataBindXY(xPoints, yEulerPoints);
            GraphOfErrors.Series["Euler"].Points.DataBindXY(xPoints, yEulerErrorPoints);
            GraphOfTotalErrors.Series["Euler"].Points.DataBindXY(xEulerTotalErrorPoints, yEulerTotalErrorPoints);

            GraphOfMethods.Series["Improved Euler"].Points.DataBindXY(xPoints, yImEulerPoints);
            GraphOfErrors.Series["Improved Euler"].Points.DataBindXY(xPoints, yImEulerErrorPoints);
            GraphOfTotalErrors.Series["Improved Euler"].Points.DataBindXY(xImEulerTotalErrorPoints, yImEulerTotalErrorPoints);

            GraphOfMethods.Series["Runge-Kuffa"].Points.DataBindXY(xPoints, yRungePoints);
            GraphOfErrors.Series["Runge-Kuffa"].Points.DataBindXY(xPoints, yRungeErrorPoints);
            GraphOfTotalErrors.Series["Runge-Kuffa"].Points.DataBindXY(xRungeTotalErrorPoints, yRungeTotalErrorPoints);

            GraphOfMethods.Series["Analytical Solution"].Points.DataBindXY(xPoints, yAnSolutionPoints);

            // Create Table with Name raw
            DataTable dt = new DataTable();
            dt.Columns.Add("x");
            dt.Columns.Add("Euler y");
            dt.Columns.Add("ImEuler y");
            dt.Columns.Add("Runge y");
            dt.Columns.Add("Analytical Solution");
            dt.Columns.Add("Euler Error");
            dt.Columns.Add("ImEuler Error");
            dt.Columns.Add("Runge Error");
            for (int i = 0; i < xPoints.Count || i < xPoints.Count || i < xPoints.Count; i++)
            {
                // create new raw with points, and then add it to the table
                DataRow r = dt.NewRow();
                r["x"] = x0 + i * h;
                r["Euler y"] = yEulerPoints[i];
                r["ImEuler y"] = yImEulerPoints[i];
                r["Runge y"] = yRungePoints[i];
                r["Analytical Solution"] = yAnSolutionPoints[i];
                r["Euler Error"] = yEulerErrorPoints[i];
                r["ImEuler Error"] = yImEulerErrorPoints[i];
                r["Runge Error"] = yRungeErrorPoints[i];

                dt.Rows.Add(r);
            }

            // 4 objects exist on the same coordinates. Different buttons make different objects to be visible
            DataTable.DataSource = dt;
            DataTable.Visible = false;
            GraphOfMethods.Visible = true;
            GraphOfErrors.Visible = false;
            GraphOfTotalErrors.Visible = false;
        }

        private void TotalErrorButton_Click(object sender, EventArgs e)
        {
            // 4 objects exist on the same coordinates. Different buttons make different objects to be visible
            DataTable.Visible = false;
            GraphOfMethods.Visible = false;
            GraphOfErrors.Visible = false;
            GraphOfTotalErrors.Visible = true;
        }

        private void LocalErrorButton_Click(object sender, EventArgs e)
        {
            // 4 objects exist on the same coordinates. Different buttons make different objects to be visible
            DataTable.Visible = false;
            GraphOfMethods.Visible = false;
            GraphOfErrors.Visible = true;
            GraphOfTotalErrors.Visible = false;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            // 4 objects exist on the same coordinates. Different buttons make different objects to be visible
            DataTable.Visible = true;
            GraphOfMethods.Visible = false;
            GraphOfErrors.Visible = false;
            GraphOfTotalErrors.Visible = false;
        }

        // Needed methods for constructor of application
        private void InitXtextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void IninYtextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void FinalXtextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void StepHtextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumOfSteps1_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumOfSteps2_TextChanged(object sender, EventArgs e)
        {

        }
        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // This function create list for xPoints that are used in order to find Y values for each graph
        private void FunctCalculation()
        {

            xPoints = new List<double>();
            for (double x = x0; x <= xF; x += h)
                xPoints.Add(Math.Round(x, 10));

            yEulerPoints = new List<double>();
            yEulerPoints = EulerSol(xPoints, h, y0);

            yImEulerPoints = new List<double>();
            yImEulerPoints = ImprovedEuler(xPoints, h, y0);

            yRungePoints = new List<double>();
            yRungePoints = RungeKuffaSol(xPoints, h, y0);

            yAnSolutionPoints = new List<double>();
            yAnSolutionPoints = AnalyticalSol(xPoints, h, y0, x0);

            yEulerErrorPoints = new List<double>();
            yEulerErrorPoints = EulerErrorSol(yAnSolutionPoints, yEulerPoints, xPoints);

            yImEulerErrorPoints = new List<double>();
            yImEulerErrorPoints = ImEulerErrorSol(yAnSolutionPoints, yImEulerPoints, xPoints);

            yRungeErrorPoints = new List<double>();
            yRungeErrorPoints = RungeErrorSol(yAnSolutionPoints, yRungePoints, xPoints);

            xEulerTotalErrorPoints = new List<double>();
            yEulerTotalErrorPoints = new List<double>();

            xImEulerTotalErrorPoints = new List<double>();
            yImEulerTotalErrorPoints = new List<double>();

            xRungeTotalErrorPoints = new List<double>();
            yRungeTotalErrorPoints = new List<double>();



            EulerTotalErrorSol(xF, x0);
            ImEulerTotalErrorSol(xF, x0);
            RungeTotalError(xF, x0);

            not_calculated = false;
        }

        // Method for each algorithm
        private void EulerTotalErrorSol(double finalX, double initX)
        {
            double n, step;

            for (n = n0; n < nF; n += 10)
            {
                step = (finalX - initX) / n;
                List<double> xList = new List<double>();
                List<double> yList1 = new List<double>();
                List<double> yList2 = new List<double>();
                if (step == 0)
                    xList.Add(initX);
                else
                    for (double x = initX; x <= finalX; x += step)
                        xList.Add(x);

                yList1 = EulerSol(xList, step, y0);
                yList2 = AnalyticalSol(xList, step, y0, x0);
                xEulerTotalErrorPoints.Add(n);
                yEulerTotalErrorPoints.Add(Math.Round(findMaxDifference(yList1, yList2), 10));
            }
        }
        private void ImEulerTotalErrorSol(double finalX, double initX)
        {
            double n, step;

            for (n = n0; n < nF; n += 10)
            {
                step = (finalX - initX) / n;
                List<double> xList = new List<double>();
                List<double> yList1 = new List<double>();
                List<double> yList2 = new List<double>();
                if (step == 0)
                    xList.Add(initX);
                else
                    for (double x = initX; x <= finalX; x += step)
                        xList.Add(x);

                yList1 = ImprovedEuler(xList, step, y0);
                yList2 = AnalyticalSol(xList, step, y0, x0);
                xImEulerTotalErrorPoints.Add(n);
                yImEulerTotalErrorPoints.Add(Math.Round(findMaxDifference(yList1, yList2), 10));
            }
        }
        private void RungeTotalError(double finalX, double initX)
        {
            double n, step;

            for (n = n0; n < nF; n += 10)
            {
                step = (finalX - initX) / n;
                List<double> xList = new List<double>();
                List<double> yList1 = new List<double>();
                List<double> yList2 = new List<double>();
                if (step == 0)
                    xList.Add(initX);
                else
                    for (double x = initX; x <= finalX; x += step)
                        xList.Add(x);

                yList1 = RungeKuffaSol(xList, step, y0);
                yList2 = AnalyticalSol(xList, step, y0, x0);
                xRungeTotalErrorPoints.Add(n);
                yRungeTotalErrorPoints.Add(Math.Round(findMaxDifference(yList1, yList2), 10));
            }
        }
        private List<double> EulerErrorSol(List<double> yInputAn, List<double> yInputEu, List<double> xInput)
        {
            double y = 0;
            List<double> yValues = new List<double>();
            for (int i = 0; i < xInput.Count; i++)
            {
                y = Math.Abs(yInputAn[i] - yInputEu[i]);
                yValues.Add(y);
            }

            return yValues;
        }
        private List<double> ImEulerErrorSol(List<double> yInputAn, List<double> yInputImEu, List<double> xInput)
        {
            double y = 0;
            List<double> yValues = new List<double>();
            for (int i = 0; i < xInput.Count; i++)
            {
                y = Math.Abs(yInputAn[i] - yInputImEu[i]);
                yValues.Add(y);
            }

            return yValues;
        }
        private List<double> RungeErrorSol(List<double> yInputAn, List<double> yInputRun, List<double> xInput)
        {
            double y = 0;
            List<double> yValues = new List<double>();
            for (int i = 0; i < xInput.Count; i++)
            {
                y = Math.Abs(yInputAn[i] - yInputRun[i]);
                yValues.Add(y);
            }

            return yValues;
        }
        private List<double> EulerSol(List<double> xValues, double step, double initY)
        {
            double y = initY;
            List<double> yValues = new List<double>();
            yValues.Add(y);
            for (int i = 1; i < xValues.Count; i++)
            {
                y = yValues[i - 1] + step * deFunct(xValues[i - 1], yValues[i - 1]);
                yValues.Add(Math.Round(y, 10));
            }
            return yValues;
        }
        private List<double> ImprovedEuler(List<double> xValues, double step, double initY)
        {
            double y = initY;
            List<double> yValues = new List<double>();
            yValues.Add(y);
            for (int i = 1; i < xValues.Count; i++)
            {
                y = yValues[i - 1] + step * deFunct(xValues[i - 1] + step / 2, yValues[i - 1] + (step / 2) * deFunct(xValues[i - 1], yValues[i - 1]));
                //y = yValues[i - 1] + (step / 2) * (deFunct(xValues[i - 1], yValues[i - 1]) + deFunct(xValues[i], yValues[i - 1] + step * deFunct(xValues[i - 1], yValues[i - 1])));
                yValues.Add(Math.Round(y, 10));
            }

            return yValues;
        }
        private List<double> RungeKuffaSol(List<double> xValues, double step, double initY)
        {
            double y = initY;
            List<double> yValues = new List<double>();
            yValues.Add(y);
            double k1, k2, k3, k4;
            for (int i = 1; i < xValues.Count; i++)
            {
                k1 = deFunct(xValues[i - 1], yValues[i - 1]);
                k2 = deFunct(xValues[i - 1] + step / 2, yValues[i - 1] + (step * k1) / 2);
                k3 = deFunct(xValues[i - 1] + step / 2, yValues[i - 1] + (step * k2) / 2);
                k4 = deFunct(xValues[i - 1] + step, yValues[i - 1] + step * k3);
                y = yValues[i - 1] + (step / 6) * (k1 + 2 * k2 + 2 * k3 + k4);

                yValues.Add(Math.Round(y, 10));
            }

            return yValues;
        }
        private List<double> AnalyticalSol(List<double> xValues, double step, double initY, double initX)
        {
            double y = initY;
            List<double> yValues = new List<double>();
            yValues.Add(y);
            double c = (initY * 2 - Math.Sin(initX) - Math.Cos(initX)) * Math.Exp(initX) / 2;
            for (int i = 1; i < xValues.Count; i++)
            {
                y = c / Math.Exp(xValues[i]) + Math.Sin(xValues[i]) / 2 + Math.Cos(xValues[i]) / 2;
                yValues.Add(Math.Round(y, 10));
            }

            return yValues;
        }

        // Function in variant
        private double deFunct(double x, double y)
        {
            return Math.Cos(x) - y;
        }

        // Helping funct for total approximation
        public double findMaxDifference(List<double> first, List<double> second)
        {
            double max = 0;
            int n = (first.Count <= second.Count) ? first.Count : second.Count;
            for (int i = 0; i < n; i++)
            {
                max = (max > Math.Abs(first[i] - second[i])) ? max : Math.Abs(first[i] - second[i]);
            }
            return max;
        }
    }
}
