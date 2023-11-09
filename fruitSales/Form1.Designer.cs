namespace fruitSales
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.fruitLabel = new System.Windows.Forms.Label();
            this.fruitTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.sortBySalesButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delButton = new System.Windows.Forms.Button();
            this.sortByFruitNameButton = new System.Windows.Forms.Button();
            this.sortByInputButton = new System.Windows.Forms.Button();
            this.sortByPriceButton = new System.Windows.Forms.Button();
            this.sortBySalesDateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitLabel
            // 
            this.fruitLabel.AutoSize = true;
            this.fruitLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitLabel.Location = new System.Drawing.Point(12, 15);
            this.fruitLabel.Name = "fruitLabel";
            this.fruitLabel.Size = new System.Drawing.Size(75, 16);
            this.fruitLabel.TabIndex = 0;
            this.fruitLabel.Text = "水果名稱:";
            // 
            // fruitTextBox
            // 
            this.fruitTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fruitTextBox.Location = new System.Drawing.Point(93, 12);
            this.fruitTextBox.Name = "fruitTextBox";
            this.fruitTextBox.Size = new System.Drawing.Size(104, 27);
            this.fruitTextBox.TabIndex = 1;
            this.fruitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fruitTextBox_KeyPress);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(310, 12);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(104, 27);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(261, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "單價:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quantityTextBox.Location = new System.Drawing.Point(580, 12);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(104, 27);
            this.quantityTextBox.TabIndex = 5;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(499, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "銷售數量:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(12, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(70, 35);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sortBySalesButton
            // 
            this.sortBySalesButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sortBySalesButton.Location = new System.Drawing.Point(420, 86);
            this.sortBySalesButton.Name = "sortBySalesButton";
            this.sortBySalesButton.Size = new System.Drawing.Size(129, 34);
            this.sortBySalesButton.TabIndex = 10;
            this.sortBySalesButton.Text = "依銷售額排序";
            this.sortBySalesButton.UseVisualStyleBackColor = true;
            this.sortBySalesButton.Click += new System.EventHandler(this.sortBySalesButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modifyButton.Location = new System.Drawing.Point(179, 45);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(100, 35);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "修改明細";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(669, 294);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.delButton.Location = new System.Drawing.Point(420, 41);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(100, 35);
            this.delButton.TabIndex = 16;
            this.delButton.Text = "清空輸入格";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // sortByFruitNameButton
            // 
            this.sortByFruitNameButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sortByFruitNameButton.Location = new System.Drawing.Point(150, 86);
            this.sortByFruitNameButton.Name = "sortByFruitNameButton";
            this.sortByFruitNameButton.Size = new System.Drawing.Size(129, 34);
            this.sortByFruitNameButton.TabIndex = 17;
            this.sortByFruitNameButton.Text = "依水果名排序";
            this.sortByFruitNameButton.UseVisualStyleBackColor = true;
            this.sortByFruitNameButton.Click += new System.EventHandler(this.sortByFruitNameButton_Click);
            // 
            // sortByInputButton
            // 
            this.sortByInputButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sortByInputButton.Location = new System.Drawing.Point(15, 86);
            this.sortByInputButton.Name = "sortByInputButton";
            this.sortByInputButton.Size = new System.Drawing.Size(129, 34);
            this.sortByInputButton.TabIndex = 18;
            this.sortByInputButton.Text = "依輸入排序";
            this.sortByInputButton.UseVisualStyleBackColor = true;
            this.sortByInputButton.Click += new System.EventHandler(this.sortByInputButton_Click);
            // 
            // sortByPriceButton
            // 
            this.sortByPriceButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sortByPriceButton.Location = new System.Drawing.Point(285, 86);
            this.sortByPriceButton.Name = "sortByPriceButton";
            this.sortByPriceButton.Size = new System.Drawing.Size(129, 34);
            this.sortByPriceButton.TabIndex = 19;
            this.sortByPriceButton.Text = "依單價排序";
            this.sortByPriceButton.UseVisualStyleBackColor = true;
            this.sortByPriceButton.Click += new System.EventHandler(this.sortByPriceButton_Click);
            // 
            // sortBySalesDateButton
            // 
            this.sortBySalesDateButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sortBySalesDateButton.Location = new System.Drawing.Point(555, 86);
            this.sortBySalesDateButton.Name = "sortBySalesDateButton";
            this.sortBySalesDateButton.Size = new System.Drawing.Size(129, 34);
            this.sortBySalesDateButton.TabIndex = 20;
            this.sortBySalesDateButton.Text = "依銷售日期排序";
            this.sortBySalesDateButton.UseVisualStyleBackColor = true;
            this.sortBySalesDateButton.Click += new System.EventHandler(this.sortBySalesDateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortBySalesDateButton);
            this.Controls.Add(this.sortByPriceButton);
            this.Controls.Add(this.sortByInputButton);
            this.Controls.Add(this.sortByFruitNameButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.sortBySalesButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fruitTextBox);
            this.Controls.Add(this.fruitLabel);
            this.Name = "Form1";
            this.Text = "水果銷售";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fruitLabel;
        private System.Windows.Forms.TextBox fruitTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sortBySalesButton;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button sortByFruitNameButton;
        private System.Windows.Forms.Button sortByInputButton;
        private System.Windows.Forms.Button sortByPriceButton;
        private System.Windows.Forms.Button sortBySalesDateButton;
    }
}

