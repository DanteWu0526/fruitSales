namespace practise04
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
            this.saleDateLabel = new System.Windows.Forms.Label();
            this.saleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.showTextBox = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.modifyLabel = new System.Windows.Forms.Label();
            this.modifyTextBox = new System.Windows.Forms.TextBox();
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
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.priceTextBox.Location = new System.Drawing.Point(93, 58);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(104, 27);
            this.priceTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "單價:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quantityTextBox.Location = new System.Drawing.Point(93, 111);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(104, 27);
            this.quantityTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "銷售數量:";
            // 
            // saleDateLabel
            // 
            this.saleDateLabel.AutoSize = true;
            this.saleDateLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saleDateLabel.Location = new System.Drawing.Point(12, 201);
            this.saleDateLabel.Name = "saleDateLabel";
            this.saleDateLabel.Size = new System.Drawing.Size(75, 16);
            this.saleDateLabel.TabIndex = 6;
            this.saleDateLabel.Text = "銷售日期:";
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.saleLabel.Location = new System.Drawing.Point(12, 163);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(95, 19);
            this.saleLabel.TabIndex = 7;
            this.saleLabel.Text = "銷售金額:";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addButton.Location = new System.Drawing.Point(225, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 60);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.readButton.Location = new System.Drawing.Point(225, 78);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(64, 60);
            this.readButton.TabIndex = 10;
            this.readButton.Text = "讀取";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // showTextBox
            // 
            this.showTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showTextBox.Location = new System.Drawing.Point(320, 12);
            this.showTextBox.Multiline = true;
            this.showTextBox.Name = "showTextBox";
            this.showTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showTextBox.Size = new System.Drawing.Size(408, 337);
            this.showTextBox.TabIndex = 11;
            // 
            // modifyButton
            // 
            this.modifyButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modifyButton.Location = new System.Drawing.Point(109, 289);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(64, 60);
            this.modifyButton.TabIndex = 12;
            this.modifyButton.Text = "修改";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // modifyLabel
            // 
            this.modifyLabel.AutoSize = true;
            this.modifyLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modifyLabel.Location = new System.Drawing.Point(44, 247);
            this.modifyLabel.Name = "modifyLabel";
            this.modifyLabel.Size = new System.Drawing.Size(91, 16);
            this.modifyLabel.TabIndex = 13;
            this.modifyLabel.Text = "第幾筆修改:";
            // 
            // modifyTextBox
            // 
            this.modifyTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modifyTextBox.Location = new System.Drawing.Point(141, 244);
            this.modifyTextBox.Name = "modifyTextBox";
            this.modifyTextBox.Size = new System.Drawing.Size(104, 27);
            this.modifyTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifyTextBox);
            this.Controls.Add(this.modifyLabel);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.showTextBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.saleLabel);
            this.Controls.Add(this.saleDateLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fruitTextBox);
            this.Controls.Add(this.fruitLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label saleDateLabel;
        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox showTextBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Label modifyLabel;
        private System.Windows.Forms.TextBox modifyTextBox;
    }
}

