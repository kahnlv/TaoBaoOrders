using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TaoBaoOrders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            OpenFileDialog(1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (txtOrderList.Text.Length == 0)
            {
                MessageBox.Show("请选择要整合的订单文件！");
                return;
            }

            if (txtOrderDetail.Text.Length == 0)
            {
                MessageBox.Show("请选择要整合的订单详情文件！");
                return;
            }

            var orderList = ReadOrderListFile(txtOrderList.Text);

            var orderDetailList = ReadOrderDetailFile(txtOrderDetail.Text);

            List<Dictionary<string, object>> filterOrder = new List<Dictionary<string, object>>();

            List<string> orderIds = new List<string>();

            foreach (var o in orderList)
            {
                var newOrder = orderList.FindAll(m => m.Address.Equals(o.Address));
                string orderid = "";
                foreach (var n in newOrder)
                {
                    orderid += n.OrderId + "|";
                }

                orderid = orderid.TrimEnd(new char[] { '|' });

                if (null == orderIds.Find(m => m == orderid))
                {
                    orderIds.Add(orderid);
                }
            }

            foreach (var o in orderIds)
            {
                string[] oids = o.Split('|');
                var orderDetail = orderDetailList.FindAll(m => oids.Contains(m.OrderId));

                Dictionary<string, object> order = new Dictionary<string, object>();

                order.Add("订单号", o);
                order.Add("发货人", "");
                order.Add("发货日期", "");

                List<string> oi = new List<string>();
                foreach (var od in orderDetail)
                {
                    oi.Add(od.OrderAttribute + " " + od.BuyCount + "份");
                }

                order.Add("订单信息", string.Join(";", oi));


                var olist = orderList.FindAll(m => oids.Contains(m.OrderId));

                string remark = "",
                       consignee = "";
                foreach (var ol in olist)
                {
                    if (ol.OrderRemark.Length > 0 || ol.BuyRemark.Length > 0)
                    {
                        remark += "订单号：" + ol.OrderId + (ol.BuyRemark.Length > 0 ? " 买家备注：" + ol.BuyRemark : "") + (ol.OrderRemark.Length > 0 ? "  订单备注：" + ol.OrderRemark : "") + "|";
                    }

                    consignee = KeepChinese(ol.Consignee) + " " + ol.Address + " " + ol.Phone;
                }

                order.Add("收货人信息", consignee);

                order.Add("运单号", "");
                order.Add("快递", "");

                order.Add("备注", remark.TrimEnd(new char[] { '|' }));

                order.Add("售后", "");

                filterOrder.Add(order);
            }
            ExportXls(filterOrder);
            //SaveFile(filterOrder);
        }

        private string KeepChinese(string Consignee)
        {
            string strChinese = "";
            Regex reg = new Regex("[^\x00-\xFF]|[a-zA-Z]");

            foreach (var s in Consignee)
            {
                if (reg.IsMatch(s.ToString()))
                {
                    strChinese += s;
                }
            }

            return strChinese;
        }

        private void ExportXls(List<Dictionary<string, object>> filterOrder, string filePath = "")
        {
            if (filterOrder.Count > 0)
            {
                filePath = filePath.Length == 0 ? DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls" : filePath;

                try
                {
                    HSSFWorkbook book = new HSSFWorkbook();
                    ISheet sheet = book.CreateSheet();
                    IRow headRow = sheet.CreateRow(0);
                    ICellStyle cellStyle = book.CreateCellStyle();
                    IDataFormat format = book.CreateDataFormat();

                    var headKeys = filterOrder[0].Keys;

                    for (int i = 0; i < headKeys.Count; i++)
                    {
                        headRow.CreateCell(i).SetCellValue(headKeys.ElementAt(i));
                    }

                    for (int i = 0; i < filterOrder.Count; i++)
                    {
                        IRow row = sheet.CreateRow(i + 1);
                        var keys = filterOrder[i].Keys;

                        for (int j = 0; j < keys.Count; j++)
                        {
                            object o;
                            filterOrder[i].TryGetValue(keys.ElementAt(j), out o);
                            if ((o + "").Length > 0)
                            {
                                cellStyle.DataFormat = format.GetFormat("@");

                                row.CreateCell(j).SetCellValue(o as string);
                            }
                        }
                    }

                    using (MemoryStream ms = new MemoryStream())
                    {
                        book.Write(ms);
                        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                        {
                            byte[] data = ms.ToArray();
                            fs.Write(data, 0, data.Length);
                            fs.Flush();
                        }
                        book = null;
                    }

                    MessageBox.Show("导出成功，请到程序文件夹下查看！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void SaveFile(List<Dictionary<string, object>> filterOrder, string filePath = "")
        {
            filePath = filePath.Length == 0 ? DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv" : filePath;

            FileInfo fi = new FileInfo(filePath);

            if (!fi.Directory.Exists)
            {
                fi.Directory.Create();
            }

            string data = "";
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    if (filterOrder.Count > 0)
                    {
                        foreach (var key in filterOrder[0].Keys)
                        {
                            data += key + ",";
                        }
                    }
                    sw.WriteLine(data);
                    foreach (var value in filterOrder)
                    {
                        data = "";
                        foreach (var key in value.Keys)
                        {
                            object o;
                            value.TryGetValue(key, out o);
                            data += "\"'" + o.ToString() + "\",";
                        }
                        sw.WriteLine(data);
                    }

                }
            }

            MessageBox.Show("导出成功，请到程序文件夹下查看！");
        }

        #region 读取文件
        private void OpenFileDialog(int index = 0)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.csv;*.xls;*.xlsx|所有文件|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (index == 0) { txtOrderList.Text = ofd.FileName; } else { txtOrderDetail.Text = ofd.FileName; };
            }
        }

        private List<OrderDetail> ReadOrderDetailFile(string path)
        {
            List<OrderDetail> list = new List<OrderDetail>();

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line = "";
                    string[] content;
                    int i = 0;

                    while (null != (line = sr.ReadLine()))
                    {
                        if (i == 0)
                        {
                            i++;
                        }
                        else
                        {
                            OrderDetail order = new OrderDetail();
                            content = line.Split(',');

                            order.OrderId = getString(content[0]);
                            order.Title = getString(content[1]);
                            order.Price = getDecimal(content[2]);
                            order.BuyCount = getInt(content[3]);
                            order.OutSystemId = getString(content[4]);
                            order.OrderAttribute = getString(content[5]);
                            order.Package = getString(content[6]);
                            order.Remark = getString(content[7]);
                            order.OrderStatus = getString(content[8]);
                            order.MerchantCode = getString(content[9]);

                            list.Add(order);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        private List<OrderList> ReadOrderListFile(string path)
        {
            List<OrderList> list = new List<OrderList>();
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    string line = "", address = "", phone = ""; ;
                    string[] content;
                    int i = 0;

                    while (null != (line = sr.ReadLine()))
                    {
                        if (i == 0)
                        {
                            i++;
                        }
                        else
                        {
                            OrderList order = new OrderList();
                            content = line.Split(',');

                            order.OrderId = getString(content[0]);
                            order.BuyUserName = getString(content[1]);
                            order.BuyAccount = getString(content[2]);
                            order.TotalAmount = getDecimal(content[6]);
                            order.Paid = getDecimal(content[8]);
                            order.OrderStatue = getString(content[10]);
                            order.BuyRemark = getString(content[11]);
                            order.Consignee = getString(content[12]);

                            address = getString(content[39]);

                            if ((address + "").Length == 0)
                            {
                                address = getString(content[13]);
                            }

                            order.Address = address;

                            phone = getString(content[16]);

                            if ((phone + "").Length == 0)
                            {
                                phone = getString(content[15]);
                            }

                            order.Phone = phone;
                            order.Title = getString(content[19]);
                            order.OrderRemark = getString(content[23]);
                            order.BuyCount = getInt(content[24]);


                            list.Add(order);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return list;
        }

        private string getString(string value)
        {
            value = value.Replace("=", "").Replace("\"", "").Replace("'", "");

            return value;
        }

        private decimal getDecimal(string value)
        {
            decimal decimalValue = 0;

            value = value.Replace("=", "").Replace("\"", "");

            decimal.TryParse(value, out decimalValue);

            return decimalValue;
        }

        private int getInt(string value)
        {
            int intValue = 0;

            value = value.Replace("=", "").Replace("\"", "");

            int.TryParse(value, out intValue);

            return intValue;
        }
        #endregion
    }
}
