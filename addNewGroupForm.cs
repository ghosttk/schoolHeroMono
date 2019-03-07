using System;
using System.Windows.Forms;

namespace schoolHero {
 public   class addNewGroupForm : Form {
        TextBox tbNames, tbGroup;
        public addNewGroupForm ()
        {
            tbNames = new TextBox();
            tbNames.Dock = DockStyle.Fill;
            tbGroup = new TextBox();
            tbNames.Dock = DockStyle.Top;
            //tbNames.Anchor = AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top| AnchorStyles.Bottom; 
            tbNames.Multiline = true;
            Controls.Add(tbNames);
            Controls.Add(tbGroup);
        }
    }

}