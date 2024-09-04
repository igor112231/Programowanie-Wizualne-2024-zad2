namespace Programowanie_Wizualne_2024_zad2
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
            add_Employee = new Button();
            show_Employees = new Button();
            groupBox1 = new GroupBox();
            comboBox5 = new ComboBox();
            next_Step = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            Add = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            Exit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // add_Employee
            // 
            add_Employee.Location = new Point(179, 37);
            add_Employee.Name = "add_Employee";
            add_Employee.Size = new Size(129, 29);
            add_Employee.TabIndex = 0;
            add_Employee.Text = "Add Employee";
            add_Employee.UseVisualStyleBackColor = true;
            add_Employee.Click += add_Employee_Click;
            // 
            // show_Employees
            // 
            show_Employees.Location = new Point(465, 37);
            show_Employees.Name = "show_Employees";
            show_Employees.Size = new Size(159, 29);
            show_Employees.TabIndex = 1;
            show_Employees.Text = "Show Employees";
            show_Employees.UseVisualStyleBackColor = true;
            show_Employees.Click += show_Employees_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(next_Step);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(143, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 214);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Manager", "Cleaner", "Programmer" });
            comboBox5.Location = new Point(331, 115);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 28);
            comboBox5.TabIndex = 7;
            // 
            // next_Step
            // 
            next_Step.Location = new Point(195, 170);
            next_Step.Name = "next_Step";
            next_Step.Size = new Size(94, 29);
            next_Step.TabIndex = 6;
            next_Step.Text = "next";
            next_Step.UseVisualStyleBackColor = true;
            next_Step.Click += next_Step_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 118);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 5;
            textBox6.Text = "write email";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(36, 118);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "write address";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(327, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "write phone number";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "write age";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "write name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(Add);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(157, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 220);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            groupBox2.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(268, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // Add
            // 
            Add.Location = new Point(213, 176);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 7;
            Add.Text = "Add ";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(84, 131);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            comboBox3.Text = "Write boss";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(294, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Write department";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(84, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Write salary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 328);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 9;
            label1.Click += label1_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(680, 167);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 10;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Visible = false;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(show_Employees);
            Controls.Add(add_Employee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_Employee;
        private Button show_Employees;
        private GroupBox groupBox1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button next_Step;
        private Button Add;
        private GroupBox groupBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox5;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button Exit;
    }
}