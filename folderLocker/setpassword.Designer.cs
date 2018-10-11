namespace folderLocker
{
  partial class setpassword
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.inputpwd = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.confirmpwd = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(39, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "Input:";
      // 
      // inputpwd
      // 
      this.inputpwd.Location = new System.Drawing.Point(123, 24);
      this.inputpwd.Name = "inputpwd";
      this.inputpwd.PasswordChar = '*';
      this.inputpwd.Size = new System.Drawing.Size(100, 25);
      this.inputpwd.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(39, 69);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(71, 15);
      this.label2.TabIndex = 0;
      this.label2.Text = "Confirm:";
      // 
      // confirmpwd
      // 
      this.confirmpwd.Location = new System.Drawing.Point(123, 64);
      this.confirmpwd.Name = "confirmpwd";
      this.confirmpwd.PasswordChar = '*';
      this.confirmpwd.Size = new System.Drawing.Size(100, 25);
      this.confirmpwd.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(42, 109);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Lock";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(148, 109);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Cancel";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // setpassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(302, 158);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.confirmpwd);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.inputpwd);
      this.Controls.Add(this.label1);
      this.Name = "setpassword";
      this.Text = "Set password";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox inputpwd;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox confirmpwd;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}