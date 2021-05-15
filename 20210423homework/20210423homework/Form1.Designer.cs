
namespace _20210423homework
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_startUrl = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.dgv_crawledUrl = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crawledUrl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "爬取网址";
            // 
            // tb_startUrl
            // 
            this.tb_startUrl.Location = new System.Drawing.Point(98, 19);
            this.tb_startUrl.Name = "tb_startUrl";
            this.tb_startUrl.Size = new System.Drawing.Size(546, 27);
            this.tb_startUrl.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(663, 18);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(94, 29);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "开爬";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // dgv_crawledUrl
            // 
            this.dgv_crawledUrl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_crawledUrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_crawledUrl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.URL,
            this.Info});
            this.dgv_crawledUrl.Location = new System.Drawing.Point(23, 63);
            this.dgv_crawledUrl.Name = "dgv_crawledUrl";
            this.dgv_crawledUrl.RowHeadersWidth = 51;
            this.dgv_crawledUrl.RowTemplate.Height = 29;
            this.dgv_crawledUrl.Size = new System.Drawing.Size(769, 397);
            this.dgv_crawledUrl.TabIndex = 3;
            this.dgv_crawledUrl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_crawledUrl_CellContentClick);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "Index";
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 6;
            this.序号.Name = "序号";
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            // 
            // Info
            // 
            this.Info.DataPropertyName = "Status";
            this.Info.HeaderText = "状态";
            this.Info.MinimumWidth = 6;
            this.Info.Name = "Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 472);
            this.Controls.Add(this.dgv_crawledUrl);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_startUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_crawledUrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_startUrl;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DataGridView dgv_crawledUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
    }
}

