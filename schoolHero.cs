using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

public class ListViewTest: Form {
  
        private Button button;
        private ListView list;
		private ListViewTest ()
		{
			InitializeComponent ();
		    button = new Button();
		    button.Text = "Click Me!";
		    Controls.Add(button);
		    button.Dock = DockStyle.Right;
		}
		public static void Main (string[] args)
		{
			Application.Run(new ListViewTest());
		}
		private void InitializeComponent ()
		{
		    Size = new Size(900, 600);
            list = new ListView();
			list.Size = new System.Drawing.Size (800, 600);
			Controls.Add (list);
            getDirectoryFiles("images");
        }
        private string[] getDirectoryFiles (string dir) 
        {
           string [] fList;
           fList = Directory.GetFiles(dir);
           foreach (string f in fList){
           Console.WriteLine(f);
           }
           return fList;
        }
}

