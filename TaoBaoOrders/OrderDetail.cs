namespace TaoBaoOrders
{
    public class OrderDetail
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderId { get; set; } = ""; 

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// 购买数量
        /// </summary>
        public int BuyCount { get; set; } = 0;

        /// <summary>
        /// 外部系统编号
        /// </summary>
        public string OutSystemId { get; set; } = "";

        /// <summary>
        /// 商品属性
        /// </summary>
        public string OrderAttribute { get; set; } = "";

        /// <summary>
        /// 套餐信息
        /// </summary>
        public string Package { get; set; } = "";

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; } = "";

        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderStatus { get; set; } = "";

        /// <summary>
        /// 商家编码
        /// </summary>
        public string MerchantCode { get; set; } = "";
    }
}
