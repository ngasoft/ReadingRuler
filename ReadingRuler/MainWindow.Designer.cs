namespace ReadingRuler
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.GlassPanel = new System.Windows.Forms.Panel();
            this.PaddingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GlassPanel
            // 
            this.GlassPanel.BackColor = System.Drawing.Color.Maroon;
            this.GlassPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GlassPanel.Location = new System.Drawing.Point(12, 147);
            this.GlassPanel.Margin = new System.Windows.Forms.Padding(10);
            this.GlassPanel.Name = "GlassPanel";
            this.GlassPanel.Padding = new System.Windows.Forms.Padding(10);
            this.GlassPanel.Size = new System.Drawing.Size(776, 67);
            this.GlassPanel.TabIndex = 0;
            // 
            // PaddingPanel
            // 
            this.PaddingPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.PaddingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaddingPanel.Location = new System.Drawing.Point(12, 114);
            this.PaddingPanel.Margin = new System.Windows.Forms.Padding(10);
            this.PaddingPanel.Name = "PaddingPanel";
            this.PaddingPanel.Padding = new System.Windows.Forms.Padding(10);
            this.PaddingPanel.Size = new System.Drawing.Size(776, 67);
            this.PaddingPanel.TabIndex = 1;
            this.PaddingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.PaddingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaddingPanel_MouseMove);
            this.PaddingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GlassPanel);
            this.Controls.Add(this.PaddingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Opacity = 0.8D;
            this.Text = "Reading Ruler";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainWindow_Scroll);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.Move += new System.EventHandler(this.MainWindow_Resize);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GlassPanel;
        private System.Windows.Forms.Panel PaddingPanel;
    }
}

