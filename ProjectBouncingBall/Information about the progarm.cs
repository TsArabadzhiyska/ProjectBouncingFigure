using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBouncingBall
{
    public partial class Information_about_the_progarm : Form
    {
        public Information_about_the_progarm()
        {
            InitializeComponent();
        }

        private void Information_about_the_progarm_Load(object sender, EventArgs e)
        {

        }

        private void Information_about_the_progarm_Paint(object sender, PaintEventArgs e)
        {
            Font FontText = new Font("Times New Roman", 12, FontStyle.Italic);
            Graphics textapp = CreateGraphics();
            textapp.DrawString("Движещ се обект,рекуширащ от стените на прозореца\n\n\n " +
                "Приложението съдържа лента с менюта с възможност за: \n\n " +
                " Подменю(Edit object) с възможности за: \n   -избор на вида на движещият се обект\n " +
                "  -избор на основен цвят на обекта\n   избор за цвят на рамката му \n  (Edit form)за смяна на цвета на фона " +
                "\n  Управление на поведението на обекта \n   -старт бутон \n   -стоп бутон \n   -регулирне ба скоростта \n  Информация" +
                " \n   -за програмата \n   -за автора \n  Помощна система с лента ", FontText, Brushes.MidnightBlue, 10, 50);




        }
    }
}
