using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace ProjectBouncingBall
{

    public partial class Form1 : Form
    {
        Graphics graphics; // създаване на обект тип графика 
                           //координати на центъра на редмета
        int x = 100;
        int y = 100;
        //рамери
        int l = 18;//по ширина
        int h = 28;//по дължина
        //стъпки на отместване 
        int dx = 5;//настрани
        int dy = 2;//нагоре надолу
                   //инструменти за изрисуване 
        SolidBrush changingbrush = new SolidBrush(Color.Blue);//цвят на запълване на обекта

        Pen pen = new Pen(Color.Black, 1);//цвят на очертания и размер

        int width = 0; // Променлива от целочислен тип ,с която по-надолу в програмата ще управлявам крайната точка до която обектът ще може да стига

        string helper = "Demonstration of bouncing object .Please choose a command from the menu .";

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.DoubleBuffered = true;//
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            graphics = e.Graphics;//на променливата graphics
            graphics.SmoothingMode = SmoothingMode.AntiAlias;//поправя очертанията 
                                                             //  graphics.Clear(BackColor);
                                                             //Логически проверки за избор на вида на движещия се обект 

            if (radioButtonCircle.Checked)
            {
                //в свойствата на този радиобутон е зададено свйството checked =true,
                //което обекта при стартиране на програмата в противен случай обектът 
                ///ще липсва докато не бъде избран.
                //за кръг 

                graphics.FillEllipse(changingbrush, x, y, l, l);
                graphics.DrawEllipse(pen, x, y, l, l);
            }
            else if (radioButtonSquare.Checked)
            {//чертае квадрат
                graphics.FillRectangle(changingbrush, x, y, l, l);
                graphics.DrawRectangle(pen, x, y, l, l);

            }
            else if (radioButtonEllipse.Checked)
            {//чертае елипса
                graphics.FillEllipse(changingbrush, x, y, h, l);
                graphics.DrawEllipse(pen, x, y, h, l);
            }
            else if (radioButtonRectangle.Checked)
            {//чертае правоъгълник
                graphics.FillRectangle(changingbrush, x, y, h, l);
                graphics.DrawRectangle(pen, x, y, h, l);
            }

        }

        private void changeTheShapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changeTheShapeToolStripMenuItem.Checked)
            {
                changeTheObjectBox.Visible = true;
                // colorOfTheFigureToolStripMenuItem.Checked = false;
            }
            else
                changeTheObjectBox.Visible = false;
        }

        //Промяна на запълващия цвят с помощ на color dialog

        private void changeTheFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You can change the fill of the object from here .";
            if (colorDialog2.ShowDialog() == DialogResult.OK)
                changingbrush = new SolidBrush(colorDialog2.Color);
            toolStripStatusLabel1.Text = helper;
        }
        //Промяна на цвета на линията на обекта

        private void lineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Now you can change the line color";
            if (colorLine.ShowDialog() == DialogResult.OK)
                pen = new Pen(colorLine.Color);
            toolStripStatusLabel1.Text = helper;

        }

        //Промяна на фона на формата 

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {//контрола тип бутон .При кликване върху него се появява цветови диалог
            toolStripStatusLabel1.Text = "Now you can change the background color";
            if (colorDialog1.ShowDialog() == DialogResult.OK) //ако е обменена информация чрез диалога 
            {
                this.BackColor = colorDialog1.Color;//цветът на фона на формата се подменя с избрания от диалога цвят 
                toolStripStatusLabel1.Text = helper;//междувеменно помощната лента се почиства 
            }
            else
            {
                this.BackColor = this.BackColor;// иначе си остава същия фон на формата
                toolStripStatusLabel1.Text = helper;//
            }
        }



        //метод , създаден от мен , който контролира движението на обекта 

        private void MoveObject()
        {
            width = this.ClientSize.Width - 20;
            if (trackBarxspeed.Visible == true || changeTheObjectBox.Visible == true)
                if (x < 604)
                    width = 604;

            //условен оператор,който дава възможност ако обектът срещне някоя стена на формата ,
            //то той да се отблъсква от нея .
            //в случая крайната точка за обекта по х не е зададена като крайна за формата. Причината е ,
            //че съществуват невидими контроли , които в даден момент могат да бъдат извикани от потребителя
            //при нужда .Именно в пространството от 604 до края на формата .


            if (x + dx < 0 || x + dx > width) //ако ако обектът стигне крайна точка по дължина 
                dx = -dx;                //посоката му става с противоположен знак

            if (y + dy < 33 || y + dy > this.ClientSize.Height - 46)//ако ако обектът стигне крайна точка по височина
                dy = -dy;//посоката му става с противоположен знак

            x += dx;//измества обекта по дължина
            y += dy;//измества обекта по височина
            Invalidate();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            MoveObject();//извиква се методът move object
        }

        //Поведение на обекта

        //Старт бутон

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {//бутон за стартиране на движение 

            if (timer1.Enabled == false)
                timer1.Start();
            else
                MessageBox.Show("The figure is already moving!");
        }

        //Стоп бутон 

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                timer1.Stop();
            else
                MessageBox.Show("The figure is stopped already !");
        }

        //Управление на скоростта 

        private void trackBaryspeed_Scroll(object sender, EventArgs e)
        {
            //По вертикала
            switch (trackBaryspeed.Value)
            {
                case 0: dy = 5; break;
                case 1: dy = 10; break;
                case 2: dy = 15; break;
                case 3: dy = 20; break;
                case 4: dy = 25; break;

            }
        }
        private void trackBarxspeed_Scroll_1(object sender, EventArgs e)
        {
            //По хоризонтала
            switch (trackBarxspeed.Value)
            {
                case 0: dx = 5; break;
                case 1: dx = 10; break;
                case 2: dx = 15; break;
                case 3: dx = 20; break;
                case 4: dx = 25; break;

            }
        }
        private void trackBarXySpeed_Scroll(object sender, EventArgs e)
        {
            //Двустранно 
            switch (trackBarXySpeed.Value)
            {
                case 0: dx = 5; dy = 5; break;
                case 1: dx = 10; dy = 10; break;
                case 2: dx = 15; dy = 15; break;
                case 3: dx = 20; dy = 20; break;
                case 4: dx = 25; dy = 25; break;

            }
        }

        // Визуализира плъзгачи за регулиране на скоростта 

        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (speedToolStripMenuItem.Checked)
            {
                toolStripStatusLabel1.Text = "Now you can manipulate the speed of the figure.If you want to hide this option please uncheck the button speed on the menu";
                labelXspeed.Visible = true;
                labelYspeed.Visible = true;
                labelSPEED.Visible = true;

                trackBarxspeed.Visible = true;
                trackBaryspeed.Visible = true;
                trackBarXySpeed.Visible = true;
            }
            else
            {
                toolStripStatusLabel1.Text = helper;
                labelXspeed.Visible = false;
                labelYspeed.Visible = false;
                labelSPEED.Visible = false;

                trackBarxspeed.Visible = false;
                trackBaryspeed.Visible = false;
                trackBarXySpeed.Visible = false;
            }


        }

        //Скрива или возуализира stasu strip

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
            if (statusStrip1.Visible == true)
                helpToolStripMenuItem.Text = "Hide help";
            else
            {
                helpToolStripMenuItem.Text = "Help";
                //  width = this.ClientSize.Width;
            }
        }


        //Навигация къмпомощната лента -> Status Strip


        private void behaviorOfTheFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (behaviorOfTheFigureToolStripMenuItem.Checked)
                toolStripStatusLabel1.Text = "From here you can control the movement of the object .";

            toolStripStatusLabel1.Text = helper;
        }

        private void editFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editFigureToolStripMenuItem.Checked)
                toolStripStatusLabel1.Text = "From the button change background color you can change the background of the form .";

            toolStripStatusLabel1.Text = helper;
        }

        private void editFigureToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From here you can change the shape and the colors of the object. ";
        }

        private void changeTheShapeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

            toolStripStatusLabel1.Text = "If you choose this button ,it will show you a group of radio buttons with opportunities ";

        }

        private void changeColorToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this option you can change the background color";
        }

        private void editFormToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this option you can make changes to the form";
        }

        private void behaviorOfTheFigureToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this option you can control the behavior of the object";
        }

        private void startToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this button you will Start the movement of the object";
        }

        private void stopToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this button you will Stop the movement of the object";
        }

        private void speedToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "This button will visualize controls that you can manipulate the object's speed";
        }

        private void colorOfTheFigureToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "From this option you can change the colors of the object";
        }

        private void changeTheFillToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "This button will help you to change the color ot the fill of the object ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (changeTheShapeToolStripMenuItem.Checked)
                toolStripStatusLabel1.Text = "From these radiobuttons you can change the object ";
            toolStripStatusLabel1.Text = helper;
        }

        private void helpToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

            if (statusStrip1.Visible == true)
                toolStripStatusLabel1.Text = "Click to hide the help";
            else
            {
                helpToolStripMenuItem.Text = "Click to show help";
                //  width = this.ClientSize.Width;
            }
        }

        //Форма с информация за автора 

        private void autorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorInfo text = new AuthorInfo();
            text.Show();
            text.Visible = true;
        }

        //Форма с информация за програмата 

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information_about_the_progarm text = new Information_about_the_progarm();
            text.Show();
            text.Visible = true;
        }
        private void lineColorToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to change the line color";
        }
    }
}
