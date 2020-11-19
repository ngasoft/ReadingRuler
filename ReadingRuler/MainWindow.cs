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

        int padding = 16;
        int right_padding = 16;
        int min_height = 16;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            PaddingPanel.Left = 0;
            PaddingPanel.Width = Width - right_padding; // - 1 * padding;
            GlassPanel.Left = padding;
            GlassPanel.Top = PaddingPanel.Top + padding;
            GlassPanel.Height = PaddingPanel.Height - 2 * padding;
            GlassPanel.Width = PaddingPanel.Width - 2 * padding;
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            PaddingPanel.Left = 0;
            PaddingPanel.Width = Width - right_padding; // - 1 * padding;
            GlassPanel.Left = padding;
            GlassPanel.Top = PaddingPanel.Top + padding;
            GlassPanel.Height = PaddingPanel.Height - 2 * padding;
            GlassPanel.Width = PaddingPanel.Width - 2 * padding;
        }

        Boolean isMouseDown = false;
        int lastX = 0;
        int lastY = 0;
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            isMouseDown = true;
        }



        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int delta = e.Y - lastY;
                PaddingPanel.Top += delta;
                GlassPanel.Top += delta;


                lastX = e.X;
                lastY = e.Y;

            }

        }

        private void PaddingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                int delta = e.Y - lastY;


                if (lastY > PaddingPanel.Height - padding)
                {
                    PaddingPanel.Height += delta;
                    GlassPanel.Height += delta;
                    if (GlassPanel.Height < min_height)
                    {
                        GlassPanel.Height = min_height;
                        PaddingPanel.Height = GlassPanel.Height + 2 * padding;
                    }
                }

                lastX = e.X;
                lastY = e.Y;

            }

        }

        private void MainWindow_Scroll(object sender, ScrollEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Test");
        }

        protected override void OnMouseWheel(MouseEventArgs mea)
        {
            int delta = -mea.Delta * SystemInformation.MouseWheelScrollLines / 120;
            PaddingPanel.Top += delta;
            GlassPanel.Top += delta;
            
        }

    }
}
