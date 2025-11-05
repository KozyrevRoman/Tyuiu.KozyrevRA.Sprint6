namespace Tyuiu.KozyrevRA.Sprint6.Task1.V30
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
            groupBoxTask = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxText = new GroupBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            groupBoxInput = new GroupBox();
            groupBoxStartStop = new GroupBox();
            groupBoxInput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(479, 313);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:                                                                               Протабулировать функцию по формуле на диапазоне [-5;5].Результаты вывести в виде таблицы.";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10F);
            textBoxResult.Location = new Point(513, 66);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(257, 362);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBoxText
            // 
            groupBoxText.Location = new Point(513, 12);
            groupBoxText.Name = "groupBoxText";
            groupBoxText.Size = new Size(257, 416);
            groupBoxText.TabIndex = 2;
            groupBoxText.TabStop = false;
            groupBoxText.Text = "Вывод данных.                    Результат.";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.ForestGreen;
            buttonDone.Location = new Point(375, 344);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 84);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(259, 344);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(110, 84);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(144, 401);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(109, 27); 
            textBoxStopStep.TabIndex = 4;
            //  
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(12, 401);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(110, 27);
            textBoxStartStep.TabIndex = 5;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(groupBoxStartStop);
            groupBoxInput.Location = new Point(12, 344);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(241, 103);
            groupBoxInput.TabIndex = 6;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            groupBoxInput.Enter += groupBoxInput_Enter;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxStartStep);
            Controls.Add(textBoxStopStep);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult);
            Controls.Add(groupBoxText);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxInput);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Козырев Р.А";
            Load += Form1_Load;
            groupBoxInput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxResult;
        private GroupBox groupBoxText;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxStartStop;
    }
}
