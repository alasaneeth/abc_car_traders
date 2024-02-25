namespace abc_car_traders
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.carOrderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.partsOrderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.carOrderChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderChart)).BeginInit();
            this.SuspendLayout();
            // 
            // carOrderChart
            // 
            chartArea3.Name = "ChartArea1";
            this.carOrderChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.carOrderChart.Legends.Add(legend3);
            this.carOrderChart.Location = new System.Drawing.Point(12, 22);
            this.carOrderChart.Name = "carOrderChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.carOrderChart.Series.Add(series3);
            this.carOrderChart.Size = new System.Drawing.Size(228, 202);
            this.carOrderChart.TabIndex = 1;
            this.carOrderChart.Text = "chart1";
            // 
            // partsOrderChart
            // 
            chartArea4.Name = "ChartArea1";
            this.partsOrderChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.partsOrderChart.Legends.Add(legend4);
            this.partsOrderChart.Location = new System.Drawing.Point(294, 22);
            this.partsOrderChart.Name = "partsOrderChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.partsOrderChart.Series.Add(series4);
            this.partsOrderChart.Size = new System.Drawing.Size(228, 202);
            this.partsOrderChart.TabIndex = 1;
            this.partsOrderChart.Text = "chart1";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.partsOrderChart);
            this.Controls.Add(this.carOrderChart);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carOrderChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart carOrderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart partsOrderChart;
    }
}