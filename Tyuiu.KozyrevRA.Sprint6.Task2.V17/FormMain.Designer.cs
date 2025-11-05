namespace Tyuiu.KozyrevRA.Sprint6.Task2.V17
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textBoxStartStep = new TextBox();
            textBoxStopStep = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxText = new GroupBox();
            dataGridViewAnswer = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask = new GroupBox();
            groupBoxInput = new GroupBox();
            groupBoxStartStop = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer).BeginInit();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(21, 397);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(110, 27);
            textBoxStartStep.TabIndex = 13;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(153, 397);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(109, 27);
            textBoxStopStep.TabIndex = 12;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(268, 340);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(110, 84);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.ForestGreen;
            buttonDone.Location = new Point(384, 340);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 84);
            buttonDone.TabIndex = 11;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxText
            // 
            groupBoxText.Controls.Add(dataGridViewAnswer);
            groupBoxText.Location = new Point(522, 8);
            groupBoxText.Name = "groupBoxText";
            groupBoxText.Size = new Size(169, 416);
            groupBoxText.TabIndex = 10;
            groupBoxText.TabStop = false;
            groupBoxText.Text = "Вывод данных.                    Результат.";
            // 
            // dataGridViewAnswer
            // 
            dataGridViewAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnswer.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewAnswer.Location = new Point(27, 41);
            dataGridViewAnswer.Name = "dataGridViewAnswer";
            dataGridViewAnswer.RowHeadersVisible = false;
            dataGridViewAnswer.RowHeadersWidth = 51;
            dataGridViewAnswer.Size = new Size(104, 375);
            dataGridViewAnswer.TabIndex = 15;
            dataGridViewAnswer.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Location = new Point(21, 8);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(479, 313);
            groupBoxTask.TabIndex = 8;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:                                                                               Протабулировать функцию по формуле на диапазоне [-5;5].Результаты вывести в виде таблицы.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(groupBoxStartStop);
            groupBoxInput.Location = new Point(21, 340);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(241, 103);
            groupBoxInput.TabIndex = 14;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // groupBoxStartStop
            // 
            groupBoxStartStop.Location = new Point(-8, 37);
            groupBoxStartStop.Name = "groupBoxStartStop";
            groupBoxStartStop.Size = new Size(249, 66);
            groupBoxStartStop.TabIndex = 0;
            groupBoxStartStop.TabStop = false;
            groupBoxStartStop.Text = "Старт шага              Конец шага";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(726, 43);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(573, 375);
            chartFunction.TabIndex = 15;
            chartFunction.Text = "chart1";
            chartFunction.Click += chart1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 450);
            Controls.Add(chartFunction);
            Controls.Add(textBoxStartStep);
            Controls.Add(textBoxStopStep);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxText);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxInput);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 17 | Козырев Р.А";
            groupBoxText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer).EndInit();
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxText;
        private GroupBox groupBoxTask;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxStartStop;
        private DataGridView dataGridViewAnswer;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
