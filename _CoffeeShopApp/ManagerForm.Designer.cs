namespace CoffeeShopApp
{
    partial class ManagerForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_Salary = new TextBox();
            tb_Phone = new TextBox();
            tb_Password = new TextBox();
            tb_FullName = new TextBox();
            tb_UserName = new TextBox();
            tb_UserID = new TextBox();
            groupBox2 = new GroupBox();
            bt_Clear = new Button();
            bt_Delete = new Button();
            bt_Update = new Button();
            bt_Create = new Button();
            groupBox3 = new GroupBox();
            dgv_UserManagement = new DataGridView();
            groupBox4 = new GroupBox();
            tb_Close = new Button();
            bt_Search = new Button();
            tb_Search = new TextBox();
            label10 = new Label();
            bindingSource1 = new BindingSource(components);
            dtp_DateWork = new DateTimePicker();
            cb_Role = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_UserManagement).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_Role);
            groupBox1.Controls.Add(dtp_DateWork);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_Salary);
            groupBox1.Controls.Add(tb_Phone);
            groupBox1.Controls.Add(tb_Password);
            groupBox1.Controls.Add(tb_FullName);
            groupBox1.Controls.Add(tb_UserName);
            groupBox1.Controls.Add(tb_UserID);
            groupBox1.Location = new Point(13, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(108, 23);
            label9.Name = "label9";
            label9.Size = new Size(213, 31);
            label9.TabIndex = 16;
            label9.Text = "Staff Management";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 307);
            label8.Name = "label8";
            label8.Size = new Size(69, 28);
            label8.TabIndex = 15;
            label8.Text = "Salary:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(31, 268);
            label7.Name = "label7";
            label7.Size = new Size(109, 28);
            label7.TabIndex = 14;
            label7.Text = "Date Work:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(31, 233);
            label6.Name = "label6";
            label6.Size = new Size(71, 28);
            label6.TabIndex = 13;
            label6.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 200);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 12;
            label5.Text = "Role:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 159);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 11;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 125);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 10;
            label3.Text = "FullName: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(107, 28);
            label2.TabIndex = 9;
            label2.Text = "UserName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 55);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 8;
            label1.Text = "UserID:";
            // 
            // tb_Salary
            // 
            tb_Salary.Location = new Point(169, 308);
            tb_Salary.Name = "tb_Salary";
            tb_Salary.Size = new Size(196, 27);
            tb_Salary.TabIndex = 7;
            // 
            // tb_Phone
            // 
            tb_Phone.Location = new Point(169, 233);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.Size = new Size(196, 27);
            tb_Phone.TabIndex = 5;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(169, 160);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(230, 27);
            tb_Password.TabIndex = 3;
            // 
            // tb_FullName
            // 
            tb_FullName.Location = new Point(169, 125);
            tb_FullName.Name = "tb_FullName";
            tb_FullName.Size = new Size(230, 27);
            tb_FullName.TabIndex = 2;
            // 
            // tb_UserName
            // 
            tb_UserName.Location = new Point(169, 92);
            tb_UserName.Name = "tb_UserName";
            tb_UserName.Size = new Size(230, 27);
            tb_UserName.TabIndex = 1;
            // 
            // tb_UserID
            // 
            tb_UserID.Location = new Point(169, 59);
            tb_UserID.Name = "tb_UserID";
            tb_UserID.Size = new Size(230, 27);
            tb_UserID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_Clear);
            groupBox2.Controls.Add(bt_Delete);
            groupBox2.Controls.Add(bt_Update);
            groupBox2.Controls.Add(bt_Create);
            groupBox2.Location = new Point(13, 378);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 128);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // bt_Clear
            // 
            bt_Clear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Clear.Location = new Point(213, 83);
            bt_Clear.Name = "bt_Clear";
            bt_Clear.Size = new Size(152, 39);
            bt_Clear.TabIndex = 3;
            bt_Clear.Text = "Clear";
            bt_Clear.UseVisualStyleBackColor = true;
            // 
            // bt_Delete
            // 
            bt_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Delete.Location = new Point(20, 83);
            bt_Delete.Name = "bt_Delete";
            bt_Delete.Size = new Size(152, 39);
            bt_Delete.TabIndex = 2;
            bt_Delete.Text = "Delete";
            bt_Delete.UseVisualStyleBackColor = true;
            // 
            // bt_Update
            // 
            bt_Update.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Update.Location = new Point(213, 26);
            bt_Update.Name = "bt_Update";
            bt_Update.Size = new Size(152, 39);
            bt_Update.TabIndex = 1;
            bt_Update.Text = "Update";
            bt_Update.UseVisualStyleBackColor = true;
            // 
            // bt_Create
            // 
            bt_Create.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Create.Location = new Point(20, 26);
            bt_Create.Name = "bt_Create";
            bt_Create.Size = new Size(152, 39);
            bt_Create.TabIndex = 0;
            bt_Create.Text = "Create";
            bt_Create.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_UserManagement);
            groupBox3.Location = new Point(449, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(652, 365);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // dgv_UserManagement
            // 
            dgv_UserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_UserManagement.Location = new Point(23, 26);
            dgv_UserManagement.Name = "dgv_UserManagement";
            dgv_UserManagement.RowHeadersWidth = 51;
            dgv_UserManagement.RowTemplate.Height = 29;
            dgv_UserManagement.Size = new Size(614, 320);
            dgv_UserManagement.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb_Close);
            groupBox4.Controls.Add(bt_Search);
            groupBox4.Controls.Add(tb_Search);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(449, 381);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(652, 125);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // tb_Close
            // 
            tb_Close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Close.Location = new Point(485, 80);
            tb_Close.Name = "tb_Close";
            tb_Close.Size = new Size(152, 39);
            tb_Close.TabIndex = 19;
            tb_Close.Text = "Close";
            tb_Close.UseVisualStyleBackColor = true;
            // 
            // bt_Search
            // 
            bt_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_Search.Location = new Point(485, 23);
            bt_Search.Name = "bt_Search";
            bt_Search.Size = new Size(152, 39);
            bt_Search.TabIndex = 18;
            bt_Search.Text = "Search";
            bt_Search.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            tb_Search.Location = new Point(103, 29);
            tb_Search.Name = "tb_Search";
            tb_Search.Size = new Size(363, 27);
            tb_Search.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(23, 28);
            label10.Name = "label10";
            label10.Size = new Size(74, 28);
            label10.TabIndex = 16;
            label10.Text = "Search:";
            // 
            // dtp_DateWork
            // 
            dtp_DateWork.Location = new Point(169, 269);
            dtp_DateWork.Name = "dtp_DateWork";
            dtp_DateWork.Size = new Size(231, 27);
            dtp_DateWork.TabIndex = 17;
            // 
            // cb_Role
            // 
            cb_Role.FormattingEnabled = true;
            cb_Role.Location = new Point(169, 200);
            cb_Role.Name = "cb_Role";
            cb_Role.Size = new Size(130, 28);
            cb_Role.TabIndex = 18;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 518);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManagerForm";
            Text = "Manager Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_UserManagement).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgv_UserManagement;
        private GroupBox groupBox4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label9;
        private Button bt_Clear;
        private Button bt_Delete;
        private Button bt_Update;
        private Button bt_Create;
        private TextBox textBox9;
        private Label label10;
        private BindingSource bindingSource1;
        private Button button6;
        private Button bt_Search;
        private Button tb_Close;
        private TextBox tb_Search;
        private TextBox tb_Salary;
        private TextBox tb_Phone;
        private TextBox tb_Password;
        private TextBox tb_FullName;
        private TextBox tb_UserName;
        private TextBox tb_UserID;
        private ComboBox cb_Role;
        private DateTimePicker dtp_DateWork;
    }
}