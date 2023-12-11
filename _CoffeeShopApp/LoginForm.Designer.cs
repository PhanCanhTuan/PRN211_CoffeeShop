namespace CoffeeShopApp
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_Password = new TextBox();
            tb_UserName = new TextBox();
            groupBox2 = new GroupBox();
            bt_Close = new Button();
            bt_Login = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_Password);
            groupBox1.Controls.Add(tb_UserName);
            groupBox1.Location = new Point(7, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(497, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 140);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 3;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(175, 25);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 2;
            label1.Text = "CoffeeShop";
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(175, 144);
            tb_Password.Margin = new Padding(3, 4, 3, 4);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(267, 27);
            tb_Password.TabIndex = 1;
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(175, 78);
            tb_UserName.Margin = new Padding(3, 4, 3, 4);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(267, 27);
            tb_UserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_Close);
            groupBox2.Controls.Add(bt_Login);
            groupBox2.Location = new Point(7, 239);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(497, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // bt_Close
            // 
            bt_Close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Close.Location = new Point(317, 28);
            bt_Close.Margin = new Padding(3, 4, 3, 4);
            bt_Close.Name = "bt_Close";
            bt_Close.Size = new Size(125, 53);
            bt_Close.TabIndex = 1;
            bt_Close.Text = "Close";
            bt_Close.UseVisualStyleBackColor = true;
            // 
            // bt_Login
            // 
            bt_Login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Login.Location = new Point(175, 28);
            bt_Login.Margin = new Padding(3, 4, 3, 4);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(125, 53);
            bt_Login.TabIndex = 0;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 363);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_Password;
        private TextBox tb_UserName;
        private GroupBox groupBox2;
        private Button bt_Close;
        private Button bt_Login;
    }
}