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
using System.Diagnostics;

namespace fruitSales
{
    public partial class Form1 : Form
    {
        #region 銷售資料結構區域
        struct SaleRecord
        {
            public int ItemNo { get; }
            public string FruitName { get; }
            public double Price { get; }
            public int Quantity { get; }
            public double SalesAmount { get; }
            public DateTime SaleDate { get; }

            public SaleRecord(int itemNo, string fruitName, double price, int quantity, double salesAmount, DateTime saleDate)
            {
                ItemNo = itemNo;
                FruitName = fruitName;
                Price = price;
                Quantity = quantity;
                SalesAmount = salesAmount;
                SaleDate = saleDate;
            }
        }
        static string saleData = "sale.txt";
        private List<SaleRecord> records;

        /// <summary>
        /// 資料讀取方式
        /// </summary>
        /// <returns>資料</returns>
        private List<SaleRecord> LoadSaleRecords()
        {
            List<SaleRecord> loadedRecords = new List<SaleRecord>();
            try
            {
                if (File.Exists(saleData))
                {
                    using (StreamReader sr = new StreamReader(saleData))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 6)
                            {
                                int itrmNo = int.Parse(parts[0].Trim());
                                string fruitName = parts[1].Trim();
                                double price = double.Parse(parts[2].Trim());
                                int quantity = int.Parse(parts[3].Trim());
                                double salesAmount = double.Parse(parts[4].Trim());
                                DateTime salesDate = DateTime.Parse(parts[5].Trim());
                                loadedRecords.Add(new SaleRecord(itrmNo,fruitName, price, quantity, salesAmount,salesDate));
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("無舊檔案，請新增");
                return null;
            }
            return loadedRecords;
        }
        #endregion

        string fruitName;
        double price;
        int quantity;
        double salesAmount;
        public Form1()
        {
            InitializeComponent();
            records = LoadSaleRecords();
            InitializeText();
            DisplaySaleRecords();
        }

        /// <summary>
        /// 輸入格初始化
        /// </summary>
        private void InitializeText()
        {
            fruitTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }

        #region 銷售各項功能區域
        /// <summary>
        /// 新增銷售邏輯
        /// </summary>
        private void AddSaleRecord()
        {
            int itemNo = records.Count + 1;
            fruitName = fruitTextBox.Text;
            if (string.IsNullOrWhiteSpace(fruitName) || string.IsNullOrEmpty(fruitName))
            {
                MessageBox.Show("無效水果名稱");
                return;
            }

            try
            {
                price = double.Parse(priceTextBox.Text);
            }
            catch
            {
                if (price == 0)
                {
                    MessageBox.Show("單價輸入錯誤");
                    return;
                }
            }

            try
            {
                quantity = int.Parse(quantityTextBox.Text);
                salesAmount = price * quantity;
            }
            catch
            {
                if(quantity == 0)
                {
                    MessageBox.Show("銷售數量輸入錯誤");
                    return;
                }
            }
            DateTime salesDate = DateTime.Now;
            records.Add(new SaleRecord(itemNo, fruitName, price, quantity, salesAmount, salesDate));
            SaveSaleRecords();
            DisplaySaleRecords();

        }

        /// <summary>
        /// 紀錄銷售
        /// </summary>
        private void SaveSaleRecords()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(saleData))
                {
                    foreach (SaleRecord record in records)
                    {
                        sw.WriteLine($"{record.ItemNo}, {record.FruitName}, {record.Price}, {record.Quantity}, {record.SalesAmount}, {record.SaleDate}");
                    }
                    InitializeText();
                }
            }
            catch 
            {
                MessageBox.Show("存檔失敗");
            }
        }

        /// <summary>
        /// 顯示銷售明細
        /// </summary>
        private void DisplaySaleRecords()
        {
            DataTable table = new DataTable();
            table.Columns.Add("輸入項序");
            table.Columns.Add("水果名稱");
            table.Columns.Add("單價");
            table.Columns.Add("數量");
            table.Columns.Add("銷售金額");
            table.Columns.Add("銷售日期");

            foreach (SaleRecord record in records)
            {
                table.Rows.Add(record.ItemNo,record.FruitName, record.Price, record.Quantity, record.SalesAmount,record.SaleDate);
            }
            dataGridView1.DataSource = table;
        }

        private void ModifySaleRecord()
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            int itemNo = records.Count + 1;
            string friuitName = fruitTextBox.Text;
            double price = double.Parse(priceTextBox.Text);
            int quantity = int.Parse(quantityTextBox.Text);
            double salesAmount = price * quantity;
            DateTime salesDate = DateTime.Now;

            records[selectedIndex] = new SaleRecord(itemNo,friuitName,price,quantity,salesAmount,salesDate);
            SaveSaleRecords();
            DisplaySaleRecords();
        }
        #endregion

        #region 各項排序區域
        /// <summary>
        /// 依輸入順序排序
        /// </summary>
        private void SortByInputOrder()
        {
            records = records.OrderBy(records => records.ItemNo).ToList();
            DisplaySaleRecords();
        }

        /// <summary>
        /// 依水果名排序
        /// </summary>
        private void SortByFruitName()
        {
            records = records.OrderBy(record => record.FruitName).ToList();
            DisplaySaleRecords() ;
        }

        /// <summary>
        /// 依單價排序
        /// </summary>
        private void SortByPrice()
        {
            records = records.OrderByDescending(records => records.Price).ToList();
            DisplaySaleRecords() ;
        }

        /// <summary>
        /// 依銷售額排序功能
        /// </summary>
        private void SortBySalesAmount()
        {
            records = records.OrderByDescending(records => records.SalesAmount).ToList();
            DisplaySaleRecords() ;
        }

        /// <summary>
        /// 依銷售日期排序
        /// </summary>
        private void SortBySaleDate()
        {
            records = records.OrderBy(records => records.SaleDate).ToList();
            DisplaySaleRecords() ;
        }
        #endregion

        #region 輸入方式鎖定
        private void OnlyInputLiteral(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void OnlyInputNum(KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar >57) & (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region 按鈕及表單控制區域
        private void fruitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyInputLiteral(e);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyInputNum(e);
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyInputNum(e);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddSaleRecord();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            InitializeText();
        }

        private void sortBySalesButton_Click(object sender, EventArgs e)
        {
            SortBySalesAmount();
        }

        private void sortByFruitNameButton_Click(object sender, EventArgs e)
        {
            SortByFruitName();
        }

        private void sortByPriceButton_Click(object sender, EventArgs e)
        {
            SortByPrice();
        }

        private void sortByInputButton_Click(object sender, EventArgs e)
        {
            SortByInputOrder();
        }

        private void sortBySalesDateButton_Click(object sender, EventArgs e)
        {
            SortBySaleDate();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            ModifySaleRecord();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
            if (selectedIndex < records.Count)
            {
                fruitTextBox.Text = records[selectedIndex].FruitName;
                priceTextBox.Text = records[selectedIndex].Price.ToString();
                quantityTextBox.Text = records[selectedIndex].Quantity.ToString();
            }
            else
            {
                MessageBox.Show("所選取位置無資料，請重新選取");
            }
        }
        #endregion

    }
}
