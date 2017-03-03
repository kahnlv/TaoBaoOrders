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
            this.cbSpecial = new System.Windows.Forms.CheckBox();
            this.cbEn = new System.Windows.Forms.CheckBox();
            this.cbIntercept = new System.Windows.Forms.CheckBox();
            this.txtIntercept = new System.Windows.Forms.TextBox();
            this.lblTips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsignor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWangwang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Location = new System.Drawing.Point(13, 40);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(53, 12);
            this.lblOrderList.TabIndex = 14;
            this.lblOrderList.Text = "订单列表";
            // 
            // lblOrderDetail
            // 
            this.lblOrderDetail.AutoSize = true;
            this.lblOrderDetail.Location = new System.Drawing.Point(13, 74);
            this.lblOrderDetail.Name = "lblOrderDetail";
            this.lblOrderDetail.Size = new System.Drawing.Size(53, 12);
            this.lblOrderDetail.TabIndex = 15;
            this.lblOrderDetail.Text = "订单详情";
            // 
            // txtOrderList
            // 
            this.txtOrderList.Location = new System.Drawing.Point(72, 37);
            this.txtOrderList.Name = "txtOrderList";
            this.txtOrderList.ReadOnly = true;
            this.txtOrderList.Size = new System.Drawing.Size(305, 21);
            this.txtOrderList.TabIndex = 3;
            this.txtOrderList.Text = "请选择ExportOrderListXXXXX.csv文件";
            // 
            // txtOrderDetail
            // 
            this.txtOrderDetail.Location = new System.Drawing.Point(72, 71);
            this.txtOrderDetail.Name = "txtOrderDetail";
            this.txtOrderDetail.ReadOnly = true;
            this.txtOrderDetail.Size = new System.Drawing.Size(305, 21);
            this.txtOrderDetail.TabIndex = 5;
            this.txtOrderDetail.Text = "请选择ExportOrderDetailListXXXXX.csv文件";
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(383, 35);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(75, 23);
            this.btnOrderList.TabIndex = 4;
            this.btnOrderList.Text = "浏览...";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnOrderDetail
            // 
            this.btnOrderDetail.Location = new System.Drawing.Point(383, 71);
            this.btnOrderDetail.Name = "btnOrderDetail";
            this.btnOrderDetail.Size = new System.Drawing.Size(75, 23);
            this.btnOrderDetail.TabIndex = 6;
            this.btnOrderDetail.Text = "浏览...";
            this.btnOrderDetail.UseVisualStyleBackColor = true;
            this.btnOrderDetail.Click += new System.EventHandler(this.btnOrderDetail_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(15, 145);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(443, 26);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cbSpecial
            // 
            this.cbSpecial.AutoSize = true;
            this.cbSpecial.Location = new System.Drawing.Point(15, 102);
            this.cbSpecial.Name = "cbSpecial";
            this.cbSpecial.Size = new System.Drawing.Size(96, 16);
            this.cbSpecial.TabIndex = 7;
            this.cbSpecial.Text = "去除特殊字符";
            this.cbSpecial.UseVisualStyleBackColor = true;
            this.cbSpecial.CheckedChanged += new System.EventHandler(this.cbSpecial_CheckedChanged);
            // 
            // cbEn
            // 
            this.cbEn.AutoSize = true;
            this.cbEn.Location = new System.Drawing.Point(118, 101);
            this.cbEn.Name = "cbEn";
            this.cbEn.Size = new System.Drawing.Size(72, 16);
            this.cbEn.TabIndex = 8;
            this.cbEn.Text = "去除英文";
            this.cbEn.UseVisualStyleBackColor = true;
            this.cbEn.CheckedChanged += new System.EventHandler(this.cbEn_CheckedChanged);
            // 
            // cbIntercept
            // 
            this.cbIntercept.AutoSize = true;
            this.cbIntercept.Location = new System.Drawing.Point(196, 101);
            this.cbIntercept.Name = "cbIntercept";
            this.cbIntercept.Size = new System.Drawing.Size(96, 16);
            this.cbIntercept.TabIndex = 9;
            this.cbIntercept.Text = "截取字符长度";
            this.cbIntercept.UseVisualStyleBackColor = true;
            this.cbIntercept.CheckedChanged += new System.EventHandler(this.cbIntercept_CheckedChanged);
            // 
            // txtIntercept
            // 
            this.txtIntercept.Location = new System.Drawing.Point(291, 97);
            this.txtIntercept.MaxLength = 1;
            this.txtIntercept.Name = "txtIntercept";
            this.txtIntercept.ReadOnly = true;
            this.txtIntercept.Size = new System.Drawing.Size(32, 21);
            this.txtIntercept.TabIndex = 10;
            this.txtIntercept.TextChanged += new System.EventHandler(this.txtIntercept_TextChanged);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTips.Location = new System.Drawing.Point(15, 125);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(443, 12);
            this.lblTips.TabIndex = 16;
            this.lblTips.Text = "注意：过滤完以上条件后，如果长度为0将还原为原始值，并对字符截取相应的长度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "发货人";
            // 
            // txtConsignor
            // 
            this.txtConsignor.Location = new System.Drawing.Point(72, 10);
            this.txtConsignor.Name = "txtConsignor";
            this.txtConsignor.Size = new System.Drawing.Size(161, 21);
            this.txtConsignor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "店铺旺旺";
            // 
            // txtWangwang
            // 
            this.txtWangwang.Location = new System.Drawing.Point(298, 10);
            this.txtWangwang.Name = "txtWangwang";
            this.txtWangwang.Size = new System.Drawing.Size(156, 21);
            this.txtWangwang.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 181);
            this.Controls.Add(this.txtWangwang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConsignor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.txtIntercept);
            this.Controls.Add(this.cbIntercept);
            this.Controls.Add(this.cbEn);
            this.Controls.Add(this.cbSpecial);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckBox cbSpecial;
        private System.Windows.Forms.CheckBox cbEn;
        private System.Windows.Forms.CheckBox cbIntercept;
        private System.Windows.Forms.TextBox txtIntercept;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsignor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWangwang;
    }
}

