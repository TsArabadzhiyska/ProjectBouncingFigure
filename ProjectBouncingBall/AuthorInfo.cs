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
    public partial class AuthorInfo : Form
    {
        public AuthorInfo()
        {
            InitializeComponent();
        }

        private void AutorInfo_Load(object sender, EventArgs e)
        {

        }

        private void AutorInfo_Paint(object sender, PaintEventArgs e)
        {
            Font FontText = new Font("Times New Roman", 16, FontStyle.Italic);
            Graphics g = CreateGraphics();
            g.DrawString("Автор : \n\n Цветелина Арабаджийска " +
                "\n Tsvetelina Arabadzhiyska \n \nф.номер:\n 1701681027" +
                " \nf.number:\n 1701681027\n\nспец.:\n СТД" +
                "\nspeciality:\n STD",FontText,Brushes.MidnightBlue,10,50);

        } 
    }
}
