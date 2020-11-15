using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReadingRuler
{


    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        int padding = 10;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            GlassPanel.Left = padding;
            GlassPanel.Width = Width - 4 * padding;
        }
 
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            GlassPanel.Left = padding;
            GlassPanel.Width = Width - 4 * padding;
        }

        Boolean isResizingTop = false;
        Boolean isResizingBot = false;
        int lastX = 0;
        int lastY = 0;
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            if (GlassPanel.Top - lastY <= 20 && GlassPanel.Top - lastY >= 0)
            {
                isResizingTop = true;
            }
            else if (lastY - (GlassPanel.Top + GlassPanel.Height) <= 20 && lastY - (GlassPanel.Top + GlassPanel.Height) >= 0)
            {
                isResizingBot = true;
            }
            else
            {
                isResizingTop = true;
                isResizingBot = true;
            }
        }



        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            isResizingTop = false;
            isResizingBot = false;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizingTop || isResizingBot)
            {
                int delta = e.Y - lastY;
                lastX = e.X;
                lastY = e.Y;
                if (isResizingTop) GlassPanel.Top += delta;
                if (!isResizingBot)
                {
                    GlassPanel.Height -= delta;
                }
            }
            
        }


    }
}
