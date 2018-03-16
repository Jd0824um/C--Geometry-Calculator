namespace Common_geometry_formulas_calculator
{
    partial class fromCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbRhombus = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbParallelogram = new System.Windows.Forms.RadioButton();
            this.rbTrapezoid = new System.Windows.Forms.RadioButton();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.rbParimeter = new System.Windows.Forms.RadioButton();
            this.rbAreaParimeter = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.gbShapes = new System.Windows.Forms.GroupBox();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPLength = new System.Windows.Forms.Label();
            this.lblPWidth = new System.Windows.Forms.Label();
            this.lblPBase1 = new System.Windows.Forms.Label();
            this.lblPBase2 = new System.Windows.Forms.Label();
            this.txtPBase2 = new System.Windows.Forms.TextBox();
            this.txtPBase1 = new System.Windows.Forms.TextBox();
            this.txtPWidth = new System.Windows.Forms.TextBox();
            this.txtPLength = new System.Windows.Forms.TextBox();
            this.lblABase2 = new System.Windows.Forms.Label();
            this.lblABase1 = new System.Windows.Forms.Label();
            this.lblAWidth = new System.Windows.Forms.Label();
            this.lblALength = new System.Windows.Forms.Label();
            this.txtALength = new System.Windows.Forms.TextBox();
            this.txtAWidth = new System.Windows.Forms.TextBox();
            this.txtABase1 = new System.Windows.Forms.TextBox();
            this.txtABase2 = new System.Windows.Forms.TextBox();
            this.lblASide1 = new System.Windows.Forms.Label();
            this.lblASide2 = new System.Windows.Forms.Label();
            this.txtASide1 = new System.Windows.Forms.TextBox();
            this.txtASide2 = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAHeight = new System.Windows.Forms.Label();
            this.txtAHeight = new System.Windows.Forms.TextBox();
            this.lblARadius = new System.Windows.Forms.Label();
            this.txtARadius = new System.Windows.Forms.TextBox();
            this.txtPSide1 = new System.Windows.Forms.TextBox();
            this.txtPSide2 = new System.Windows.Forms.TextBox();
            this.lblPSide1 = new System.Windows.Forms.Label();
            this.lblPSide2 = new System.Windows.Forms.Label();
            this.lblPHeight = new System.Windows.Forms.Label();
            this.lblPRadius = new System.Windows.Forms.Label();
            this.txtPHeight = new System.Windows.Forms.TextBox();
            this.txtPRadius = new System.Windows.Forms.TextBox();
            this.lblParimeter = new System.Windows.Forms.Label();
            this.rbPercentage = new System.Windows.Forms.RadioButton();
            this.rbRemainder = new System.Windows.Forms.RadioButton();
            this.rbSquareRoot = new System.Windows.Forms.RadioButton();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.gbType.SuspendLayout();
            this.gbShapes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(187, 79);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(51, 17);
            this.rbCircle.TabIndex = 9;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Circle";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.Visible = false;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbCircle.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(187, 51);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbRectangle.TabIndex = 7;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.Visible = false;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbRectangle.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(34, 51);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(59, 17);
            this.rbSquare.TabIndex = 6;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Square";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.Visible = false;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbSquare.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbRhombus
            // 
            this.rbRhombus.AutoSize = true;
            this.rbRhombus.Location = new System.Drawing.Point(34, 19);
            this.rbRhombus.Name = "rbRhombus";
            this.rbRhombus.Size = new System.Drawing.Size(70, 17);
            this.rbRhombus.TabIndex = 3;
            this.rbRhombus.TabStop = true;
            this.rbRhombus.Text = "Rhombus";
            this.rbRhombus.UseVisualStyleBackColor = true;
            this.rbRhombus.Visible = false;
            this.rbRhombus.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbRhombus.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(187, 19);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(63, 17);
            this.rbTriangle.TabIndex = 4;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.Visible = false;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbTriangle.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbParallelogram
            // 
            this.rbParallelogram.AutoSize = true;
            this.rbParallelogram.Location = new System.Drawing.Point(357, 51);
            this.rbParallelogram.Name = "rbParallelogram";
            this.rbParallelogram.Size = new System.Drawing.Size(88, 17);
            this.rbParallelogram.TabIndex = 8;
            this.rbParallelogram.TabStop = true;
            this.rbParallelogram.Text = "Parallelogram";
            this.rbParallelogram.UseVisualStyleBackColor = true;
            this.rbParallelogram.Visible = false;
            this.rbParallelogram.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbParallelogram.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbTrapezoid
            // 
            this.rbTrapezoid.AutoSize = true;
            this.rbTrapezoid.Location = new System.Drawing.Point(357, 19);
            this.rbTrapezoid.Name = "rbTrapezoid";
            this.rbTrapezoid.Size = new System.Drawing.Size(72, 17);
            this.rbTrapezoid.TabIndex = 5;
            this.rbTrapezoid.TabStop = true;
            this.rbTrapezoid.Text = "Trapezoid";
            this.rbTrapezoid.UseVisualStyleBackColor = true;
            this.rbTrapezoid.Visible = false;
            this.rbTrapezoid.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbTrapezoid.Click += new System.EventHandler(this.radioButtonShape_Click);
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(34, 8);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(47, 17);
            this.rbArea.TabIndex = 0;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            this.rbArea.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbArea.Click += new System.EventHandler(this.radioButtonType_Click);
            // 
            // rbParimeter
            // 
            this.rbParimeter.AutoSize = true;
            this.rbParimeter.Location = new System.Drawing.Point(266, 8);
            this.rbParimeter.Name = "rbParimeter";
            this.rbParimeter.Size = new System.Drawing.Size(69, 17);
            this.rbParimeter.TabIndex = 2;
            this.rbParimeter.TabStop = true;
            this.rbParimeter.Text = "Parimeter";
            this.rbParimeter.UseVisualStyleBackColor = true;
            this.rbParimeter.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbParimeter.Click += new System.EventHandler(this.radioButtonType_Click);
            // 
            // rbAreaParimeter
            // 
            this.rbAreaParimeter.AutoSize = true;
            this.rbAreaParimeter.Location = new System.Drawing.Point(128, 9);
            this.rbAreaParimeter.Name = "rbAreaParimeter";
            this.rbAreaParimeter.Size = new System.Drawing.Size(96, 17);
            this.rbAreaParimeter.TabIndex = 1;
            this.rbAreaParimeter.TabStop = true;
            this.rbAreaParimeter.Text = "Area/Parimeter";
            this.rbAreaParimeter.UseVisualStyleBackColor = true;
            this.rbAreaParimeter.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbAreaParimeter.Click += new System.EventHandler(this.radioButtonType_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(218, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(218, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbSquareRoot);
            this.gbType.Controls.Add(this.rbRemainder);
            this.gbType.Controls.Add(this.rbPercentage);
            this.gbType.Controls.Add(this.rbAreaParimeter);
            this.gbType.Controls.Add(this.rbParimeter);
            this.gbType.Controls.Add(this.rbArea);
            this.gbType.Location = new System.Drawing.Point(16, 4);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(704, 44);
            this.gbType.TabIndex = 17;
            this.gbType.TabStop = false;
            // 
            // gbShapes
            // 
            this.gbShapes.Controls.Add(this.rbTrapezoid);
            this.gbShapes.Controls.Add(this.rbTriangle);
            this.gbShapes.Controls.Add(this.rbRhombus);
            this.gbShapes.Controls.Add(this.rbSquare);
            this.gbShapes.Controls.Add(this.rbRectangle);
            this.gbShapes.Controls.Add(this.rbParallelogram);
            this.gbShapes.Controls.Add(this.rbCircle);
            this.gbShapes.Location = new System.Drawing.Point(16, 50);
            this.gbShapes.Name = "gbShapes";
            this.gbShapes.Size = new System.Drawing.Size(461, 102);
            this.gbShapes.TabIndex = 18;
            this.gbShapes.TabStop = false;
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(203, 185);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(100, 69);
            this.rtxtResult.TabIndex = 14;
            this.rtxtResult.Text = "";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(226, 161);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 22;
            this.lblResult.Text = "Result:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(218, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPLength
            // 
            this.lblPLength.AutoSize = true;
            this.lblPLength.Location = new System.Drawing.Point(316, 191);
            this.lblPLength.Name = "lblPLength";
            this.lblPLength.Size = new System.Drawing.Size(40, 13);
            this.lblPLength.TabIndex = 25;
            this.lblPLength.Text = "Length";
            this.lblPLength.Visible = false;
            // 
            // lblPWidth
            // 
            this.lblPWidth.AutoSize = true;
            this.lblPWidth.Location = new System.Drawing.Point(316, 217);
            this.lblPWidth.Name = "lblPWidth";
            this.lblPWidth.Size = new System.Drawing.Size(35, 13);
            this.lblPWidth.TabIndex = 26;
            this.lblPWidth.Text = "Width";
            this.lblPWidth.Visible = false;
            // 
            // lblPBase1
            // 
            this.lblPBase1.AutoSize = true;
            this.lblPBase1.Location = new System.Drawing.Point(316, 243);
            this.lblPBase1.Name = "lblPBase1";
            this.lblPBase1.Size = new System.Drawing.Size(40, 13);
            this.lblPBase1.TabIndex = 27;
            this.lblPBase1.Text = "Base 1";
            this.lblPBase1.Visible = false;
            // 
            // lblPBase2
            // 
            this.lblPBase2.AutoSize = true;
            this.lblPBase2.Location = new System.Drawing.Point(316, 269);
            this.lblPBase2.Name = "lblPBase2";
            this.lblPBase2.Size = new System.Drawing.Size(40, 13);
            this.lblPBase2.TabIndex = 28;
            this.lblPBase2.Text = "Base 2";
            this.lblPBase2.Visible = false;
            // 
            // txtPBase2
            // 
            this.txtPBase2.Location = new System.Drawing.Point(373, 262);
            this.txtPBase2.Name = "txtPBase2";
            this.txtPBase2.Size = new System.Drawing.Size(100, 20);
            this.txtPBase2.TabIndex = 21;
            this.txtPBase2.Visible = false;
            this.txtPBase2.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPBase1
            // 
            this.txtPBase1.Location = new System.Drawing.Point(373, 236);
            this.txtPBase1.Name = "txtPBase1";
            this.txtPBase1.Size = new System.Drawing.Size(100, 20);
            this.txtPBase1.TabIndex = 20;
            this.txtPBase1.Visible = false;
            this.txtPBase1.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPWidth
            // 
            this.txtPWidth.Location = new System.Drawing.Point(373, 210);
            this.txtPWidth.Name = "txtPWidth";
            this.txtPWidth.Size = new System.Drawing.Size(100, 20);
            this.txtPWidth.TabIndex = 19;
            this.txtPWidth.Visible = false;
            this.txtPWidth.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPLength
            // 
            this.txtPLength.Location = new System.Drawing.Point(373, 184);
            this.txtPLength.Name = "txtPLength";
            this.txtPLength.Size = new System.Drawing.Size(100, 20);
            this.txtPLength.TabIndex = 18;
            this.txtPLength.Visible = false;
            this.txtPLength.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblABase2
            // 
            this.lblABase2.AutoSize = true;
            this.lblABase2.Location = new System.Drawing.Point(11, 269);
            this.lblABase2.Name = "lblABase2";
            this.lblABase2.Size = new System.Drawing.Size(40, 13);
            this.lblABase2.TabIndex = 24;
            this.lblABase2.Text = "Base 2";
            this.lblABase2.Visible = false;
            // 
            // lblABase1
            // 
            this.lblABase1.AutoSize = true;
            this.lblABase1.Location = new System.Drawing.Point(11, 243);
            this.lblABase1.Name = "lblABase1";
            this.lblABase1.Size = new System.Drawing.Size(40, 13);
            this.lblABase1.TabIndex = 19;
            this.lblABase1.Text = "Base 1";
            this.lblABase1.Visible = false;
            // 
            // lblAWidth
            // 
            this.lblAWidth.AutoSize = true;
            this.lblAWidth.Location = new System.Drawing.Point(11, 217);
            this.lblAWidth.Name = "lblAWidth";
            this.lblAWidth.Size = new System.Drawing.Size(35, 13);
            this.lblAWidth.TabIndex = 14;
            this.lblAWidth.Text = "Width";
            this.lblAWidth.Visible = false;
            // 
            // lblALength
            // 
            this.lblALength.AutoSize = true;
            this.lblALength.Location = new System.Drawing.Point(11, 191);
            this.lblALength.Name = "lblALength";
            this.lblALength.Size = new System.Drawing.Size(40, 13);
            this.lblALength.TabIndex = 13;
            this.lblALength.Text = "Length";
            this.lblALength.Visible = false;
            // 
            // txtALength
            // 
            this.txtALength.Location = new System.Drawing.Point(77, 184);
            this.txtALength.Name = "txtALength";
            this.txtALength.Size = new System.Drawing.Size(100, 20);
            this.txtALength.TabIndex = 10;
            this.txtALength.Visible = false;
            this.txtALength.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtAWidth
            // 
            this.txtAWidth.Location = new System.Drawing.Point(77, 210);
            this.txtAWidth.Name = "txtAWidth";
            this.txtAWidth.Size = new System.Drawing.Size(100, 20);
            this.txtAWidth.TabIndex = 11;
            this.txtAWidth.Visible = false;
            this.txtAWidth.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtABase1
            // 
            this.txtABase1.Location = new System.Drawing.Point(77, 236);
            this.txtABase1.Name = "txtABase1";
            this.txtABase1.Size = new System.Drawing.Size(100, 20);
            this.txtABase1.TabIndex = 12;
            this.txtABase1.Visible = false;
            this.txtABase1.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtABase2
            // 
            this.txtABase2.Location = new System.Drawing.Point(77, 262);
            this.txtABase2.Name = "txtABase2";
            this.txtABase2.Size = new System.Drawing.Size(100, 20);
            this.txtABase2.TabIndex = 13;
            this.txtABase2.Visible = false;
            this.txtABase2.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblASide1
            // 
            this.lblASide1.AutoSize = true;
            this.lblASide1.Location = new System.Drawing.Point(11, 295);
            this.lblASide1.Name = "lblASide1";
            this.lblASide1.Size = new System.Drawing.Size(37, 13);
            this.lblASide1.TabIndex = 33;
            this.lblASide1.Text = "Side 1";
            this.lblASide1.Visible = false;
            // 
            // lblASide2
            // 
            this.lblASide2.AutoSize = true;
            this.lblASide2.Location = new System.Drawing.Point(11, 321);
            this.lblASide2.Name = "lblASide2";
            this.lblASide2.Size = new System.Drawing.Size(37, 13);
            this.lblASide2.TabIndex = 34;
            this.lblASide2.Text = "Side 2";
            this.lblASide2.Visible = false;
            // 
            // txtASide1
            // 
            this.txtASide1.Location = new System.Drawing.Point(77, 288);
            this.txtASide1.Name = "txtASide1";
            this.txtASide1.Size = new System.Drawing.Size(100, 20);
            this.txtASide1.TabIndex = 14;
            this.txtASide1.Visible = false;
            this.txtASide1.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtASide2
            // 
            this.txtASide2.Location = new System.Drawing.Point(77, 314);
            this.txtASide2.Name = "txtASide2";
            this.txtASide2.Size = new System.Drawing.Size(100, 20);
            this.txtASide2.TabIndex = 15;
            this.txtASide2.Visible = false;
            this.txtASide2.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(103, 155);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 13);
            this.lblArea.TabIndex = 37;
            this.lblArea.Text = "AREA";
            // 
            // lblAHeight
            // 
            this.lblAHeight.AutoSize = true;
            this.lblAHeight.Location = new System.Drawing.Point(11, 348);
            this.lblAHeight.Name = "lblAHeight";
            this.lblAHeight.Size = new System.Drawing.Size(38, 13);
            this.lblAHeight.TabIndex = 38;
            this.lblAHeight.Text = "Height";
            this.lblAHeight.Visible = false;
            // 
            // txtAHeight
            // 
            this.txtAHeight.Location = new System.Drawing.Point(77, 341);
            this.txtAHeight.Name = "txtAHeight";
            this.txtAHeight.Size = new System.Drawing.Size(100, 20);
            this.txtAHeight.TabIndex = 16;
            this.txtAHeight.Visible = false;
            this.txtAHeight.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblARadius
            // 
            this.lblARadius.AutoSize = true;
            this.lblARadius.Location = new System.Drawing.Point(11, 373);
            this.lblARadius.Name = "lblARadius";
            this.lblARadius.Size = new System.Drawing.Size(40, 13);
            this.lblARadius.TabIndex = 40;
            this.lblARadius.Text = "Radius";
            this.lblARadius.Visible = false;
            // 
            // txtARadius
            // 
            this.txtARadius.Location = new System.Drawing.Point(77, 368);
            this.txtARadius.Name = "txtARadius";
            this.txtARadius.Size = new System.Drawing.Size(100, 20);
            this.txtARadius.TabIndex = 17;
            this.txtARadius.Visible = false;
            this.txtARadius.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPSide1
            // 
            this.txtPSide1.Location = new System.Drawing.Point(373, 288);
            this.txtPSide1.Name = "txtPSide1";
            this.txtPSide1.Size = new System.Drawing.Size(100, 20);
            this.txtPSide1.TabIndex = 22;
            this.txtPSide1.Visible = false;
            this.txtPSide1.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPSide2
            // 
            this.txtPSide2.Location = new System.Drawing.Point(373, 314);
            this.txtPSide2.Name = "txtPSide2";
            this.txtPSide2.Size = new System.Drawing.Size(100, 20);
            this.txtPSide2.TabIndex = 23;
            this.txtPSide2.Visible = false;
            this.txtPSide2.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblPSide1
            // 
            this.lblPSide1.AutoSize = true;
            this.lblPSide1.Location = new System.Drawing.Point(316, 295);
            this.lblPSide1.Name = "lblPSide1";
            this.lblPSide1.Size = new System.Drawing.Size(37, 13);
            this.lblPSide1.TabIndex = 44;
            this.lblPSide1.Text = "Side 1";
            this.lblPSide1.Visible = false;
            // 
            // lblPSide2
            // 
            this.lblPSide2.AutoSize = true;
            this.lblPSide2.Location = new System.Drawing.Point(316, 321);
            this.lblPSide2.Name = "lblPSide2";
            this.lblPSide2.Size = new System.Drawing.Size(37, 13);
            this.lblPSide2.TabIndex = 45;
            this.lblPSide2.Text = "Side 2";
            this.lblPSide2.Visible = false;
            // 
            // lblPHeight
            // 
            this.lblPHeight.AutoSize = true;
            this.lblPHeight.Location = new System.Drawing.Point(316, 348);
            this.lblPHeight.Name = "lblPHeight";
            this.lblPHeight.Size = new System.Drawing.Size(38, 13);
            this.lblPHeight.TabIndex = 46;
            this.lblPHeight.Text = "Height";
            this.lblPHeight.Visible = false;
            // 
            // lblPRadius
            // 
            this.lblPRadius.AutoSize = true;
            this.lblPRadius.Location = new System.Drawing.Point(316, 373);
            this.lblPRadius.Name = "lblPRadius";
            this.lblPRadius.Size = new System.Drawing.Size(40, 13);
            this.lblPRadius.TabIndex = 47;
            this.lblPRadius.Text = "Radius";
            this.lblPRadius.Visible = false;
            // 
            // txtPHeight
            // 
            this.txtPHeight.Location = new System.Drawing.Point(373, 340);
            this.txtPHeight.Name = "txtPHeight";
            this.txtPHeight.Size = new System.Drawing.Size(100, 20);
            this.txtPHeight.TabIndex = 24;
            this.txtPHeight.Visible = false;
            this.txtPHeight.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // txtPRadius
            // 
            this.txtPRadius.Location = new System.Drawing.Point(373, 366);
            this.txtPRadius.Name = "txtPRadius";
            this.txtPRadius.Size = new System.Drawing.Size(100, 20);
            this.txtPRadius.TabIndex = 25;
            this.txtPRadius.Visible = false;
            this.txtPRadius.TextChanged += new System.EventHandler(this.clearResults);
            // 
            // lblParimeter
            // 
            this.lblParimeter.AutoSize = true;
            this.lblParimeter.Location = new System.Drawing.Point(391, 155);
            this.lblParimeter.Name = "lblParimeter";
            this.lblParimeter.Size = new System.Drawing.Size(70, 13);
            this.lblParimeter.TabIndex = 50;
            this.lblParimeter.Text = "PARIMETER";
            // 
            // rbPercentage
            // 
            this.rbPercentage.AutoSize = true;
            this.rbPercentage.Location = new System.Drawing.Point(365, 9);
            this.rbPercentage.Name = "rbPercentage";
            this.rbPercentage.Size = new System.Drawing.Size(80, 17);
            this.rbPercentage.TabIndex = 3;
            this.rbPercentage.TabStop = true;
            this.rbPercentage.Text = "Percentage";
            this.rbPercentage.UseVisualStyleBackColor = true;
            this.rbPercentage.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbPercentage.Click += new System.EventHandler(this.radioButtonResetType_click);
            // 
            // rbRemainder
            // 
            this.rbRemainder.AutoSize = true;
            this.rbRemainder.Location = new System.Drawing.Point(476, 9);
            this.rbRemainder.Name = "rbRemainder";
            this.rbRemainder.Size = new System.Drawing.Size(76, 17);
            this.rbRemainder.TabIndex = 4;
            this.rbRemainder.TabStop = true;
            this.rbRemainder.Text = "Remainder";
            this.rbRemainder.UseVisualStyleBackColor = true;
            this.rbRemainder.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbRemainder.Click += new System.EventHandler(this.radioButtonResetType_click);
            // 
            // rbSquareRoot
            // 
            this.rbSquareRoot.AutoSize = true;
            this.rbSquareRoot.Location = new System.Drawing.Point(579, 9);
            this.rbSquareRoot.Name = "rbSquareRoot";
            this.rbSquareRoot.Size = new System.Drawing.Size(85, 17);
            this.rbSquareRoot.TabIndex = 5;
            this.rbSquareRoot.TabStop = true;
            this.rbSquareRoot.Text = "Square Root";
            this.rbSquareRoot.UseVisualStyleBackColor = true;
            this.rbSquareRoot.CheckedChanged += new System.EventHandler(this.clearFutureValues);
            this.rbSquareRoot.Click += new System.EventHandler(this.radioButtonResetType_click);
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(533, 81);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(57, 13);
            this.lblOperand1.TabIndex = 51;
            this.lblOperand1.Text = "Operand 1";
            this.lblOperand1.Visible = false;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(595, 78);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 52;
            this.txtOperand1.Visible = false;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(595, 115);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 53;
            this.txtOperand2.Visible = false;
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(533, 122);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(57, 13);
            this.lblOperand2.TabIndex = 54;
            this.lblOperand2.Text = "Operand 2";
            this.lblOperand2.Visible = false;
            // 
            // fromCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(760, 395);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand1);
            this.Controls.Add(this.lblParimeter);
            this.Controls.Add(this.txtPRadius);
            this.Controls.Add(this.txtPHeight);
            this.Controls.Add(this.lblPRadius);
            this.Controls.Add(this.lblPHeight);
            this.Controls.Add(this.lblPSide2);
            this.Controls.Add(this.lblPSide1);
            this.Controls.Add(this.txtPSide2);
            this.Controls.Add(this.txtPSide1);
            this.Controls.Add(this.txtARadius);
            this.Controls.Add(this.lblARadius);
            this.Controls.Add(this.txtAHeight);
            this.Controls.Add(this.lblAHeight);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtASide2);
            this.Controls.Add(this.txtASide1);
            this.Controls.Add(this.lblASide2);
            this.Controls.Add(this.lblASide1);
            this.Controls.Add(this.txtPBase2);
            this.Controls.Add(this.txtPBase1);
            this.Controls.Add(this.txtPWidth);
            this.Controls.Add(this.txtPLength);
            this.Controls.Add(this.lblPBase2);
            this.Controls.Add(this.lblPBase1);
            this.Controls.Add(this.lblPWidth);
            this.Controls.Add(this.lblPLength);
            this.Controls.Add(this.lblABase2);
            this.Controls.Add(this.txtABase2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.txtABase1);
            this.Controls.Add(this.lblABase1);
            this.Controls.Add(this.gbShapes);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblAWidth);
            this.Controls.Add(this.lblALength);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAWidth);
            this.Controls.Add(this.txtALength);
            this.Name = "fromCalculator";
            this.Text = "Common Geometry Formulas Calculator";
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.gbShapes.ResumeLayout(false);
            this.gbShapes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRhombus;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbParallelogram;
        private System.Windows.Forms.RadioButton rbTrapezoid;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.RadioButton rbParimeter;
        private System.Windows.Forms.RadioButton rbAreaParimeter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.GroupBox gbShapes;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPLength;
        private System.Windows.Forms.Label lblPWidth;
        private System.Windows.Forms.Label lblPBase1;
        private System.Windows.Forms.Label lblPBase2;
        private System.Windows.Forms.TextBox txtPBase2;
        private System.Windows.Forms.TextBox txtPBase1;
        private System.Windows.Forms.TextBox txtPWidth;
        private System.Windows.Forms.TextBox txtPLength;
        private System.Windows.Forms.Label lblABase2;
        private System.Windows.Forms.Label lblABase1;
        private System.Windows.Forms.Label lblAWidth;
        private System.Windows.Forms.Label lblALength;
        private System.Windows.Forms.TextBox txtALength;
        private System.Windows.Forms.TextBox txtAWidth;
        private System.Windows.Forms.TextBox txtABase1;
        private System.Windows.Forms.TextBox txtABase2;
        private System.Windows.Forms.Label lblASide1;
        private System.Windows.Forms.Label lblASide2;
        private System.Windows.Forms.TextBox txtASide1;
        private System.Windows.Forms.TextBox txtASide2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAHeight;
        private System.Windows.Forms.TextBox txtAHeight;
        private System.Windows.Forms.Label lblARadius;
        private System.Windows.Forms.TextBox txtARadius;
        private System.Windows.Forms.TextBox txtPSide1;
        private System.Windows.Forms.TextBox txtPSide2;
        private System.Windows.Forms.Label lblPSide1;
        private System.Windows.Forms.Label lblPSide2;
        private System.Windows.Forms.Label lblPHeight;
        private System.Windows.Forms.Label lblPRadius;
        private System.Windows.Forms.TextBox txtPHeight;
        private System.Windows.Forms.TextBox txtPRadius;
        private System.Windows.Forms.Label lblParimeter;
        private System.Windows.Forms.RadioButton rbRemainder;
        private System.Windows.Forms.RadioButton rbPercentage;
        private System.Windows.Forms.RadioButton rbSquareRoot;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperand2;
    }
}

