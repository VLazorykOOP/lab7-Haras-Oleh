using System;
using System.Drawing;
using System.Windows.Forms;

namespace laboratorna_robota7
{
    
    public abstract class Figure
    {
        public uint id = 0;

        public abstract void Print(PictureBox pictureBox, int cl);
/*        public abstract void RandomMove1();*/
        public abstract void RandomMove(PictureBox pictureBox, int cl);
        public abstract void Move(PictureBox pictureBox, int cl, int direction);

    }

    public class Square : Figure
    {
        public uint side { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Square(uint side, int x, int y)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public Square(TextBox textBox)
        {
            this.side = uint.Parse(textBox.Text);

            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;

            this.x = rnd.Next(0,rightwall);
            this.y = rnd.Next(0,leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            } else if (cl == 2)
            {
                color = Color.Blue;
            } else if (cl == 3)
            {
                color = Color.Yellow;
            } else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen,x,y,side,side);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, side, side);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, side, side);
            }

        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, side, side);
            }

            if (direction == 1)
            {
                y -= 10;
            } else if (direction == 2)
            {
                x += 10;
            } else if (direction == 3)
            {
                y += 10;
            } else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, side, side);
            }
        }
    }

    public class Rectangle : Figure
    {
        public uint sidea;
        public uint sideb;
        private object p1;
        private object p2;
        private int v1;
        private int v2;

        public int x { get; set; }
        public int y { get; set; }
        public Rectangle(uint sidea, uint sideb, int x, int y)
        {
            this.sidea = sidea;
            this.sideb = sideb;
            this.x = x;
            this.y = y;
        }

        public Rectangle(TextBox textBox1, TextBox textBox2)
        {
            this.sidea = uint.Parse(textBox1.Text);
            this.sideb = uint.Parse(textBox2.Text);
            id++;
        }

        public Rectangle(object p1, object p2, int v1, int v2)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.v1 = v1;
            this.v2 = v2;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)sidea;
            int leftwall = (int)pictureBox.Height - (int)sideb;

            x = rnd.Next(0, rightwall);
            y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, sidea, sideb);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)sidea;
            int leftwall = (int)pictureBox.Height - (int)sideb;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, this.x, this.y, sidea, sideb);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawRectangle(pen, x, y, sidea, sideb);
            }
        }
    }

    public class Triangle : Figure
    {
        public uint side { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Triangle(uint side, int x, int y)
        {
            this.side = side;
            this.x = x;
            this.y = y;
        }

        public Triangle(TextBox textBox)
        {
            this.side = uint.Parse(textBox.Text);
            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;

            x = rnd.Next(0, rightwall);
            y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)side;
            int leftwall = (int)pictureBox.Height - (int)side;
            this.x = rnd.Next(0, rightwall);
            this.y = rnd.Next(0, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawLine(pen, x + side, y, x, y + side);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x + side, y);
                pictureBox.CreateGraphics().DrawLine(pen, x, y, x, y + side);
            }
        }
    }

    public class Circle : Figure
    {
        public uint radius { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Circle(uint radius, int x, int y)
        {
            this.radius = radius;
            this.x = x;
            this.y = y;
        }

        public Circle(TextBox textBox)
        {
            this.radius = uint.Parse(textBox.Text);
            id++;
        }

        public override void Print(PictureBox pictureBox, int cl)
        {
            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)radius;
            int leftwall = (int)pictureBox.Height - (int)radius;

            x = rnd.Next(0+(int)radius, rightwall);
            y = rnd.Next(0+(int)radius, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen,x,y,radius,radius);
            }
        }

        public override void RandomMove(PictureBox pictureBox, int cl)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }

            Random rnd = new Random();
            int rightwall = (int)pictureBox.Width - (int)radius;
            int leftwall = (int)pictureBox.Height - (int)radius;
            this.x = rnd.Next(0 + (int)radius, rightwall);
            this.y = rnd.Next(0 + (int)radius, leftwall);
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }
        }

        public override void Move(PictureBox pictureBox, int cl, int direction)
        {
            using (Pen pen = new Pen(Color.White, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }

            if (direction == 1)
            {
                y -= 10;
            }
            else if (direction == 2)
            {
                x += 10;
            }
            else if (direction == 3)
            {
                y += 10;
            }
            else if (direction == 4)
            {
                x -= 10;
            }
            Color color = new Color();
            if (cl == 1)
            {
                color = Color.Red;
            }
            else if (cl == 2)
            {
                color = Color.Blue;
            }
            else if (cl == 3)
            {
                color = Color.Yellow;
            }
            else if (cl == 4)
            {
                color = Color.Purple;
            }

            using (Pen pen = new Pen(color, 2))
            {
                pictureBox.CreateGraphics().DrawEllipse(pen, x, y, radius, radius);
            }
        }
    }
}

namespace laboratorna_robota7
{
    partial class Form3
    {
        public

        int SquareX;
        int SquareY;
        int cls;
        uint SideSq;


        int CircleX;
        int CircleY;
        int clc;
        uint RadiusC;

 
        int TriangleX;
        int TriangleY;
        int clt;
        uint SideTr;


        int RecX;
        int RecY;
        int clr;
        uint SideReca;
        uint SideRecb;

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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 569);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Натисніть,будь ласка,на дану клавішу,якщо бажаєте створити цю фігуру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(411, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть,будь ласка,тип фігури,яку Ви бажаєте створити:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(341, 116);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(62, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Коло";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton3.Location = new System.Drawing.Point(231, 87);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Трикутник";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 54);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прямокутник";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Квадрат";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 409);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Параметри сторони квадрату:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 409);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "a";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 450);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Параметри сторін прямокутника:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 447);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(15, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "a";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 447);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(19, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "b";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(338, 492);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(18, 22);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 495);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Параметри сторони трикутника:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(408, 533);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(19, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "r";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 533);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Параметри радіуса кола:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(444, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 404);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Location = new System.Drawing.Point(16, 224);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(404, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оберіть,будь ласка,колір для фігури,яку Ви бажаєте створити:";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(190, 60);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(107, 21);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Фіолетовий";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(306, 32);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(80, 21);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Жовтий";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(12, 105);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(65, 21);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Синій";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(85, 86);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(94, 21);
            this.radioButton8.TabIndex = 0;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Червоний";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(603, 457);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Рух /|\\ вгору";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(727, 509);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Рух вправо ->";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(603, 565);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 44);
            this.button4.TabIndex = 16;
            this.button4.Text = "Рух \\|/ вниз";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(469, 511);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 39);
            this.button5.TabIndex = 17;
            this.button5.Text = "<- Рух вліво";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(615, 509);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 48);
            this.button6.TabIndex = 18;
            this.button6.Text = "БУДЬ-ДЕ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(586, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Полотно для фігур:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Розділ клавіш навігації:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(71, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "РОЗДІЛ СТВОРЕННЯ БАЖАНОЇ ФІГУРИ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Розділ задання параметрів для обраних фігур:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 621);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "ТРЕТЄ ЗАВДАННЯ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private Button button6;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }


}