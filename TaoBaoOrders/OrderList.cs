using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaoBaoOrders
{
    public class OrderList 
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; } = "";

        /// <summary>
        /// 买家会员名
        /// </summary>
        public string BuyUserName { get; set; } = "";

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        public string BuyAccount { get; set; } = "";

        /// <summary>
        /// 总金额
        /// </summary>
        public decimal TotalAmount { get; set; } = 0;

        /// <summary>
        /// 实付
        /// </summary>
        public decimal Paid { get; set; } = 0;

        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderStatue { get; set; } = "";

        /// <summary>
        /// 买家留言
        /// </summary>
        public string BuyRemark { get; set; } = "";

        /// <summary>
        /// 收货人
        /// </summary>
        public string Consignee { get; set; } = "";

        /// <summary>
        /// 收货地址
        /// </summary>
        public string Address { get; set; } = "";

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; } = "";

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// 订单备注
        /// </summary>
        public string OrderRemark { get; set; } = "";

        /// <summary>
        /// 宝贝总数量
        /// </summary>
        public int BuyCount { get; set; } = 0;
    }
}
