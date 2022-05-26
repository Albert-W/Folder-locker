using DBUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folderLocker
{
    public partial class checkpwd : Form
    {
        public string path;
        public bool status;
        public string password = "Albert-W";
        public checkpwd(string path)
        {
            this.path = path;
            status = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteParameter p = new SQLiteParameter("@folderName", path);
            bool isValid = false;
            if (textBox1.Text == password)
            {
                isValid = true;
            }
            if (isValid == false)
            {
                //get the password from the database.
                string SQL = "SELECT * FROM FolderInfo WHERE folderName =@folderName";
                DataTable dt = DbHelperSQLite.Query(SQL, p).Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("password is missing");
                } else
                {
                    //the input password should be convert to md5 password;
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] plaintext = Encoding.Default.GetBytes(textBox1.Text);
                    byte[] ciphertext = md5.ComputeHash(plaintext);
                    string md5Pwd = Convert.ToBase64String(ciphertext);
                    if (md5Pwd == Convert.ToString(dt.Rows[0][1]))
                    {
                        isValid = true;
                    }
                }
            }

            if ( isValid == true)
            {
                status = true;
                MessageBox.Show("The folder is unlocked.");
                //delete the record;
                string DEL = "DELETE FROM FolderInfo WHERE folderName =@folderName";
                DbHelperSQLite.ExecuteSql(DEL, p);
                //
                SendKeys.SendWait("{f5}");
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
