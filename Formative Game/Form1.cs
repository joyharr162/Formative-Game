/// Created by Joy Harris
/// on September 8 2016
/// 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Formative_Game
{
    public partial class formative : Form
    {
        public formative()
        {
            InitializeComponent();
        }

        /*when the button in clicked, the button disappears, and a message appears*/
        private void startButton_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;//countdown to game starting
            Refresh();
            Thread.Sleep(2000);
            label1.BackColor = Color.Black;

            startButton.BackColor = Color.Black;

            label2.BackColor = Color.WhiteSmoke;
            Refresh();
            Thread.Sleep(1000);
            label2.BackColor = Color.Black;

            label3.BackColor = Color.WhiteSmoke;
            Refresh();
            Thread.Sleep(1000);
            label3.BackColor = Color.Black;

            label4.BackColor = Color.WhiteSmoke;
            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(1000);
            label4.BackColor = Color.Black;

            startButton.BackColor = Color.ForestGreen;//changes screen to green, clears labels
            label1.Dispose();
            label2.Dispose();
            label3.Dispose();
            label4.Dispose();
            startButton.Dispose();

            SoundPlayer player = new SoundPlayer(Properties.Resources.alert);//plays sound
            player.Play();

            Graphics formGraphics = this.CreateGraphics();//pens and brushes
            Pen drawPen = new Pen(Color.Black, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial",8, FontStyle.Bold);
            Font secondFont = new Font("Copperplate Gothic Bold", 44, FontStyle.Bold);
            SolidBrush secondBrush = new SolidBrush(Color.BlueViolet);
            SolidBrush thirdBrush = new SolidBrush(Color.Orange);

            BackColor = Color.ForestGreen;
            formGraphics.FillRectangle(drawBrush, 60, 80, 50, 100);//draw logo
            formGraphics.TranslateTransform(125,80);//draw and rotate string
            formGraphics.RotateTransform(90);
            formGraphics.DrawString("Central Rams Arcade", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();
            formGraphics.FillEllipse(thirdBrush, 82, 100, 10, 20);
            formGraphics.DrawString("C", secondFont, secondBrush, 55, 75);
        
            Thread.Sleep(3000);//wait three seconds

            formGraphics.Clear(Color.Black);//clear the screen

            formGraphics.FillRectangle(thirdBrush, 20, 20, 160, 15);
            formGraphics.FillRectangle(thirdBrush, 20, 80, 100, 15);
            formGraphics.FillRectangle(thirdBrush, 180, 20, 15, 250);
            formGraphics.FillRectangle(thirdBrush, 120, 80, 15, 200);
            formGraphics.FillPie(secondBrush, 20, 50, 30, 30, 30, 300);//draw pacman
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 20, 50, 30, 30);
            formGraphics.FillEllipse(secondBrush, 75, 50, 30, 30);
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 75, 50, 30, 30);
            formGraphics.FillPie(secondBrush, 140, 50, 30, 30, 30, 300);//close pacman's mouth
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 140, 50, 30, 30);
            formGraphics.FillEllipse(secondBrush, 140, 105, 30, 30);
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 140, 105, 30, 30);
            formGraphics.FillPie(secondBrush, 140, 155, 30, 30, 100, 300);
            Thread.Sleep(1000);

            formGraphics.FillEllipse(drawBrush, 140, 155, 30, 30);
            formGraphics.FillEllipse(secondBrush, 140, 210, 30, 30);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(drawBrush, 140, 210, 30, 30);
        }

        private void startButton_MouseHover(object sender, EventArgs e)/*When you hover over 
            the start button, its color changes*/
        {
            
            startButton.BackColor = Color.WhiteSmoke;
        
        }
    }
}
