namespace NewspaperSellerSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOfNewspapers_txt = new System.Windows.Forms.TextBox();
            this.numOfRecords_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchasePrice_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sellingPrice_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scrapPrice_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.good_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fair_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.poor_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.demandDists_dgv = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.results_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rand_day_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rand_demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lost_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salvage_of_scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daily_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDists_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.results_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of newspapers:";
            // 
            // numOfNewspapers_txt
            // 
            this.numOfNewspapers_txt.Location = new System.Drawing.Point(140, 28);
            this.numOfNewspapers_txt.Name = "numOfNewspapers_txt";
            this.numOfNewspapers_txt.Size = new System.Drawing.Size(36, 20);
            this.numOfNewspapers_txt.TabIndex = 1;
            // 
            // numOfRecords_txt
            // 
            this.numOfRecords_txt.Location = new System.Drawing.Point(140, 59);
            this.numOfRecords_txt.Name = "numOfRecords_txt";
            this.numOfRecords_txt.Size = new System.Drawing.Size(36, 20);
            this.numOfRecords_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of records:";
            // 
            // purchasePrice_txt
            // 
            this.purchasePrice_txt.Location = new System.Drawing.Point(140, 91);
            this.purchasePrice_txt.Name = "purchasePrice_txt";
            this.purchasePrice_txt.Size = new System.Drawing.Size(36, 20);
            this.purchasePrice_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchase price:";
            // 
            // sellingPrice_txt
            // 
            this.sellingPrice_txt.Location = new System.Drawing.Point(140, 122);
            this.sellingPrice_txt.Name = "sellingPrice_txt";
            this.sellingPrice_txt.Size = new System.Drawing.Size(36, 20);
            this.sellingPrice_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selling price:";
            // 
            // scrapPrice_txt
            // 
            this.scrapPrice_txt.Location = new System.Drawing.Point(140, 156);
            this.scrapPrice_txt.Name = "scrapPrice_txt";
            this.scrapPrice_txt.Size = new System.Drawing.Size(36, 20);
            this.scrapPrice_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Scrap price:";
            // 
            // good_txt
            // 
            this.good_txt.Location = new System.Drawing.Point(69, 28);
            this.good_txt.Name = "good_txt";
            this.good_txt.Size = new System.Drawing.Size(36, 20);
            this.good_txt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Good:";
            // 
            // fair_txt
            // 
            this.fair_txt.Location = new System.Drawing.Point(69, 60);
            this.fair_txt.Name = "fair_txt";
            this.fair_txt.Size = new System.Drawing.Size(36, 20);
            this.fair_txt.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fair:";
            // 
            // poor_txt
            // 
            this.poor_txt.Location = new System.Drawing.Point(69, 91);
            this.poor_txt.Name = "poor_txt";
            this.poor_txt.Size = new System.Drawing.Size(36, 20);
            this.poor_txt.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Poor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.poor_txt);
            this.groupBox1.Controls.Add(this.good_txt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.fair_txt);
            this.groupBox1.Location = new System.Drawing.Point(229, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day Type Distributions";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numOfNewspapers_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.scrapPrice_txt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numOfRecords_txt);
            this.groupBox2.Controls.Add(this.sellingPrice_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.purchasePrice_txt);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 198);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation Inputs";
            // 
            // demandDists_dgv
            // 
            this.demandDists_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandDists_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand,
            this.good,
            this.fair,
            this.poor});
            this.demandDists_dgv.Location = new System.Drawing.Point(397, 40);
            this.demandDists_dgv.Name = "demandDists_dgv";
            this.demandDists_dgv.Size = new System.Drawing.Size(443, 170);
            this.demandDists_dgv.TabIndex = 20;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            // 
            // good
            // 
            this.good.HeaderText = "Good";
            this.good.Name = "good";
            // 
            // fair
            // 
            this.fair.HeaderText = "Fair";
            this.fair.Name = "fair";
            // 
            // poor
            // 
            this.poor.HeaderText = "Poor";
            this.poor.Name = "poor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Demand Distributions:";
            // 
            // results_dgv
            // 
            this.results_dgv.AllowUserToAddRows = false;
            this.results_dgv.AllowUserToDeleteRows = false;
            this.results_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.results_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.day,
            this.rand_day_type,
            this.day_type,
            this.rand_demand,
            this.out_demand,
            this.revenue,
            this.lost_profit,
            this.salvage_of_scrap,
            this.daily_profit});
            this.results_dgv.Location = new System.Drawing.Point(12, 225);
            this.results_dgv.Name = "results_dgv";
            this.results_dgv.ReadOnly = true;
            this.results_dgv.RowHeadersVisible = false;
            this.results_dgv.Size = new System.Drawing.Size(828, 271);
            this.results_dgv.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 46);
            this.button2.TabIndex = 24;
            this.button2.Text = "Measure Performance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 46);
            this.button3.TabIndex = 25;
            this.button3.Text = "Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 50;
            // 
            // rand_day_type
            // 
            this.rand_day_type.HeaderText = "Random News Day Type";
            this.rand_day_type.Name = "rand_day_type";
            this.rand_day_type.ReadOnly = true;
            // 
            // day_type
            // 
            this.day_type.HeaderText = "News Day Type";
            this.day_type.Name = "day_type";
            this.day_type.ReadOnly = true;
            // 
            // rand_demand
            // 
            this.rand_demand.HeaderText = "Random Demand";
            this.rand_demand.Name = "rand_demand";
            this.rand_demand.ReadOnly = true;
            // 
            // out_demand
            // 
            this.out_demand.HeaderText = "Demand";
            this.out_demand.Name = "out_demand";
            this.out_demand.ReadOnly = true;
            // 
            // revenue
            // 
            this.revenue.HeaderText = "Sales Profit";
            this.revenue.Name = "revenue";
            this.revenue.ReadOnly = true;
            // 
            // lost_profit
            // 
            this.lost_profit.HeaderText = "Lost Profit";
            this.lost_profit.Name = "lost_profit";
            this.lost_profit.ReadOnly = true;
            // 
            // salvage_of_scrap
            // 
            this.salvage_of_scrap.HeaderText = "Scrap Profit";
            this.salvage_of_scrap.Name = "salvage_of_scrap";
            this.salvage_of_scrap.ReadOnly = true;
            // 
            // daily_profit
            // 
            this.daily_profit.HeaderText = "Daily Profit";
            this.daily_profit.Name = "daily_profit";
            this.daily_profit.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.results_dgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.demandDists_dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDists_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.results_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numOfNewspapers_txt;
        private System.Windows.Forms.TextBox numOfRecords_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purchasePrice_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sellingPrice_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scrapPrice_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox good_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fair_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox poor_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView demandDists_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn good;
        private System.Windows.Forms.DataGridViewTextBoxColumn fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn poor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView results_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn rand_day_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn rand_demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn lost_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn salvage_of_scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn daily_profit;
    }
}