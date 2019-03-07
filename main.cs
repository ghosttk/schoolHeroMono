using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace schoolHero {
	public class mainForm: Form {
		 private Point _frmPoint;
		 ContextMenu context_menu;
			private mainForm()
			{
            	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            	this.TopMost = true;
				this.MouseDown += MainFrm_MouseDown;
          		this.MouseMove += MainFrm_MouseMove;
				this.MouseClick += onClick;  				
				this.Width = 200;
				this.Height = 200;
				InitializeComponent ();
				
			}
			public static void Main (string[] args)
			{
				Application.Run(new mainForm());
			}
			private void InitializeComponent ()
			{
				
				MenuItem AddNew = new MenuItem ("Add");
				MenuItem itemExit = new MenuItem ("Exit");
				itemExit.Click += new System.EventHandler(onExit);
				AddNew.Click += new System.EventHandler(onAddNew);
				MenuItem [] items = new MenuItem [] {AddNew, itemExit};
				context_menu = new 	ContextMenu (items);


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
			 if (e.Button == MouseButtons.Left)
            {
            _frmPoint.X = e.X;
            _frmPoint.Y = e.Y;
			}
        }

		void onClick (Object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
			Point pnt;
			pnt = PointToClient (MousePosition);
			context_menu.Show (this, pnt);
			}
			else
			{
				
			}
		}

		void onAddNew (Object sender, EventArgs e)
		{
			addNewGroupForm lf = new addNewGroupForm();
			lf.Show();
		}
		void onExit(Object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
