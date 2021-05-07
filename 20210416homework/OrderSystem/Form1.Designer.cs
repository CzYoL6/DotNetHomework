namespace OrderSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddOrder = new System.Windows.Forms.Button();
            this.btn_DelOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_qbyCost = new System.Windows.Forms.Button();
            this.btn_qbyCusName = new System.Windows.Forms.Button();
            this.btn_qbyID = new System.Windows.Forms.Button();
            this.btn_qall = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.btn_SortByCost = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBox_totCost = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(493, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order System";
            // 
            // btn_AddOrder
            // 
            this.btn_AddOrder.Location = new System.Drawing.Point(50, 655);
            this.btn_AddOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_AddOrder.Name = "btn_AddOrder";
            this.btn_AddOrder.Size = new System.Drawing.Size(128, 27);
            this.btn_AddOrder.TabIndex = 1;
            this.btn_AddOrder.Text = "Add Order";
            this.btn_AddOrder.UseVisualStyleBackColor = true;
            this.btn_AddOrder.Click += new System.EventHandler(this.btn_AddOrder_Click);
            // 
            // btn_DelOrder
            // 
            this.btn_DelOrder.Location = new System.Drawing.Point(187, 655);
            this.btn_DelOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DelOrder.Name = "btn_DelOrder";
            this.btn_DelOrder.Size = new System.Drawing.Size(128, 27);
            this.btn_DelOrder.TabIndex = 2;
            this.btn_DelOrder.Text = "Delete Order";
            this.btn_DelOrder.UseVisualStyleBackColor = true;
            this.btn_DelOrder.Click += new System.EventHandler(this.btn_DelOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_qbyCost);
            this.panel1.Controls.Add(this.btn_qbyCusName);
            this.panel1.Controls.Add(this.btn_qbyID);
            this.panel1.Controls.Add(this.btn_qall);
            this.panel1.Controls.Add(this.textBoxQuery);
            this.panel1.Location = new System.Drawing.Point(1078, 115);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 251);
            this.panel1.TabIndex = 3;
            this.panel1.Tag = "";
            // 
            // btn_qbyCost
            // 
            this.btn_qbyCost.Location = new System.Drawing.Point(27, 203);
            this.btn_qbyCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_qbyCost.Name = "btn_qbyCost";
            this.btn_qbyCost.Size = new System.Drawing.Size(214, 27);
            this.btn_qbyCost.TabIndex = 4;
            this.btn_qbyCost.Text = "Query By Cost";
            this.btn_qbyCost.UseVisualStyleBackColor = true;
            this.btn_qbyCost.Click += new System.EventHandler(this.btn_qbyCost_Click);
            // 
            // btn_qbyCusName
            // 
            this.btn_qbyCusName.Location = new System.Drawing.Point(27, 146);
            this.btn_qbyCusName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_qbyCusName.Name = "btn_qbyCusName";
            this.btn_qbyCusName.Size = new System.Drawing.Size(214, 51);
            this.btn_qbyCusName.TabIndex = 3;
            this.btn_qbyCusName.Text = "Query By Customer Name";
            this.btn_qbyCusName.UseVisualStyleBackColor = true;
            this.btn_qbyCusName.Click += new System.EventHandler(this.btn_qbyCusName_Click);
            // 
            // btn_qbyID
            // 
            this.btn_qbyID.Location = new System.Drawing.Point(27, 112);
            this.btn_qbyID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_qbyID.Name = "btn_qbyID";
            this.btn_qbyID.Size = new System.Drawing.Size(214, 27);
            this.btn_qbyID.TabIndex = 2;
            this.btn_qbyID.Text = "Query By Order ID";
            this.btn_qbyID.UseVisualStyleBackColor = true;
            this.btn_qbyID.Click += new System.EventHandler(this.btn_qbyID_Click);
            // 
            // btn_qall
            // 
            this.btn_qall.Location = new System.Drawing.Point(27, 78);
            this.btn_qall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_qall.Name = "btn_qall";
            this.btn_qall.Size = new System.Drawing.Size(214, 27);
            this.btn_qall.TabIndex = 1;
            this.btn_qall.Text = "Query All";
            this.btn_qall.UseVisualStyleBackColor = true;
            this.btn_qall.Click += new System.EventHandler(this.btn_qall_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(0, 19);
            this.textBoxQuery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(256, 27);
            this.textBoxQuery.TabIndex = 0;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
            // 
            // btn_SortByCost
            // 
            this.btn_SortByCost.Location = new System.Drawing.Point(1127, 387);
            this.btn_SortByCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SortByCost.Name = "btn_SortByCost";
            this.btn_SortByCost.Size = new System.Drawing.Size(162, 27);
            this.btn_SortByCost.TabIndex = 4;
            this.btn_SortByCost.Text = "Sort by Cost";
            this.btn_SortByCost.UseVisualStyleBackColor = true;
            this.btn_SortByCost.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1078, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Query";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 394);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Order Detail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 612);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total Cost";
            // 
            // txtBox_totCost
            // 
            this.txtBox_totCost.Location = new System.Drawing.Point(817, 608);
            this.txtBox_totCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_totCost.Name = "txtBox_totCost";
            this.txtBox_totCost.ReadOnly = true;
            this.txtBox_totCost.Size = new System.Drawing.Size(128, 27);
            this.txtBox_totCost.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(956, 432);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(97, 27);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(956, 489);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(97, 27);
            this.btn_Del.TabIndex = 18;
            this.btn_Del.Text = "Delete";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(50, 432);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(896, 163);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 119);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 247);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 717);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtBox_totCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SortByCost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_DelOrder);
            this.Controls.Add(this.btn_AddOrder);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddOrder;
        private System.Windows.Forms.Button btn_DelOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_qall;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button btn_qbyCost;
        private System.Windows.Forms.Button btn_qbyCusName;
        private System.Windows.Forms.Button btn_qbyID;
        private System.Windows.Forms.Button btn_SortByCost;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBox_totCost;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_Del;
    }
}

