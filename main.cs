using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace schoolHero {
	public class mainForm: Form {
		 private Point _frmPoint;
		 ContextMenu context_menu;
		 Label lbTime;
			private mainForm()
			{
				Rectangle rect = Screen.GetWorkingArea(this);
				Point p = new Point(rect.Width-Width,rect.Height-Height);
				StartPosition = FormStartPosition.Manual;
				Console.Write(p);
				this.Location = p;
            	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            	this.TopMost = true;
				this.MouseDown += MainFrm_MouseDown;
          		this.MouseMove += MainFrm_MouseMove;
				this.MouseClick += onClick;  				
				this.Width = 200;
				this.Height = 200;
				BackColor = Color.Black;
				lbTime=new Label();
				lbTime.Dock=DockStyle.Fill;
				Controls.Add(lbTime);

				InitializeComponent ();
				
			}
			public static void Main (string[] args)
			{
				Application.Idle += new EventHandler (IdleHandler);
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

		void IdleHandler(object sender, EventArgs e)
		{
			lbTime.Text = DateTime.Now.ToString();
		}
	}
}
