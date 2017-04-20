﻿namespace StockTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._listViewStocks = new System.Windows.Forms.ListView();
            this.Ticker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this._textBoxTicker = new System.Windows.Forms.TextBox();
            this._buttonAddTicker = new System.Windows.Forms.Button();
            this._textBoxShares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Shares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // _listViewStocks
            // 
            this._listViewStocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ticker,
            this.Quote,
            this.Shares,
            this.Value});
            this._listViewStocks.Location = new System.Drawing.Point(12, 138);
            this._listViewStocks.Name = "_listViewStocks";
            this._listViewStocks.Size = new System.Drawing.Size(761, 288);
            this._listViewStocks.TabIndex = 0;
            this._listViewStocks.UseCompatibleStateImageBehavior = false;
            this._listViewStocks.View = System.Windows.Forms.View.Details;
            // 
            // Ticker
            // 
            this.Ticker.Text = "Ticker";
            this.Ticker.Width = 120;
            // 
            // Quote
            // 
            this.Quote.Text = "Quote";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Ticker:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(798, 138);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.RefreshValues);
            // 
            // _textBoxTicker
            // 
            this._textBoxTicker.Location = new System.Drawing.Point(107, 22);
            this._textBoxTicker.Name = "_textBoxTicker";
            this._textBoxTicker.Size = new System.Drawing.Size(100, 22);
            this._textBoxTicker.TabIndex = 4;
            this._textBoxTicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TickerKeyPress);
            // 
            // _buttonAddTicker
            // 
            this._buttonAddTicker.Location = new System.Drawing.Point(241, 53);
            this._buttonAddTicker.Name = "_buttonAddTicker";
            this._buttonAddTicker.Size = new System.Drawing.Size(75, 23);
            this._buttonAddTicker.TabIndex = 5;
            this._buttonAddTicker.Text = "Add";
            this._buttonAddTicker.UseVisualStyleBackColor = true;
            this._buttonAddTicker.Click += new System.EventHandler(this.AddTicker);
            // 
            // _textBoxShares
            // 
            this._textBoxShares.Location = new System.Drawing.Point(107, 56);
            this._textBoxShares.Name = "_textBoxShares";
            this._textBoxShares.Size = new System.Drawing.Size(100, 22);
            this._textBoxShares.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Shares:";
            // 
            // Shares
            // 
            this.Shares.Text = "Shares";
            // 
            // Value
            // 
            this.Value.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 451);
            this.Controls.Add(this._textBoxShares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._buttonAddTicker);
            this.Controls.Add(this._textBoxTicker);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._listViewStocks);
            this.Name = "Form1";
            this.Text = "Stock Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _listViewStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox _textBoxTicker;
        private System.Windows.Forms.ColumnHeader Ticker;
        private System.Windows.Forms.ColumnHeader Quote;
        private System.Windows.Forms.Button _buttonAddTicker;
        private System.Windows.Forms.ColumnHeader Shares;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.TextBox _textBoxShares;
        private System.Windows.Forms.Label label3;
    }
}

