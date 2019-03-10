using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace schoolHero {
 public   class addNewGroupForm : Form {
        TextBox tbNames, tbGroup;
	Label lbNames, lbGroup;
	Button btnOk, openFileDialogBTN;
	String fName;
	Panel panel;
	
        public addNewGroupForm ()
        {
	    Width = 640;
	    Height = 480;
	    lbNames = new Label();
	    lbNames.Text = "姓名";
		lbNames.Dock = DockStyle.Top;
            tbNames = new TextBox();
		tbNames.Text = "列表";
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
		openFileDialogBTN = new Button();
		openFileDialogBTN.Text = "打开文件";
		openFileDialogBTN.Click += openFileDialogBTN_Click;


		panel = new Panel();
		panel.Dock = DockStyle.Fill;
		panel.Controls.Add(openFileDialogBTN);
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

        private void openFileDialogBTN_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "./";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fName = openFileDialog.FileName;
		    tbGroup.Text = fName;
                string [] lines  = File.ReadAllLines(fName);
		    foreach(string s in lines)
		    {
			    Console.Write(s);
			    tbNames.AppendText(s);
		    }
                tbNames.AppendText("");
            }
        }
    }

}
