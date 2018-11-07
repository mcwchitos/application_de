namespace Application
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Exit = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.TotalErrorButton = new System.Windows.Forms.Button();
            this.LocalErrorButton = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.GraphOfMethods = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphOfErrors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraphOfTotalErrors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.FunctLabel = new System.Windows.Forms.Label();
            this.InitXtextbox = new System.Windows.Forms.TextBox();
            this.IninYtextbox = new System.Windows.Forms.TextBox();
            this.FinalXtextbox = new System.Windows.Forms.TextBox();
            this.StepHtextbox = new System.Windows.Forms.TextBox();
            this.NumOfSteps1 = new System.Windows.Forms.TextBox();
            this.NumOfSteps2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfMethods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfTotalErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1067, 584);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(986, 584);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // TotalErrorButton
            // 
            this.TotalErrorButton.Location = new System.Drawing.Point(1067, 555);
            this.TotalErrorButton.Name = "TotalErrorButton";
            this.TotalErrorButton.Size = new System.Drawing.Size(75, 23);
            this.TotalErrorButton.TabIndex = 2;
            this.TotalErrorButton.Text = "Total Error";
            this.TotalErrorButton.UseVisualStyleBackColor = true;
            this.TotalErrorButton.Click += new System.EventHandler(this.TotalErrorButton_Click);
            // 
            // LocalErrorButton
            // 
            this.LocalErrorButton.Location = new System.Drawing.Point(986, 555);
            this.LocalErrorButton.Name = "LocalErrorButton";
            this.LocalErrorButton.Size = new System.Drawing.Size(75, 23);
            this.LocalErrorButton.TabIndex = 3;
            this.LocalErrorButton.Text = "Local Error";
            this.LocalErrorButton.UseVisualStyleBackColor = true;
            this.LocalErrorButton.Click += new System.EventHandler(this.LocalErrorButton_Click);
            // 
            // TableButton
            // 
            this.TableButton.Location = new System.Drawing.Point(986, 526);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(75, 23);
            this.TableButton.TabIndex = 4;
            this.TableButton.Text = "Show Table";
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // GraphOfMethods
            // 
            chartArea1.Name = "ChartArea1";
            this.GraphOfMethods.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GraphOfMethods.Legends.Add(legend1);
            this.GraphOfMethods.Location = new System.Drawing.Point(12, 88);
            this.GraphOfMethods.Name = "GraphOfMethods";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Euler";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Improved Euler";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Runge-Kuffa";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Analytical Solution";
            this.GraphOfMethods.Series.Add(series1);
            this.GraphOfMethods.Series.Add(series2);
            this.GraphOfMethods.Series.Add(series3);
            this.GraphOfMethods.Series.Add(series4);
            this.GraphOfMethods.Size = new System.Drawing.Size(968, 519);
            this.GraphOfMethods.TabIndex = 5;
            this.GraphOfMethods.Text = "chart1";
            // 
            // GraphOfErrors
            // 
            chartArea2.Name = "ChartArea1";
            this.GraphOfErrors.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraphOfErrors.Legends.Add(legend2);
            this.GraphOfErrors.Location = new System.Drawing.Point(12, 88);
            this.GraphOfErrors.Name = "GraphOfErrors";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Euler";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Improved Euler";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Runge-Kuffa";
            this.GraphOfErrors.Series.Add(series5);
            this.GraphOfErrors.Series.Add(series6);
            this.GraphOfErrors.Series.Add(series7);
            this.GraphOfErrors.Size = new System.Drawing.Size(968, 519);
            this.GraphOfErrors.TabIndex = 6;
            this.GraphOfErrors.Text = "chart1";
            // 
            // GraphOfTotalErrors
            // 
            chartArea3.Name = "ChartArea1";
            this.GraphOfTotalErrors.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.GraphOfTotalErrors.Legends.Add(legend3);
            this.GraphOfTotalErrors.Location = new System.Drawing.Point(12, 88);
            this.GraphOfTotalErrors.Name = "GraphOfTotalErrors";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Euler";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Improved Euler";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Runge-Kuffa";
            this.GraphOfTotalErrors.Series.Add(series8);
            this.GraphOfTotalErrors.Series.Add(series9);
            this.GraphOfTotalErrors.Series.Add(series10);
            this.GraphOfTotalErrors.Size = new System.Drawing.Size(968, 519);
            this.GraphOfTotalErrors.TabIndex = 7;
            this.GraphOfTotalErrors.Text = "chart1";
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(12, 88);
            this.DataTable.Name = "DataTable";
            this.DataTable.Size = new System.Drawing.Size(968, 519);
            this.DataTable.TabIndex = 8;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // FunctLabel
            // 
            this.FunctLabel.AutoSize = true;
            this.FunctLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctLabel.Location = new System.Drawing.Point(349, 9);
            this.FunctLabel.Name = "FunctLabel";
            this.FunctLabel.Size = new System.Drawing.Size(383, 69);
            this.FunctLabel.TabIndex = 9;
            this.FunctLabel.Text = "y\' = cos(x) - y";
            // 
            // InitXtextbox
            // 
            this.InitXtextbox.Location = new System.Drawing.Point(1067, 88);
            this.InitXtextbox.Name = "InitXtextbox";
            this.InitXtextbox.Size = new System.Drawing.Size(75, 20);
            this.InitXtextbox.TabIndex = 10;
            this.InitXtextbox.TextChanged += new System.EventHandler(this.InitXtextbox_TextChanged);
            // 
            // IninYtextbox
            // 
            this.IninYtextbox.Location = new System.Drawing.Point(1067, 114);
            this.IninYtextbox.Name = "IninYtextbox";
            this.IninYtextbox.Size = new System.Drawing.Size(75, 20);
            this.IninYtextbox.TabIndex = 11;
            this.IninYtextbox.TextChanged += new System.EventHandler(this.IninYtextbox_TextChanged);
            // 
            // FinalXtextbox
            // 
            this.FinalXtextbox.Location = new System.Drawing.Point(1067, 140);
            this.FinalXtextbox.Name = "FinalXtextbox";
            this.FinalXtextbox.Size = new System.Drawing.Size(75, 20);
            this.FinalXtextbox.TabIndex = 12;
            this.FinalXtextbox.TextChanged += new System.EventHandler(this.FinalXtextbox_TextChanged);
            // 
            // StepHtextbox
            // 
            this.StepHtextbox.Location = new System.Drawing.Point(1067, 166);
            this.StepHtextbox.Name = "StepHtextbox";
            this.StepHtextbox.Size = new System.Drawing.Size(75, 20);
            this.StepHtextbox.TabIndex = 13;
            this.StepHtextbox.TextChanged += new System.EventHandler(this.StepHtextbox_TextChanged);
            // 
            // NumOfSteps1
            // 
            this.NumOfSteps1.Location = new System.Drawing.Point(1067, 317);
            this.NumOfSteps1.Name = "NumOfSteps1";
            this.NumOfSteps1.Size = new System.Drawing.Size(75, 20);
            this.NumOfSteps1.TabIndex = 14;
            this.NumOfSteps1.TextChanged += new System.EventHandler(this.NumOfSteps1_TextChanged);
            // 
            // NumOfSteps2
            // 
            this.NumOfSteps2.Location = new System.Drawing.Point(1067, 343);
            this.NumOfSteps2.Name = "NumOfSteps2";
            this.NumOfSteps2.Size = new System.Drawing.Size(75, 20);
            this.NumOfSteps2.TabIndex = 15;
            this.NumOfSteps2.TextChanged += new System.EventHandler(this.NumOfSteps2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1026, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Initial X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1026, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Initial Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1026, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Final X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1026, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Step H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1042, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Choose Range for \r\nTotal Approximation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfSteps2);
            this.Controls.Add(this.NumOfSteps1);
            this.Controls.Add(this.StepHtextbox);
            this.Controls.Add(this.FinalXtextbox);
            this.Controls.Add(this.IninYtextbox);
            this.Controls.Add(this.InitXtextbox);
            this.Controls.Add(this.FunctLabel);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.GraphOfTotalErrors);
            this.Controls.Add(this.GraphOfErrors);
            this.Controls.Add(this.GraphOfMethods);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.LocalErrorButton);
            this.Controls.Add(this.TotalErrorButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.Exit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfMethods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraphOfTotalErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button TotalErrorButton;
        private System.Windows.Forms.Button LocalErrorButton;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphOfMethods;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphOfErrors;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraphOfTotalErrors;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Label FunctLabel;
        private System.Windows.Forms.TextBox InitXtextbox;
        private System.Windows.Forms.TextBox IninYtextbox;
        private System.Windows.Forms.TextBox FinalXtextbox;
        private System.Windows.Forms.TextBox StepHtextbox;
        private System.Windows.Forms.TextBox NumOfSteps1;
        private System.Windows.Forms.TextBox NumOfSteps2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

