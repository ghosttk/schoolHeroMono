using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace schoolHero {
	public class mainForm: Form {
		 private Point _frmPoint;
			private mainForm()
			{
				 //无边框
            	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //不出现在任务栏
            	this.ShowInTaskbar = false; 
				this.TopMost = true;
				this.MouseDown += MainFrm_MouseDown;
          		this.MouseMove += MainFrm_MouseMove;
				InitializeComponent ();
				
			}
			public static void Main (string[] args)
			{
				Application.Run(new mainForm());
			}
			private void InitializeComponent ()
			{

			}
 		void MainFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-_frmPoint.X, -_frmPoint.Y);
                Location = myPosittion;
            } 
        }

        void MainFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _frmPoint.X = e.X;
            _frmPoint.Y = e.Y;
        }
	}
}
