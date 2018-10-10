using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace folderLocker
{
  public partial class Mainform : Form
  {
    public string status;
    //bool flag = true;
    string[] arr;

    public Mainform()
    {
      InitializeComponent();
      arr = new string[6];
      status = "";
      arr[0] = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}";
      arr[1] = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}";
      arr[2] = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}";
      arr[3] = ".{645FF040-5081-101B-9F08-00AA002F954E}";
      arr[4] = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}";
      arr[5] = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //status = lockType;//
      //需要使用文件夹打开器，而不是文件打开器。
      using (FolderBrowserDialog dialog = new FolderBrowserDialog())
      {
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            this.textBox1.Text = dialog.SelectedPath;
            if(this.textBox1.Text != "")
            {
              string path = this.textBox1.Text;
              DirectoryInfo d = new DirectoryInfo(path);
              if(path.LastIndexOf(".{") == -1) //if the folder is unlocked
              {
                setpassword(path);
                if (!d.Root.Equals(d.Parent.FullName))
                {
                  d.MoveTo(path + arr[0]);

                }
              }
              else
              {
                if (checkpwd())
                {
                  string subpath = path.Substring(0, path.LastIndexOf("."));
                  d.MoveTo(subpath);
                  textBox1.Text = path;
                }
              }
            }
          }
          catch (Exception ex)
          {
            throw (ex);
          }
        }
      }


    }

    private bool setpassword(string path)
    {
      setpassword p = new setpassword();
      p.ShowDialog();
      return p.status;
    }
    private bool checkpwd()
    {
      checkpwd c = new checkpwd();
      c.ShowDialog();
      return c.status;
    }
  }
  
}
