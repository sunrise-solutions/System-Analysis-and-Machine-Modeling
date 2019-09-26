namespace Distributions
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlDistributions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.unChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.unγxValueLabel = new System.Windows.Forms.Label();
            this.unDxValueLabel = new System.Windows.Forms.Label();
            this.unMxValueLabel = new System.Windows.Forms.Label();
            this.unγxLabel = new System.Windows.Forms.Label();
            this.unDxLabel = new System.Windows.Forms.Label();
            this.unMxLabel = new System.Windows.Forms.Label();
            this.unBLabel = new System.Windows.Forms.Label();
            this.unALabel = new System.Windows.Forms.Label();
            this.unR0Label = new System.Windows.Forms.Label();
            this.unCoefficientALabel = new System.Windows.Forms.Label();
            this.unMLabel = new System.Windows.Forms.Label();
            this.unBTextBox = new System.Windows.Forms.TextBox();
            this.unATextBox = new System.Windows.Forms.TextBox();
            this.unR0TextBox = new System.Windows.Forms.TextBox();
            this.unCoefficientATextBox = new System.Windows.Forms.TextBox();
            this.unMTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControlDistributions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDistributions
            // 
            this.tabControlDistributions.Controls.Add(this.tabPage1);
            this.tabControlDistributions.Controls.Add(this.tabPage2);
            this.tabControlDistributions.Controls.Add(this.tabPage3);
            this.tabControlDistributions.Controls.Add(this.tabPage4);
            this.tabControlDistributions.Controls.Add(this.tabPage5);
            this.tabControlDistributions.Controls.Add(this.tabPage6);
            this.tabControlDistributions.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlDistributions.Location = new System.Drawing.Point(8, 8);
            this.tabControlDistributions.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlDistributions.Name = "tabControlDistributions";
            this.tabControlDistributions.SelectedIndex = 0;
            this.tabControlDistributions.Size = new System.Drawing.Size(798, 376);
            this.tabControlDistributions.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.unChart);
            this.tabPage1.Controls.Add(this.unγxValueLabel);
            this.tabPage1.Controls.Add(this.unDxValueLabel);
            this.tabPage1.Controls.Add(this.unMxValueLabel);
            this.tabPage1.Controls.Add(this.unγxLabel);
            this.tabPage1.Controls.Add(this.unDxLabel);
            this.tabPage1.Controls.Add(this.unMxLabel);
            this.tabPage1.Controls.Add(this.unBLabel);
            this.tabPage1.Controls.Add(this.unALabel);
            this.tabPage1.Controls.Add(this.unR0Label);
            this.tabPage1.Controls.Add(this.unCoefficientALabel);
            this.tabPage1.Controls.Add(this.unMLabel);
            this.tabPage1.Controls.Add(this.unBTextBox);
            this.tabPage1.Controls.Add(this.unATextBox);
            this.tabPage1.Controls.Add(this.unR0TextBox);
            this.tabPage1.Controls.Add(this.unCoefficientATextBox);
            this.tabPage1.Controls.Add(this.unMTextBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(790, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Равномерное";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // unChart
            // 
            chartArea2.Name = "ChartArea1";
            this.unChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.unChart.Legends.Add(legend2);
            this.unChart.Location = new System.Drawing.Point(219, 118);
            this.unChart.Name = "unChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.unChart.Series.Add(series2);
            this.unChart.Size = new System.Drawing.Size(300, 188);
            this.unChart.TabIndex = 17;
            this.unChart.Text = "chart1";
            // 
            // unγxValueLabel
            // 
            this.unγxValueLabel.AutoSize = true;
            this.unγxValueLabel.Location = new System.Drawing.Point(127, 285);
            this.unγxValueLabel.Name = "unγxValueLabel";
            this.unγxValueLabel.Size = new System.Drawing.Size(0, 21);
            this.unγxValueLabel.TabIndex = 16;
            // 
            // unDxValueLabel
            // 
            this.unDxValueLabel.AutoSize = true;
            this.unDxValueLabel.Location = new System.Drawing.Point(127, 240);
            this.unDxValueLabel.Name = "unDxValueLabel";
            this.unDxValueLabel.Size = new System.Drawing.Size(0, 21);
            this.unDxValueLabel.TabIndex = 15;
            // 
            // unMxValueLabel
            // 
            this.unMxValueLabel.AutoSize = true;
            this.unMxValueLabel.Location = new System.Drawing.Point(127, 192);
            this.unMxValueLabel.Name = "unMxValueLabel";
            this.unMxValueLabel.Size = new System.Drawing.Size(0, 21);
            this.unMxValueLabel.TabIndex = 14;
            // 
            // unγxLabel
            // 
            this.unγxLabel.AutoSize = true;
            this.unγxLabel.Location = new System.Drawing.Point(38, 285);
            this.unγxLabel.Name = "unγxLabel";
            this.unγxLabel.Size = new System.Drawing.Size(27, 21);
            this.unγxLabel.TabIndex = 13;
            this.unγxLabel.Text = "γx";
            // 
            // unDxLabel
            // 
            this.unDxLabel.AutoSize = true;
            this.unDxLabel.Location = new System.Drawing.Point(38, 240);
            this.unDxLabel.Name = "unDxLabel";
            this.unDxLabel.Size = new System.Drawing.Size(32, 21);
            this.unDxLabel.TabIndex = 12;
            this.unDxLabel.Text = "Dx";
            // 
            // unMxLabel
            // 
            this.unMxLabel.AutoSize = true;
            this.unMxLabel.Location = new System.Drawing.Point(38, 192);
            this.unMxLabel.Name = "unMxLabel";
            this.unMxLabel.Size = new System.Drawing.Size(35, 21);
            this.unMxLabel.TabIndex = 11;
            this.unMxLabel.Text = "Mx";
            // 
            // unBLabel
            // 
            this.unBLabel.AutoSize = true;
            this.unBLabel.Location = new System.Drawing.Point(38, 136);
            this.unBLabel.Name = "unBLabel";
            this.unBLabel.Size = new System.Drawing.Size(20, 21);
            this.unBLabel.TabIndex = 10;
            this.unBLabel.Text = "b";
            // 
            // unALabel
            // 
            this.unALabel.AutoSize = true;
            this.unALabel.Location = new System.Drawing.Point(38, 81);
            this.unALabel.Name = "unALabel";
            this.unALabel.Size = new System.Drawing.Size(18, 21);
            this.unALabel.TabIndex = 9;
            this.unALabel.Text = "a";
            // 
            // unR0Label
            // 
            this.unR0Label.AutoSize = true;
            this.unR0Label.Location = new System.Drawing.Point(537, 34);
            this.unR0Label.Name = "unR0Label";
            this.unR0Label.Size = new System.Drawing.Size(32, 21);
            this.unR0Label.TabIndex = 8;
            this.unR0Label.Text = "R0";
            // 
            // unCoefficientALabel
            // 
            this.unCoefficientALabel.AutoSize = true;
            this.unCoefficientALabel.Location = new System.Drawing.Point(274, 34);
            this.unCoefficientALabel.Name = "unCoefficientALabel";
            this.unCoefficientALabel.Size = new System.Drawing.Size(18, 21);
            this.unCoefficientALabel.TabIndex = 7;
            this.unCoefficientALabel.Text = "a";
            // 
            // unMLabel
            // 
            this.unMLabel.AutoSize = true;
            this.unMLabel.Location = new System.Drawing.Point(32, 34);
            this.unMLabel.Name = "unMLabel";
            this.unMLabel.Size = new System.Drawing.Size(24, 21);
            this.unMLabel.TabIndex = 6;
            this.unMLabel.Text = "m";
            // 
            // unBTextBox
            // 
            this.unBTextBox.Location = new System.Drawing.Point(62, 128);
            this.unBTextBox.Name = "unBTextBox";
            this.unBTextBox.Size = new System.Drawing.Size(100, 29);
            this.unBTextBox.TabIndex = 5;
            // 
            // unATextBox
            // 
            this.unATextBox.Location = new System.Drawing.Point(62, 73);
            this.unATextBox.Name = "unATextBox";
            this.unATextBox.Size = new System.Drawing.Size(100, 29);
            this.unATextBox.TabIndex = 4;
            // 
            // unR0TextBox
            // 
            this.unR0TextBox.Location = new System.Drawing.Point(575, 26);
            this.unR0TextBox.Name = "unR0TextBox";
            this.unR0TextBox.Size = new System.Drawing.Size(182, 29);
            this.unR0TextBox.TabIndex = 3;
            // 
            // unCoefficientATextBox
            // 
            this.unCoefficientATextBox.Location = new System.Drawing.Point(298, 26);
            this.unCoefficientATextBox.Name = "unCoefficientATextBox";
            this.unCoefficientATextBox.Size = new System.Drawing.Size(221, 29);
            this.unCoefficientATextBox.TabIndex = 2;
            // 
            // unMTextBox
            // 
            this.unMTextBox.Location = new System.Drawing.Point(62, 26);
            this.unMTextBox.Name = "unMTextBox";
            this.unMTextBox.Size = new System.Drawing.Size(161, 29);
            this.unMTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(790, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Гауссовское";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Построить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Экспоненциальное";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 261);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 36);
            this.button3.TabIndex = 1;
            this.button3.Text = "Построить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 342);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Гамма-распределение";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(573, 260);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 36);
            this.button4.TabIndex = 1;
            this.button4.Text = "Построить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button5);
            this.tabPage5.Location = new System.Drawing.Point(4, 30);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(790, 342);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Треугольное";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 259);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 36);
            this.button5.TabIndex = 1;
            this.button5.Text = "Построить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Location = new System.Drawing.Point(4, 30);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(790, 342);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Симпсона";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(577, 263);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 36);
            this.button6.TabIndex = 1;
            this.button6.Text = "Построить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 392);
            this.Controls.Add(this.tabControlDistributions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Формирование случайных чисел с заданным распределением";
            this.tabControlDistributions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDistributions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label unBLabel;
        private System.Windows.Forms.Label unALabel;
        private System.Windows.Forms.Label unR0Label;
        private System.Windows.Forms.Label unCoefficientALabel;
        private System.Windows.Forms.Label unMLabel;
        private System.Windows.Forms.TextBox unBTextBox;
        private System.Windows.Forms.TextBox unATextBox;
        private System.Windows.Forms.TextBox unR0TextBox;
        private System.Windows.Forms.TextBox unCoefficientATextBox;
        private System.Windows.Forms.TextBox unMTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart unChart;
        private System.Windows.Forms.Label unγxValueLabel;
        private System.Windows.Forms.Label unDxValueLabel;
        private System.Windows.Forms.Label unMxValueLabel;
        private System.Windows.Forms.Label unγxLabel;
        private System.Windows.Forms.Label unDxLabel;
        private System.Windows.Forms.Label unMxLabel;
    }
}

