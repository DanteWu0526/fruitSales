using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practise04
{
    public partial class Form1 : Form
    {
        class SaleRecord
        {
            public int ItemNo { get; set; }
            public string FruitName { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public double SalesAmount { get; set; }
            public DateTime SaleDate { get; set; }

            public SaleRecord(string fruitName, double price, int quantity, double salesAmount, DateTime saleDate, int itemNo)
            {
                FruitName = fruitName;
                Price = price;
                Quantity = quantity;
                SalesAmount = salesAmount;
                SaleDate = saleDate;
                ItemNo = itemNo;
            }
        }

        static List<SaleRecord> records = new List<SaleRecord>();
        static string saleData = "sale.txt";
        public Form1()
        {
            InitializeComponent();
            InitializeText();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fruitName = fruitTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);
            double saleAmount = price * quantity;
            DateTime saleDate = DateTime.Now;
            //int itemNo = 0;
            /*List<SaleRecord> records = new List<SaleRecord>();
            try
            {
                if (File.Exists(saleData))
                {
                    using (StreamReader sr = new StreamReader(saleData))
                    {
                        if (sr.EndOfStream)
                        {
                            int itemNo;
                            
                        }
                    }
                        string line;

                }

            }
            catch
            {

            }*/
            records.Add(new SaleRecord(fruitName,price,quantity,saleAmount,saleDate,records.Count));
            SaveSale();
            MessageBox.Show("以新增銷售紀錄");

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            LoadSale();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            InitializeText();

        }

        void InitializeText()
        {
            fruitTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
            saleLabel.Text = "銷售金額:";
            saleDateLabel.Text = "銷售日期:";
        }

        void SaveSale()
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(saleData))
                {
                    string str;
                    int itemNo = 1;
                    foreach (SaleRecord record in records)
                    {
                        if (record.ItemNo != 0)
                        {
                            record.ItemNo += itemNo;
                            str = String.Format("{0},{1},{2},{3},{4},{5}",
                                record.FruitName, record.Price, record.Quantity, record.SalesAmount, record.SaleDate, (record.ItemNo));
                        }
                        else
                        {
                            str = String.Format("{0},{1},{2},{3},{4},{5}",
                                record.FruitName, record.Price, record.Quantity, record.SalesAmount, record.SaleDate, (record.ItemNo + 1));
                        }
                        sr.WriteLine(str);
                        saleLabel.Text = "銷售金額:" + record.SalesAmount + "元";
                        saleDateLabel.Text = "銷售日期:" + record.SaleDate;

                    }
                }
            }
            catch
            {
                MessageBox.Show("儲存失敗");
            }
        }

        void LoadSale()
        {
            List<SaleRecord> records = new List<SaleRecord>();
            try
            {
                if (File.Exists(saleData))
                {

                    using (StreamReader sr = new StreamReader(saleData))
                    {
                        string line;
                        int itemNo;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 6)
                            {
                                string fruitName = parts[0].Trim();
                                double price = double.Parse(parts[1].Trim());
                                int quantity = int.Parse(parts[2].Trim());
                                double saleAmount = double.Parse(parts[3].Trim());
                                DateTime saleDate = DateTime.Parse(parts[4].Trim());
                                itemNo = int.Parse(parts[5].Trim());
                                records.Add(new SaleRecord(fruitName, price, quantity, saleAmount, saleDate, itemNo));
                                showTextBox.AppendText(String.Format
                                    ("---第{5}筆開始---\r\n購買水果名稱:{0} \r\n單價:{1}元 \r\n購買數量:{2}個 \r\n總金額:{3}元 \r\n購買日期:{4} \r\n" +
                                    "---第{5}筆結束---\r\n",
                                    fruitName, price, quantity, saleAmount, saleDate, itemNo));
                            }
                        }

                    }
                }
                else
                    MessageBox.Show("無此檔案");
            }
            catch
            {
                MessageBox.Show("讀取失敗");
            }
        }
    }
}
