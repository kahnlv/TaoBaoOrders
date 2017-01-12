namespace TaoBaoOrders
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrderList = new System.Windows.Forms.Label();
            this.lblOrderDetail = new System.Windows.Forms.Label();
            this.txtOrderList = new System.Windows.Forms.TextBox();
            this.txtOrderDetail = new System.Windows.Forms.TextBox();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnOrderDetail = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(13, 13);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(53, 12);
            this.lblOrderList.TabIndex = 0;
            this.lblOrderList.Text = "订单列表";
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.AutoSize = true;
            this.lblOrderDetail.Location = new System.Drawing.Point(13, 47);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Size = new System.Drawing.Size(53, 12);
            this.lblOrderDetail.TabIndex = 1;
            this.lblOrderDetail.Text = "订单详情";
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(72, 10);
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ReadOnly = true;
            this.txtOrderList.Size = new System.Drawing.Size(449, 21);
            this.txtOrderList.TabIndex = 0;
            this.txtOrderList.Text = "请选择ExportOrderListXXXXX.csv文件";
            // 
            // txtOrderDetail
            // 
            this.txtOrderDetail.Location = new System.Drawing.Point(72, 44);
            this.txtOrderDetail.Name = "txtOrderDetail";
            this.txtOrderDetail.ReadOnly = true;
            this.txtOrderDetail.Size = new System.Drawing.Size(449, 21);
            this.txtOrderDetail.TabIndex = 2;
            this.txtOrderDetail.Text = "请选择ExportOrderDetailListXXXXX.csv文件";
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(527, 8);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(75, 23);
            this.btnOrderList.TabIndex = 2;
            this.btnOrderList.Text = "浏览...";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.Location = new System.Drawing.Point(527, 42);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnOrderDetail.TabIndex = 3;
            this.btnOrderDetail.Text = "浏览...";
            this.btnOrderDetail.UseVisualStyleBackColor = true;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(445, 74);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(157, 26);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 112);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnOrderDetail);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.txtOrderDetail);
            this.Controls.Add(this.txtOrderList);
            this.Controls.Add(this.lblOrderDetail);
            this.Controls.Add(this.lblOrderList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "淘宝订单整合";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.Label lblOrderDetail;
        private System.Windows.Forms.TextBox txtOrderList;
        private System.Windows.Forms.TextBox txtOrderDetail;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnOrderDetail;
        private System.Windows.Forms.Button btnExport;
    }
}

