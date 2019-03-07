using System;
using System.Windows.Forms;

namespace schoolHero {
 public   class addNewGroupForm : Form {
        TextBox tbNames;
        public addNewGroupForm ()
        {
            tbNames = new TextBox();
            tbNames.Dock = DockStyle.Fill;
            //tbNames.Anchor = AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top| AnchorStyles.Bottom; 
            tbNames.Multiline = true;
            Controls.Add(tbNames);
        }
    }

}