namespace WinformMethod00
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtRadius = new TextBox();
            label1 = new Label();
            lblResult = new Button();
            button2 = new Button();
            btnCircleArea = new Button();
            TestFunction = new GroupBox();
            txtOutputParameter = new Button();
            txtRefParameter = new Button();
            txtInput = new TextBox();
            btnTriangle01 = new Button();
            txtSize = new TextBox();
            txtLetter = new TextBox();
            txtOutput = new TextBox();
            btnArrayParameter = new Button();
            groupBox1.SuspendLayout();
            TestFunction.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Location = new Point(106, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(707, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(112, 90);
            txtRadius.Multiline = true;
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(163, 85);
            txtRadius.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 24);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(159, 46);
            label1.TabIndex = 3;
            label1.Text = "รัศมีวงกลม";
            label1.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(541, 40);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(94, 125);
            lblResult.TabIndex = 2;
            lblResult.Text = "---";
            lblResult.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(389, 40);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 1;
            button2.Text = "เส้นรอบวง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(277, 40);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(94, 29);
            btnCircleArea.TabIndex = 0;
            btnCircleArea.Text = "พื้นที่";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // TestFunction
            // 
            TestFunction.BackColor = Color.Coral;
            TestFunction.Controls.Add(txtOutputParameter);
            TestFunction.Controls.Add(txtRefParameter);
            TestFunction.Controls.Add(txtInput);
            TestFunction.Controls.Add(btnTriangle01);
            TestFunction.Controls.Add(txtSize);
            TestFunction.Controls.Add(txtLetter);
            TestFunction.Controls.Add(txtOutput);
            TestFunction.Location = new Point(106, 262);
            TestFunction.Name = "TestFunction";
            TestFunction.Size = new Size(665, 250);
            TestFunction.TabIndex = 1;
            TestFunction.TabStop = false;
            TestFunction.Text = "groupBox2";
            // 
            // txtOutputParameter
            // 
            txtOutputParameter.Location = new Point(446, 199);
            txtOutputParameter.Name = "txtOutputParameter";
            txtOutputParameter.Size = new Size(189, 29);
            txtOutputParameter.TabIndex = 11;
            txtOutputParameter.Text = "ทดสอบ output parameter";
            txtOutputParameter.UseVisualStyleBackColor = true;
            txtOutputParameter.Click += txtOutputParameter_Click;
            // 
            // txtRefParameter
            // 
            txtRefParameter.Location = new Point(277, 199);
            txtRefParameter.Name = "txtRefParameter";
            txtRefParameter.Size = new Size(149, 29);
            txtRefParameter.TabIndex = 10;
            txtRefParameter.Text = "ทดสอบ Referance";
            txtRefParameter.TextAlign = ContentAlignment.BottomCenter;
            txtRefParameter.UseVisualStyleBackColor = true;
            txtRefParameter.Click += txtRefParameter_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(357, 127);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(202, 51);
            txtInput.TabIndex = 9;
            // 
            // btnTriangle01
            // 
            btnTriangle01.Location = new Point(541, 26);
            btnTriangle01.Name = "btnTriangle01";
            btnTriangle01.Size = new Size(94, 66);
            btnTriangle01.TabIndex = 8;
            btnTriangle01.Text = "Triangle";
            btnTriangle01.UseVisualStyleBackColor = true;
            btnTriangle01.Click += btnTriangle01_Click;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(432, 36);
            txtSize.Multiline = true;
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(103, 51);
            txtSize.TabIndex = 7;
            // 
            // txtLetter
            // 
            txtLetter.Location = new Point(306, 41);
            txtLetter.Multiline = true;
            txtLetter.Name = "txtLetter";
            txtLetter.Size = new Size(108, 51);
            txtLetter.TabIndex = 6;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(47, 36);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(204, 187);
            txtOutput.TabIndex = 5;
            // 
            // btnArrayParameter
            // 
            btnArrayParameter.Location = new Point(876, 65);
            btnArrayParameter.Name = "btnArrayParameter";
            btnArrayParameter.Size = new Size(209, 74);
            btnArrayParameter.TabIndex = 2;
            btnArrayParameter.Text = "parameter แบบ array";
            btnArrayParameter.UseVisualStyleBackColor = true;
            btnArrayParameter.Click += btnArrayParameter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 537);
            Controls.Add(btnArrayParameter);
            Controls.Add(TestFunction);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TestFunction.ResumeLayout(false);
            TestFunction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox TestFunction;
        private Label label1;
        private Button lblResult;
        private Button button2;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private Button btnTriangle01;
        private TextBox txtSize;
        private TextBox txtLetter;
        private TextBox txtOutput;
        private Button txtOutputParameter;
        private Button txtRefParameter;
        private TextBox txtInput;
        private Button btnArrayParameter;
    }
}
