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
  public partial class setpassword : Form
  {
    public bool status;
    public setpassword()
    {
      status = false;
      InitializeComponent();
    }



    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if(textBox1.Text.Equals(textBox2.Text) && textBox1.Text.Length != 0)
      {
        status = true;
        this.Close();
      }
      else
      {
        MessageBox.Show("Passwords don't match or blank password", "Error");
        //textBox1.Clear();
        textBox2.Clear();
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
