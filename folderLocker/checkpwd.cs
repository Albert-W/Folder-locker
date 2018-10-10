using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folderLocker
{
  public partial class checkpwd : Form
  {
    public bool status;
    public string password = "123";
    public checkpwd()
    {
      status = false;
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(textBox1.Text == password)
      {
        status = true;
        this.Close();
      }
      else
      {
        MessageBox.Show("password is incorrect.");
        textBox1.Clear();
        textBox1.Focus();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      status = false;
      this.Close();
    }
  }
}
