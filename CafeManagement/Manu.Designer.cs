namespace CafeManagement
{
    partial class Manu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtquanty = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnaddCart = new System.Windows.Forms.Button();
            this.dataGridManuOption = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.txtOredrNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.btnItme = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridManuOption)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtquanty);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnaddCart);
            this.panel1.Controls.Add(this.dataGridManuOption);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtcustomerName);
            this.panel1.Controls.Add(this.txtOredrNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCat);
            this.panel1.Location = new System.Drawing.Point(140, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 807);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Location = new System.Drawing.Point(843, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // txtquanty
            // 
            this.txtquanty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquanty.Location = new System.Drawing.Point(498, 373);
            this.txtquanty.Name = "txtquanty";
            this.txtquanty.Size = new System.Drawing.Size(135, 27);
            this.txtquanty.TabIndex = 16;
            this.txtquanty.Text = "Quantity";
            this.txtquanty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtquanty.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(603, 772);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "View Orders";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(438, 777);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(149, 22);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = " Rs Total Amount";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 772);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Place the Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView2.Location = new System.Drawing.Point(219, 503);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(659, 243);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnaddCart
            // 
            this.btnaddCart.BackColor = System.Drawing.Color.Brown;
            this.btnaddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddCart.Location = new System.Drawing.Point(498, 416);
            this.btnaddCart.Name = "btnaddCart";
            this.btnaddCart.Size = new System.Drawing.Size(135, 35);
            this.btnaddCart.TabIndex = 10;
            this.btnaddCart.Text = "Add To Cart";
            this.btnaddCart.UseVisualStyleBackColor = false;
            this.btnaddCart.Click += new System.EventHandler(this.btnaddCart_Click);
            // 
            // dataGridManuOption
            // 
            this.dataGridManuOption.BackgroundColor = System.Drawing.Color.White;
            this.dataGridManuOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridManuOption.Location = new System.Drawing.Point(255, 62);
            this.dataGridManuOption.Name = "dataGridManuOption";
            this.dataGridManuOption.RowHeadersWidth = 51;
            this.dataGridManuOption.RowTemplate.Height = 24;
            this.dataGridManuOption.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridManuOption.Size = new System.Drawing.Size(615, 243);
            this.dataGridManuOption.TabIndex = 8;
            this.dataGridManuOption.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridManuOption_CellClick);
            this.dataGridManuOption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridManuOption_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(143, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerName.Location = new System.Drawing.Point(16, 162);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(122, 27);
            this.txtcustomerName.TabIndex = 6;
            this.txtcustomerName.Text = "Seller Name";
            this.txtcustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOredrNo
            // 
            this.txtOredrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOredrNo.Location = new System.Drawing.Point(15, 114);
            this.txtOredrNo.Name = "txtOredrNo";
            this.txtOredrNo.Size = new System.Drawing.Size(122, 27);
            this.txtOredrNo.TabIndex = 5;
            this.txtOredrNo.Text = "OrderNo";
            this.txtOredrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOredrNo.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(460, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Place Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(512, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Your Order";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Items.AddRange(new object[] {
            "Beverage ",
            "Food "});
            this.comboBoxCat.Location = new System.Drawing.Point(16, 62);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCat.TabIndex = 0;
            this.comboBoxCat.Text = "Category";
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            this.comboBoxCat.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCat_SelectionChangeCommitted);
            // 
            // btnItme
            // 
            this.btnItme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItme.Location = new System.Drawing.Point(25, 50);
            this.btnItme.Name = "btnItme";
            this.btnItme.Size = new System.Drawing.Size(83, 35);
            this.btnItme.TabIndex = 1;
            this.btnItme.Text = "Items";
            this.btnItme.UseVisualStyleBackColor = true;
            this.btnItme.Click += new System.EventHandler(this.btnItme_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(25, 109);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(83, 35);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(12, 811);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(109, 32);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1022, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1047, 858);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnItme);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manu";
            this.Load += new System.EventHandler(this.Manu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridManuOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnItme;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.TextBox txtOredrNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.DataGridView dataGridManuOption;
        private System.Windows.Forms.Button btnaddCart;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtquanty;
        private System.Windows.Forms.Label lblDate;
    }
}