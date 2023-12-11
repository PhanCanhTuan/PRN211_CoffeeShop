namespace _CoffeeShopApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            groupBox1 = new GroupBox();
            lb_UserName = new Label();
            lb_Password = new Label();
            groupBox2 = new GroupBox();
            bt_Login = new Button();
            bt_Close = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tb_Username
            // 
            tb_Username.Location = new Point(163, 91);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(306, 27);
            tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(163, 140);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(306, 27);
            tb_Password.TabIndex = 1;
            tb_Password.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lb_Password);
            groupBox1.Controls.Add(lb_UserName);
            groupBox1.Controls.Add(tb_Password);
            groupBox1.Controls.Add(tb_Username);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 190);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_UserName.Location = new Point(54, 87);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(103, 28);
            lb_UserName.TabIndex = 2;
            lb_UserName.Text = "Username:";
            // 
            // lb_Password
            // 
            lb_Password.AutoSize = true;
            lb_Password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Password.Location = new Point(55, 139);
            lb_Password.Name = "lb_Password";
            lb_Password.Size = new Size(102, 28);
            lb_Password.TabIndex = 3;
            lb_Password.Text = "Password: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_Close);
            groupBox2.Controls.Add(bt_Login);
            groupBox2.Location = new Point(12, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(577, 159);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // bt_Login
            // 
            bt_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Login.Location = new Point(163, 55);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(134, 57);
            bt_Login.TabIndex = 0;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            // 
            // bt_Close
            // 
            bt_Close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Close.Location = new Point(335, 55);
            bt_Close.Name = "bt_Close";
            bt_Close.Size = new Size(134, 57);
            bt_Close.TabIndex = 1;
            bt_Close.Text = "Close";
            bt_Close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 23);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 4;
            label1.Text = "Coffee Shop";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 379);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_Username;
        private TextBox tb_Password;
        private GroupBox groupBox1;
        private Label lb_Password;
        private Label lb_UserName;
        private GroupBox groupBox2;
        private Button bt_Close;
        private Button bt_Login;
        private Label label1;
    }
}