using System;
using System.Windows.Forms;
using System.Xml;

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
            tbNames.Multiline = true;
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
		btnOk.Click += onOk;

		panel = new Panel();
		panel.Dock = DockStyle.Fill;
            panel.Controls.Add(btnOk);
            panel.Controls.Add(tbNames);
            panel.Controls.Add(lbNames);
            panel.Controls.Add(tbGroup);
            panel.Controls.Add(lbGroup);
		Controls.Add(panel);
            //tbNames.Anchor = AnchorStyles.Right | AnchorStyles.Left| AnchorStyles.Top| AnchorStyles.Bottom; 
        }

	  public void onOk (Object sender, EventArgs e)
	  {
		  /*
		  if (!File.Exists(tbGroup.Text+".xml"))
		  {
			  File.Create(tbGroup+".xml");
		  }
		  */
		  XmlDocument xmldoc=new XmlDocument();
            //加入XML的声明段落：<?xmlversion="1.0" encoding="utf-8"?>
            XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmldoc.AppendChild(xmldecl);
		XmlElement root = xmldoc.CreateElement("Group");
		xmldoc.AppendChild(root);
            //保存创建好的XML文档
            xmldoc.Save("data/"+tbGroup.Text+".xml");
	  }
    }

}
