using System;
using System.Windows.Forms;

namespace schoolHero {
 public   class addNewGroupForm : Form {
        TextBox tbNames, tbGroup;
	Label lbNames, lbGroup;
	Button btnOk;
	Panel panel;
        public addNewGroupForm ()
        {
	    Width = 640;
	    Height = 480;
	    lbNames = new Label();
	    lbNames.Text = "Names";
		lbNames.Dock = DockStyle.Top;
            tbNames = new TextBox();
		tbNames.Text = "Names";
            tbNames.Dock = DockStyle.Top;
		tbNames.Height = 300;
		lbGroup = new Label();
		lbGroup.Text = "Group";
		lbGroup.Dock = DockStyle.Top;
            tbGroup = new TextBox();
		tbGroup.Dock = DockStyle.Top;
		tbGroup.Text = "Group";
		btnOk = new Button();
		btnOk.Text ="&Ok";
		btnOk.Dock = DockStyle.Top;
		
		panel = new Panel();
		panel.Dock = DockStyle.Fill;
            panel.Controls.Add(tbNames);
            panel.Controls.Add(lbNames);
            panel.Controls.Add(tbGroup);
            panel.Controls.Add(lbGroup);
            panel.Controls.Add(btnOk);
	Controls.Add(panel);
            //tbNames.Anchor = AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top| AnchorStyles.Bottom; 
            tbNames.Multiline = true;
/*
            Controls.Add(btnOk);
            Controls.Add(tbNames);
            Controls.Add(lbNames);
            Controls.Add(tbGroup);
            Controls.Add(lbGroup);
*/
        }
    }

}
