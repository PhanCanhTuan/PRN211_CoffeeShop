namespace CoffeeShopApp
{
    partial class ProductManagement
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            dgv_ProductList = new DataGridView();
            tb_ProductID = new TextBox();
            tb_ProductName = new TextBox();
            tb_ProductPrice = new TextBox();
            tb_ProductDecription = new TextBox();
            tb_ProductSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            bt_CreatePro = new Button();
            bt_UpdatePro = new Button();
            bt_DeletePro = new Button();
            bt_ResetPro = new Button();
            bt_SearchPro = new Button();
            bt_LogoutPro = new Button();
            cb_ProductType = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_ProductType);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_ProductDecription);
            groupBox1.Controls.Add(tb_ProductPrice);
            groupBox1.Controls.Add(tb_ProductName);
            groupBox1.Controls.Add(tb_ProductID);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_ResetPro);
            groupBox2.Controls.Add(bt_DeletePro);
            groupBox2.Controls.Add(bt_UpdatePro);
            groupBox2.Controls.Add(bt_CreatePro);
            groupBox2.Location = new Point(12, 379);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(374, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgv_ProductList);
            groupBox3.Location = new Point(392, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(626, 371);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(bt_LogoutPro);
            groupBox4.Controls.Add(bt_SearchPro);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(tb_ProductSearch);
            groupBox4.Location = new Point(392, 379);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(626, 140);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // dgv_ProductList
            // 
            dgv_ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProductList.Location = new Point(16, 26);
            dgv_ProductList.Name = "dgv_ProductList";
            dgv_ProductList.RowHeadersWidth = 51;
            dgv_ProductList.RowTemplate.Height = 29;
            dgv_ProductList.Size = new Size(592, 325);
            dgv_ProductList.TabIndex = 0;
            // 
            // tb_ProductID
            // 
            tb_ProductID.Location = new Point(139, 77);
            tb_ProductID.Name = "tb_ProductID";
            tb_ProductID.Size = new Size(216, 27);
            tb_ProductID.TabIndex = 0;
            // 
            // tb_ProductName
            // 
            tb_ProductName.Location = new Point(139, 124);
            tb_ProductName.Name = "tb_ProductName";
            tb_ProductName.Size = new Size(216, 27);
            tb_ProductName.TabIndex = 1;
            // 
            // tb_ProductPrice
            // 
            tb_ProductPrice.Location = new Point(139, 171);
            tb_ProductPrice.Name = "tb_ProductPrice";
            tb_ProductPrice.Size = new Size(156, 27);
            tb_ProductPrice.TabIndex = 2;
            // 
            // tb_ProductDecription
            // 
            tb_ProductDecription.Location = new Point(139, 260);
            tb_ProductDecription.Multiline = true;
            tb_ProductDecription.Name = "tb_ProductDecription";
            tb_ProductDecription.Size = new Size(216, 91);
            tb_ProductDecription.TabIndex = 4;
            // 
            // tb_ProductSearch
            // 
            tb_ProductSearch.Location = new Point(116, 33);
            tb_ProductSearch.Name = "tb_ProductSearch";
            tb_ProductSearch.Size = new Size(492, 27);
            tb_ProductSearch.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(72, 23);
            label1.Name = "label1";
            label1.Size = new Size(247, 31);
            label1.TabIndex = 5;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 6;
            label2.Text = "ProductID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 7;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 175);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 8;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 218);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 9;
            label5.Text = "Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 261);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 10;
            label6.Text = "Decription:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(26, 34);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 11;
            label7.Text = "Search:";
            // 
            // bt_CreatePro
            // 
            bt_CreatePro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_CreatePro.Location = new Point(6, 28);
            bt_CreatePro.Name = "bt_CreatePro";
            bt_CreatePro.Size = new Size(156, 45);
            bt_CreatePro.TabIndex = 0;
            bt_CreatePro.Text = "Create";
            bt_CreatePro.UseVisualStyleBackColor = true;
            // 
            // bt_UpdatePro
            // 
            bt_UpdatePro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_UpdatePro.Location = new Point(199, 28);
            bt_UpdatePro.Name = "bt_UpdatePro";
            bt_UpdatePro.Size = new Size(156, 45);
            bt_UpdatePro.TabIndex = 1;
            bt_UpdatePro.Text = "Delete";
            bt_UpdatePro.UseVisualStyleBackColor = true;
            // 
            // bt_DeletePro
            // 
            bt_DeletePro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_DeletePro.Location = new Point(6, 89);
            bt_DeletePro.Name = "bt_DeletePro";
            bt_DeletePro.Size = new Size(156, 45);
            bt_DeletePro.TabIndex = 2;
            bt_DeletePro.Text = "Delete";
            bt_DeletePro.UseVisualStyleBackColor = true;
            // 
            // bt_ResetPro
            // 
            bt_ResetPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_ResetPro.Location = new Point(199, 89);
            bt_ResetPro.Name = "bt_ResetPro";
            bt_ResetPro.Size = new Size(156, 45);
            bt_ResetPro.TabIndex = 3;
            bt_ResetPro.Text = "Reset";
            bt_ResetPro.UseVisualStyleBackColor = true;
            // 
            // bt_SearchPro
            // 
            bt_SearchPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_SearchPro.Location = new Point(116, 79);
            bt_SearchPro.Name = "bt_SearchPro";
            bt_SearchPro.Size = new Size(156, 45);
            bt_SearchPro.TabIndex = 5;
            bt_SearchPro.Text = "Search";
            bt_SearchPro.UseVisualStyleBackColor = true;
            // 
            // bt_LogoutPro
            // 
            bt_LogoutPro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_LogoutPro.Location = new Point(452, 79);
            bt_LogoutPro.Name = "bt_LogoutPro";
            bt_LogoutPro.Size = new Size(156, 45);
            bt_LogoutPro.TabIndex = 12;
            bt_LogoutPro.Text = "Logout";
            bt_LogoutPro.UseVisualStyleBackColor = true;
            // 
            // cb_ProductType
            // 
            cb_ProductType.FormattingEnabled = true;
            cb_ProductType.Location = new Point(139, 213);
            cb_ProductType.Name = "cb_ProductType";
            cb_ProductType.Size = new Size(151, 28);
            cb_ProductType.TabIndex = 11;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 531);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ProductManagement";
            Text = "Product Management";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tb_ProductDecription;
        private TextBox tb_ProductPrice;
        private TextBox tb_ProductName;
        private TextBox tb_ProductID;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgv_ProductList;
        private GroupBox groupBox4;
        private TextBox tb_ProductSearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_ResetPro;
        private Button bt_DeletePro;
        private Button bt_UpdatePro;
        private Button bt_CreatePro;
        private Button bt_LogoutPro;
        private Button bt_SearchPro;
        private Label label7;
        private ComboBox cb_ProductType;
    }
}