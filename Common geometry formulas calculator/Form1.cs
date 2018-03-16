using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common_geometry_formulas_calculator
{
    public partial class fromCalculator : Form
    {
        public fromCalculator()
        {
            InitializeComponent();
        }

        //Variables to hold radiobuttons
        RadioButton type = null;
        RadioButton shape = null;

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            if (btnCalculate.Text == "Answer")
            {
                if (type != null)
                {
                    
                    string getType = type.Name.ToString(); //Gets the type and shape of the clicked radio button
                    getType = getType.Substring(2);

                    switch (getType) //Switch statement to access the correct method
                    {
                        case "Area":
                            string getShape = shape.Name.ToString();
                            getShape = getShape.Substring(2);

                            double area = calculateArea(getShape);
                            if (area != 0)
                            {
                                rtxtResult.Text = "AREA: " + area.ToString("F");
                            }
                            break;

                        case "Parimeter":
                            getShape = shape.Name.ToString();
                            getShape = getShape.Substring(2);

                            double parimeter = calculatePerimeter(getShape);
                            if (parimeter != 0)
                            {
                                rtxtResult.Text = "PARIMETER: " + parimeter.ToString("F");
                            }
                            break;

                        case "AreaParimeter":
                            getShape = shape.Name.ToString();
                            getShape = getShape.Substring(2);

                            area = calculateArea(getShape);
                        
                            if (area != 0)
                            {
                                parimeter = calculatePerimeter(getShape);
                                if (parimeter != 0)
                                {
                                    rtxtResult.Text = "AREA: " + area.ToString("F") + "\n" + "PARIMETER: " + parimeter.ToString("F");
                                }
                            }
                            break;

                        case "Remainder":
                            double remainder = calculateRemainder();
                            rtxtResult.Text = "Remainder: " + remainder.ToString("F");
                            break;

                        case "Percentage":
                            double percent = calculatePercentage();
                            rtxtResult.Text = "Percent: " + percent.ToString("F");
                            break;

                        case "SquareRoot":
                            double root = calculateSquareRoot();
                            rtxtResult.Text = "Square Root: " + root.ToString();
                            break;
                }

                }
                
            }

            if (type.Name == "rbPercentage" || type.Name == "rbRemainder" || type.Name == "rbSquareRoot")
            {
                btnCalculate.Text = "Answer";

                switch (type.Name)
                {
                    case "rbPercentage":
                        lblOperand1.Visible = true;
                        lblOperand2.Visible = true;
                        lblOperand1.Text = "Percentage";

                        txtOperand1.Visible = true;
                        txtOperand2.Visible = true;
                        break;

                    case "rbRemainder":
                        lblOperand1.Visible = true;
                        lblOperand2.Visible = true;
                        lblOperand1.Text = "Operand 1";

                        txtOperand1.Visible = true;
                        txtOperand2.Visible = true;
                        break;

                    case "rbSquareRoot":
                        lblOperand1.Text = "Operand 1";
                        lblOperand1.Visible = true;
                        txtOperand1.Visible = true;
                        break;
                }
            }

            bool typeChecked = isTypeChecked(); //Validation to make sure both type and shape are checked before changing btn to answer
            bool shapeChecked = isShapeChecked();

            if (typeChecked && shapeChecked)
            {
                btnCalculate.Text = "Answer";

                switch (type.Name)
                {
                    case "rbArea":
                        switch (shape.Name)
                        {
                            case "rbCircle":
                                lblARadius.Visible = true; //Sets corrisponding lbls visible

                                txtARadius.Visible = true;// Sets corrisponding txt boxes visible
                                break;

                            case "rbTrapezoid":
                                lblABase1.Visible = true;
                                lblABase2.Visible = true;
                                lblAHeight.Visible = true;

                                txtABase1.Visible = true;
                                txtABase2.Visible = true;
                                txtAHeight.Visible = true;
                                break;

                            case "rbRectangle":
                                lblALength.Visible = true;
                                lblAWidth.Visible = true;

                                txtALength.Visible = true;
                                txtAWidth.Visible = true;
                                break;

                            case "rbSquare":
                                lblASide1.Visible = true;

                                txtASide1.Visible = true;
                                break;

                            case "rbParallelogram":
                            case "rbTriangle":
                            case "rbRhombus":
                                lblABase1.Visible = true;
                                lblAHeight.Visible = true;

                                txtABase1.Visible = true;
                                txtAHeight.Visible = true;
                                break;
                        }
                        break;

                    case "rbParimeter":
                        switch (shape.Name)
                        {
                            case "rbCircle":
                                lblPRadius.Visible = true; //Sets corrisponding lbls visible

                                txtPRadius.Visible = true;// Sets corrisponding txt boxes visible
                                break;

                            case "rbRectangle":
                                lblPLength.Visible = true;
                                lblPWidth.Visible = true;

                                txtPLength.Visible = true;
                                txtPWidth.Visible = true;
                                break;

                            case "rbRhombus":
                            case "rbSquare":
                                lblPSide1.Visible = true;

                                txtPSide1.Visible = true;
                                break;

                            case "rbParallelogram":
                                lblPBase1.Visible = true;
                                lblPSide1.Visible = true;

                                txtPBase1.Visible = true;
                                txtPSide1.Visible = true;
                                break;

                            case "rbTriangle":
                                lblPSide1.Visible = true;
                                lblPSide2.Visible = true;
                                lblPBase1.Visible = true;

                                txtPSide1.Visible = true;
                                txtPSide2.Visible = true;
                                txtPBase1.Visible = true;
                                break;

                            case "rbTrapezoid":
                                lblPSide1.Visible = true;
                                lblPSide2.Visible = true;
                                lblPBase1.Visible = true;
                                lblPBase2.Visible = true;

                                txtPSide1.Visible = true;
                                txtPSide2.Visible = true;
                                txtPBase1.Visible = true;
                                txtPBase2.Visible = true;
                                break;
                        }
                        break;

                    case "rbAreaParimeter":
                        switch (shape.Name)
                        {
                            case "rbCircle":
                                lblPRadius.Visible = true; //Sets corrisponding lbls visible
                                lblARadius.Visible = true;

                                txtARadius.Visible = true;// Sets corrisponding txt boxes visible
                                txtPRadius.Visible = true;
                                break;

                            case "rbRectangle":
                                lblPLength.Visible = true;
                                lblPWidth.Visible = true;
                                lblALength.Visible = true;
                                lblAWidth.Visible = true;

                                txtALength.Visible = true;
                                txtAWidth.Visible = true;
                                txtPLength.Visible = true;
                                txtPWidth.Visible = true;
                                break;

                            case "rbRhombus":
                                lblABase1.Visible = true;
                                lblAHeight.Visible = true;
                                lblPSide1.Visible = true;

                                txtPSide1.Visible = true;
                                txtABase1.Visible = true;
                                txtAHeight.Visible = true;
                                break;

                            case "rbSquare":
                                lblPSide1.Visible = true;
                                lblASide1.Visible = true;
                                txtASide1.Visible = true;
                                txtPSide1.Visible = true;
                                break;

                            case "rbParallelogram":
                                lblPBase1.Visible = true;
                                lblPSide1.Visible = true;
                                lblPBase1.Visible = true;
                                lblPSide1.Visible = true;
                                lblABase1.Visible = true;
                                lblAHeight.Visible = true;

                                txtABase1.Visible = true;
                                txtAHeight.Visible = true;
                                txtPBase1.Visible = true;
                                txtPSide1.Visible = true;
                                txtPBase1.Visible = true;
                                txtPSide1.Visible = true;
                                break;

                            case "rbTriangle":
                                lblPSide1.Visible = true;
                                lblPSide2.Visible = true;
                                lblPBase1.Visible = true;
                                lblABase1.Visible = true;
                                lblAHeight.Visible = true;

                                txtABase1.Visible = true;
                                txtAHeight.Visible = true;
                                txtPSide1.Visible = true;
                                txtPSide2.Visible = true;
                                txtPBase1.Visible = true;
                                break;

                            case "rbTrapezoid":
                                lblPSide1.Visible = true;
                                lblPSide2.Visible = true;
                                lblPBase1.Visible = true;
                                lblPBase2.Visible = true;
                                lblABase1.Visible = true;
                                lblABase2.Visible = true;
                                lblAHeight.Visible = true;

                                txtABase1.Visible = true;
                                txtABase2.Visible = true;
                                txtAHeight.Visible = true;

                                txtPSide1.Visible = true;
                                txtPSide2.Visible = true;
                                txtPBase1.Visible = true;
                                txtPBase2.Visible = true;
                                break;
                        }
                        break;
                }
            }
        }

        private void radioButtonType_Click(object sender, EventArgs e) //Event that enables the shape radio buttons after a type radio button is chosen
        {
            type = sender as RadioButton;
            
            rbCircle.Visible = true;
            rbParallelogram.Visible = true;
            rbRectangle.Visible = true;
            rbRhombus.Visible = true;
            rbSquare.Visible = true;
            rbTrapezoid.Visible = true;
            rbTriangle.Visible = true;
        }

        private void radioButtonResetType_click(object sender, EventArgs e) //Event that enables the percentage, remainder, and square root radio buttons
        {
            type = sender as RadioButton;

            rbCircle.Visible = false;
            rbParallelogram.Visible = false;
            rbRectangle.Visible = false;
            rbRhombus.Visible = false;
            rbSquare.Visible = false;
            rbTrapezoid.Visible = false;
            rbTriangle.Visible = false;
        }

        private void radioButtonShape_Click(object sender, EventArgs e) //Assigns the global variable to the clicked radio button
        {
            shape = sender as RadioButton;
        }


        private double calculatePerimeter(string shape) //Calculates the parimter and returns
        {
            try
            {
                double parimeter = 0;

            switch (shape) //Uses a switch statement to get the correct shape
                {
   
                case "Rectangle":
                    if(isValidData(txtPLength, "Length") && isValidData(txtPWidth, "Width")) //Validates data for empty string, is a double, and greater than 0
                        {
                        double length = Convert.ToDouble(txtPLength.Text);
                        double width = Convert.ToDouble(txtPWidth.Text);
                        parimeter = 2 * (length + width);
                    }
                    break;

                case "Parallelogram":
                    if (isValidData(txtPBase1, "Base 1") && isValidData(txtPSide1, "Side 1"))
                    {
                        double Base = Convert.ToDouble(txtPBase1.Text);
                        double side = Convert.ToDouble(txtPSide1.Text);
                        parimeter = 2 * (Base + side);
                    }
                    break;

                case "Square":
                case "Rhombus":
                    if (isValidData(txtPSide1, "Side 1"))
                    {
                        double side = Convert.ToDouble(txtPSide1.Text);
                        parimeter = 4 * side;
                    }
                    break;

                case "Triangle":
                    if (isValidData(txtPSide1, "Side 1") && isValidData(txtPBase1, "Base 1") && isValidData(txtPSide2, "Side 2"))
                    {
                        double side = Convert.ToDouble(txtPSide1.Text);
                        double Base = Convert.ToDouble(txtPBase1.Text);
                        double side2 = Convert.ToDouble(txtPSide2.Text);
                        parimeter = side + Base + side2;
                    }

                    break;

                case "Circle":
                    if (isValidData(txtPRadius, "Radius"))
                    {
                        double radius = Convert.ToDouble(txtPRadius.Text);
                        double pi = Math.PI;
                        parimeter = 2 * pi * radius;
                    }
                    break;

                case "Trapezoid":
                    if (isValidData(txtPSide1, "Side 1") && isValidData(txtPBase1, "Base 1") && isValidData(txtPSide2, "Side 2") && isValidData(txtPBase2, "Base 2"))
                    {
                        double Base = Convert.ToDouble(txtPBase1.Text);
                        double base2 = Convert.ToDouble(txtPBase2.Text);
                        double side = Convert.ToDouble(txtPSide1.Text);
                        double side2 = Convert.ToDouble(txtPSide2.Text);
                        parimeter = Base + base2 + side + side2;
                    }
                    break;
            }
            return parimeter;

            } catch (OverflowException ofe) //Just in case theres a extreamly large number
            {
                MessageBox.Show("Enter in smaller numbers", "ERROR");
                return 0;
            } catch (Exception) //Catch all exception
            {
                MessageBox.Show("A exception has occured", "ERROR");
                return 0;
            }
            
        }

        private double calculateSquareRoot()
        {
            try
            {
                if (isValidData(txtOperand1, "Operand 1"))
                {
                    double root = 0;
                    double operand1 = Convert.ToDouble(txtOperand1.Text);
                    root = Math.Sqrt(operand1);
                    return root;
                }
                return 0;
            }
            catch (OverflowException ofe)
            {
                MessageBox.Show("Enter in smaller numbers", "ERROR");
                return 0;
            }
            catch (Exception) //Catch all exception
            {
                MessageBox.Show("A exception has occured", "ERROR");
                return 0;
            }
        }

        private double calculatePercentage()
        {
            try
            {
                if (isValidData(txtOperand1, "Operand 1") && isValidData(txtOperand2, "Operand 2"))
                {
                    double percent = 0;
                    double operand1 = Convert.ToDouble(txtOperand1.Text);
                    double operand2 = Convert.ToDouble(txtOperand2.Text);
                    operand1 /= 100;
                    percent = operand1 * operand2;
                    return percent;
                }
                return 0;
            }
            catch (OverflowException ofe)
            {
                MessageBox.Show("Enter in smaller numbers", "ERROR");
                return 0;
            }
            catch (DivideByZeroException dbze)
            {
                MessageBox.Show("Cant have 0 percent", "ERROR");
                return 0;
            }
            catch (Exception) //Catch all exception
            {
                MessageBox.Show("A exception has occured", "ERROR");
                return 0;
            }
        }

        private double calculateRemainder()
        {
            try
            {
                if (isValidData(txtOperand1, "Operand 1") && isValidData(txtOperand2, "Operand 2"))
                {
                    double remainder = 0;
                    double operand1 = Convert.ToDouble(txtOperand1.Text);
                    double operand2 = Convert.ToDouble(txtOperand2.Text);

                    remainder = operand1 % operand2;

                    return remainder;
                }
                return 0;
 
            }
            catch (OverflowException ofe)
            {
                MessageBox.Show("Enter in smaller numbers", "ERROR");
                return 0;
            }
            catch (Exception) //Catch all exception
            {
                MessageBox.Show("A exception has occured", "ERROR");
                return 0;
            }
        }

        private double calculateArea(string shape) //Calculates area and returns
        {
            try
            {
                double area = 0;

            switch (shape) //Uses a switch statement to calculate area for the proper shape
            {
                case "Rhombus":
                case "Parallelogram":
                    if (isValidData(txtABase1, "Base 1") && isValidData(txtAHeight, "Height")) { //Validates data for empty string, is a double, and greater than 0
                        double Base = Convert.ToDouble(txtABase1.Text);
                        double height = Convert.ToDouble(txtAHeight.Text);
                        area = Base * height;
                    }
                    break;

                case "Rectangle":
                    if (isValidData(txtALength, "Length") && isValidData(txtAWidth, "Width")) {
                        double length = Convert.ToDouble(txtALength.Text);
                        double width = Convert.ToDouble(txtAWidth.Text);
                        area = length * width;
                    }
                    break;
                    
                case "Triangle":
                    if(isValidData(txtABase1, "Base 1") && isValidData(txtAHeight, "Height")) {
                        double Base = Convert.ToDouble(txtABase1.Text);
                        double height = Convert.ToDouble(txtAHeight.Text);
                        area = (Base * height) / 2;
                    }
                    break;

                case "Square":
                    if (isValidData(txtASide1, "Side 1"))
                    {
                        double side = Convert.ToDouble(txtASide1.Text);
                        area = side * side;
                    }
                    break;

                case "Circle":
                    if (isValidData(txtARadius, "Radius"))
                    {
                        double radius = Convert.ToDouble(txtARadius.Text);
                        double pi = Math.PI;
                        area = pi * (radius * radius);
                    }
                    break;

                case "Trapezoid":
                    if (isValidData(txtABase1, "Base 1") && isValidData(txtAHeight, "Height") && 
                        isValidData(txtABase2, "Base 2"))
                    {
                        double Base = Convert.ToDouble(txtABase1.Text);
                        double height = Convert.ToDouble(txtAHeight.Text);
                        double base2 = Convert.ToDouble(txtABase2.Text);
                        area = (Base + base2) / 2 * height;
                    }
                    break;
            }

            return area;

            }
            catch (OverflowException ofe)
            {
                MessageBox.Show("Enter in smaller numbers", "ERROR");
                return 0;
            }
            catch (Exception) //Catch all exception
            {
                MessageBox.Show("A exception has occured", "ERROR");
                return 0;
            }
        }

        //Checks to see if the type group has a checked radio button
        private bool isTypeChecked()
        {
            foreach (RadioButton rb in gbType.Controls.OfType<RadioButton>()) //For loop that checks each radio button in the group to see if its checked
            {
                if (rb.Checked)
                {
                    return true; //Returns true if theres a checked radio button
                }
            }
            return false;

        }
        
        //Checks to see if the shape group has a checked radio button
        private bool isShapeChecked()
        {
            foreach (RadioButton rb in gbShapes.Controls.OfType<RadioButton>()) //For loop that checks each radio button in the group to see if its checked
            {
                if (rb.Checked)
                {
                    return true; //Returns true if theres a checked radio button
                }
            }
            return false;
        }
       
        //Clears values and resets visabity if something is changed
        private void clearFutureValues(object sender, EventArgs e)
        {
            lblABase1.Visible = false;
            lblABase2.Visible = false;
            lblALength.Visible = false;
            lblASide1.Visible = false;
            lblASide2.Visible = false;
            lblAWidth.Visible = false;
            lblAHeight.Visible = false;
            lblARadius.Visible = false;

            lblPBase1.Visible = false;
            lblPBase2.Visible = false;
            lblPLength.Visible = false;
            lblPSide1.Visible = false;
            lblPSide2.Visible = false;
            lblPWidth.Visible = false;
            lblPHeight.Visible = false;
            lblPRadius.Visible = false;

            lblOperand1.Visible = false;
            lblOperand2.Visible = false;

            txtABase1.Visible = false;
            txtABase2.Visible = false;
            txtALength.Visible = false;
            txtASide1.Visible = false;
            txtASide2.Visible = false;
            txtAWidth.Visible = false;
            txtAHeight.Visible = false;
            txtARadius.Visible = false;

            txtPBase1.Visible = false;
            txtPBase2.Visible = false;
            txtPLength.Visible = false;
            txtPSide1.Visible = false;
            txtPSide2.Visible = false;
            txtPWidth.Visible = false;
            txtPHeight.Visible = false;
            txtPRadius.Visible = false;

            txtOperand1.Visible = false;
            txtOperand2.Visible = false;

            txtABase1.Clear();
            txtABase2.Clear();
            txtALength.Clear();
            txtASide1.Clear();
            txtASide2.Clear();
            txtAWidth.Clear();
            txtAHeight.Clear();
            txtARadius.Clear();

            txtPBase1.Clear();
            txtPBase2.Clear();
            txtPLength.Clear();
            txtPSide1.Clear();
            txtPSide2.Clear();
            txtPWidth.Clear();
            txtPHeight.Clear();
            txtPRadius.Clear();

            txtOperand1.Clear();
            txtOperand2.Clear();

            rtxtResult.Clear();

            btnCalculate.Text = "Calculate";
        }

        //Closes program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clears txt field values
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtABase1.Clear();
            txtABase2.Clear();
            txtALength.Clear();
            txtASide1.Clear();
            txtASide2.Clear();
            txtAWidth.Clear();
            txtAHeight.Clear();
            txtARadius.Clear();

            txtPBase1.Clear();
            txtPBase2.Clear();
            txtPLength.Clear();
            txtPSide1.Clear();
            txtPSide2.Clear();
            txtPWidth.Clear();
            txtPHeight.Clear();
            txtPRadius.Clear();

            txtOperand1.Clear();
            txtOperand2.Clear();

            rtxtResult.Clear();
        }

        private void clearResults(object sender, EventArgs e)
        {
            rtxtResult.Clear();
        }

        private bool isPresent(TextBox txtbox, string name)
        {
            if (txtbox.Text == "")
            {
                MessageBox.Show(name + " is an required field.", "Entry Error");
                txtbox.Focus();
                return false;
            }
            return true;
        }

        //Checks to see if input is a decimal number
        private bool isDouble(TextBox txtbox, string name)
        {
            Double number = 0;
            if (Double.TryParse(txtbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                txtbox.Focus();
                return false;
            }
        }

        //Checks to see if input is within range
        private bool isInRange(TextBox txtbox, string name, int min)
        {
            Double number = Convert.ToDouble(txtbox.Text);

            if (number < min )
            {
                MessageBox.Show(name + " must be more than " + min.ToString() +
                     ".", "Entry Error");
                return false;
            }
            return true;
        }

        private bool isValidData(TextBox txtbox, string name)
        {
            return
                isPresent(txtbox, name) &&
                isDouble(txtbox, name) &&
                isInRange(txtbox, name, 0);
        }
    }
}
