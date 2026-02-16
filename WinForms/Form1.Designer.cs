namespace WinForms2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MenuP = new Panel();
            MenuButtonsP = new Panel();
            QuestionsB = new Button();
            WatchPaintB = new Button();
            AgeCalcB = new Button();
            TimeConvB = new Button();
            MenuHeadP = new Panel();
            MenuHeadL = new Label();
            QuestionsP = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            TimeAndSecsTextL = new Label();
            TimaAndSecsHeadL = new Label();
            GoToMenuB = new Button();
            TimeAndSecsP = new Panel();
            TimeAndSecsTC = new TabControl();
            SecToTimeTP = new TabPage();
            FromT_S_To_MenuB = new Button();
            questionsT_SB = new Button();
            panel5 = new Panel();
            label7 = new Label();
            ErrorTB1 = new TextBox();
            CalcB1 = new Button();
            panel4 = new Panel();
            label6 = new Label();
            TimeTB1 = new TextBox();
            SecTB1 = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            TimeToSecTP = new TabPage();
            QuestionsS_TP = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            BackB1 = new Button();
            MenuP.SuspendLayout();
            MenuButtonsP.SuspendLayout();
            MenuHeadP.SuspendLayout();
            QuestionsP.SuspendLayout();
            panel3.SuspendLayout();
            TimeAndSecsP.SuspendLayout();
            TimeAndSecsTC.SuspendLayout();
            SecToTimeTP.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            QuestionsS_TP.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // MenuP
            // 
            MenuP.BackColor = Color.LightGray;
            MenuP.Controls.Add(MenuButtonsP);
            MenuP.Controls.Add(MenuHeadP);
            MenuP.Location = new Point(0, 0);
            MenuP.Name = "MenuP";
            MenuP.Size = new Size(406, 497);
            MenuP.TabIndex = 0;
            // 
            // MenuButtonsP
            // 
            MenuButtonsP.BackColor = Color.Silver;
            MenuButtonsP.Controls.Add(QuestionsB);
            MenuButtonsP.Controls.Add(WatchPaintB);
            MenuButtonsP.Controls.Add(AgeCalcB);
            MenuButtonsP.Controls.Add(TimeConvB);
            MenuButtonsP.Location = new Point(12, 140);
            MenuButtonsP.Name = "MenuButtonsP";
            MenuButtonsP.Size = new Size(364, 298);
            MenuButtonsP.TabIndex = 1;
            // 
            // QuestionsB
            // 
            QuestionsB.Dock = DockStyle.Bottom;
            QuestionsB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            QuestionsB.Location = new Point(0, 259);
            QuestionsB.Name = "QuestionsB";
            QuestionsB.Size = new Size(364, 39);
            QuestionsB.TabIndex = 4;
            QuestionsB.Text = "Справка";
            QuestionsB.UseVisualStyleBackColor = true;
            QuestionsB.Click += QuestionsB_Click;
            // 
            // WatchPaintB
            // 
            WatchPaintB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WatchPaintB.Location = new Point(23, 165);
            WatchPaintB.Name = "WatchPaintB";
            WatchPaintB.Size = new Size(322, 47);
            WatchPaintB.TabIndex = 2;
            WatchPaintB.Text = "Время на часах";
            WatchPaintB.UseVisualStyleBackColor = true;
            // 
            // AgeCalcB
            // 
            AgeCalcB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AgeCalcB.Location = new Point(23, 94);
            AgeCalcB.Name = "AgeCalcB";
            AgeCalcB.Size = new Size(322, 47);
            AgeCalcB.TabIndex = 1;
            AgeCalcB.Text = "Точный возраст";
            AgeCalcB.UseVisualStyleBackColor = true;
            // 
            // TimeConvB
            // 
            TimeConvB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TimeConvB.Location = new Point(23, 24);
            TimeConvB.Name = "TimeConvB";
            TimeConvB.Size = new Size(322, 47);
            TimeConvB.TabIndex = 0;
            TimeConvB.Text = "Время ⟷ Секунды";
            TimeConvB.UseVisualStyleBackColor = true;
            TimeConvB.Click += TimeConvB_Click;
            // 
            // MenuHeadP
            // 
            MenuHeadP.BackColor = Color.DarkGray;
            MenuHeadP.Controls.Add(MenuHeadL);
            MenuHeadP.Location = new Point(12, 12);
            MenuHeadP.Name = "MenuHeadP";
            MenuHeadP.Size = new Size(364, 68);
            MenuHeadP.TabIndex = 0;
            // 
            // MenuHeadL
            // 
            MenuHeadL.AutoSize = true;
            MenuHeadL.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuHeadL.Location = new Point(108, 4);
            MenuHeadL.Name = "MenuHeadL";
            MenuHeadL.Size = new Size(152, 60);
            MenuHeadL.TabIndex = 5;
            MenuHeadL.Text = "Меню";
            // 
            // QuestionsP
            // 
            QuestionsP.BackColor = Color.LightGray;
            QuestionsP.Controls.Add(panel3);
            QuestionsP.Location = new Point(0, 0);
            QuestionsP.Name = "QuestionsP";
            QuestionsP.Size = new Size(406, 497);
            QuestionsP.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TimeAndSecsTextL);
            panel3.Controls.Add(TimaAndSecsHeadL);
            panel3.Controls.Add(GoToMenuB);
            panel3.Location = new Point(14, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(378, 471);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.Location = new Point(16, 266);
            label3.Name = "label3";
            label3.Size = new Size(297, 74);
            label3.TabIndex = 8;
            label3.Text = "- Эта функция служит для визуализации\r\n   электронного (формата \"00:00:00\")\r\n   представления времени";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(18, 237);
            label4.Name = "label4";
            label4.Size = new Size(138, 23);
            label4.TabIndex = 9;
            label4.Text = "Время на часах";
            // 
            // label1
            // 
            label1.Location = new Point(16, 157);
            label1.Name = "label1";
            label1.Size = new Size(286, 54);
            label1.TabIndex = 6;
            label1.Text = "- Эта функция служит для определения \r\n   точного возраста (До дней)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(18, 128);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 7;
            label2.Text = "Точный возраст";
            // 
            // TimeAndSecsTextL
            // 
            TimeAndSecsTextL.Location = new Point(16, 41);
            TimeAndSecsTextL.Name = "TimeAndSecsTextL";
            TimeAndSecsTextL.Size = new Size(269, 69);
            TimeAndSecsTextL.TabIndex = 2;
            TimeAndSecsTextL.Text = "- Эта функция служит для удобного\r\n   преобразования секунд во время\r\n   формата: \"00:00:00\" и обратно";
            // 
            // TimaAndSecsHeadL
            // 
            TimaAndSecsHeadL.AutoSize = true;
            TimaAndSecsHeadL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TimaAndSecsHeadL.Location = new Point(18, 12);
            TimaAndSecsHeadL.Name = "TimaAndSecsHeadL";
            TimaAndSecsHeadL.Size = new Size(173, 23);
            TimaAndSecsHeadL.TabIndex = 5;
            TimaAndSecsHeadL.Text = "Время ⟷ Секунды";
            // 
            // GoToMenuB
            // 
            GoToMenuB.Dock = DockStyle.Bottom;
            GoToMenuB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            GoToMenuB.Location = new Point(0, 432);
            GoToMenuB.Name = "GoToMenuB";
            GoToMenuB.Size = new Size(378, 39);
            GoToMenuB.TabIndex = 4;
            GoToMenuB.Text = "К меню";
            GoToMenuB.UseVisualStyleBackColor = true;
            GoToMenuB.Click += GoToMenuB_Click;
            // 
            // TimeAndSecsP
            // 
            TimeAndSecsP.BackColor = Color.Silver;
            TimeAndSecsP.Controls.Add(TimeAndSecsTC);
            TimeAndSecsP.Location = new Point(0, 0);
            TimeAndSecsP.Name = "TimeAndSecsP";
            TimeAndSecsP.Size = new Size(412, 502);
            TimeAndSecsP.TabIndex = 2;
            // 
            // TimeAndSecsTC
            // 
            TimeAndSecsTC.Controls.Add(SecToTimeTP);
            TimeAndSecsTC.Controls.Add(TimeToSecTP);
            TimeAndSecsTC.Location = new Point(0, 2);
            TimeAndSecsTC.Name = "TimeAndSecsTC";
            TimeAndSecsTC.SelectedIndex = 0;
            TimeAndSecsTC.Size = new Size(406, 497);
            TimeAndSecsTC.TabIndex = 5;
            // 
            // SecToTimeTP
            // 
            SecToTimeTP.BackColor = Color.LightGray;
            SecToTimeTP.Controls.Add(FromT_S_To_MenuB);
            SecToTimeTP.Controls.Add(questionsT_SB);
            SecToTimeTP.Controls.Add(panel5);
            SecToTimeTP.Controls.Add(ErrorTB1);
            SecToTimeTP.Controls.Add(CalcB1);
            SecToTimeTP.Controls.Add(panel4);
            SecToTimeTP.Controls.Add(TimeTB1);
            SecToTimeTP.Controls.Add(SecTB1);
            SecToTimeTP.Controls.Add(panel2);
            SecToTimeTP.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SecToTimeTP.Location = new Point(4, 29);
            SecToTimeTP.Name = "SecToTimeTP";
            SecToTimeTP.Padding = new Padding(3);
            SecToTimeTP.Size = new Size(398, 464);
            SecToTimeTP.TabIndex = 0;
            SecToTimeTP.Text = "Секунды ➝ Время";
            // 
            // FromT_S_To_MenuB
            // 
            FromT_S_To_MenuB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FromT_S_To_MenuB.Location = new Point(7, 427);
            FromT_S_To_MenuB.Name = "FromT_S_To_MenuB";
            FromT_S_To_MenuB.Size = new Size(81, 34);
            FromT_S_To_MenuB.TabIndex = 13;
            FromT_S_To_MenuB.Text = "Меню";
            FromT_S_To_MenuB.UseVisualStyleBackColor = true;
            FromT_S_To_MenuB.Click += FromT_S_To_MenuB_Click;
            // 
            // questionsT_SB
            // 
            questionsT_SB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionsT_SB.Location = new Point(366, 427);
            questionsT_SB.Name = "questionsT_SB";
            questionsT_SB.Size = new Size(29, 34);
            questionsT_SB.TabIndex = 12;
            questionsT_SB.Text = "?";
            questionsT_SB.UseVisualStyleBackColor = true;
            questionsT_SB.Click += questionsT_SB_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(7, 285);
            panel5.Name = "panel5";
            panel5.Size = new Size(81, 35);
            panel5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 8);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 0;
            label7.Text = "Ошибка:";
            // 
            // ErrorTB1
            // 
            ErrorTB1.Location = new Point(7, 326);
            ErrorTB1.Multiline = true;
            ErrorTB1.Name = "ErrorTB1";
            ErrorTB1.Size = new Size(385, 64);
            ErrorTB1.TabIndex = 10;
            // 
            // CalcB1
            // 
            CalcB1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalcB1.Location = new Point(7, 199);
            CalcB1.Name = "CalcB1";
            CalcB1.Size = new Size(385, 51);
            CalcB1.TabIndex = 9;
            CalcB1.Text = "Рассчитать";
            CalcB1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(167, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(65, 43);
            panel4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 2);
            label6.Name = "label6";
            label6.Size = new Size(45, 38);
            label6.TabIndex = 0;
            label6.Text = "⮕";
            // 
            // TimeTB1
            // 
            TimeTB1.Location = new Point(238, 129);
            TimeTB1.Multiline = true;
            TimeTB1.Name = "TimeTB1";
            TimeTB1.Size = new Size(154, 42);
            TimeTB1.TabIndex = 7;
            // 
            // SecTB1
            // 
            SecTB1.Location = new Point(7, 129);
            SecTB1.Multiline = true;
            SecTB1.Name = "SecTB1";
            SecTB1.Size = new Size(154, 42);
            SecTB1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(7, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 68);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label5.Location = new Point(54, 11);
            label5.Name = "label5";
            label5.Size = new Size(259, 41);
            label5.TabIndex = 5;
            label5.Text = "Секунды - время";
            // 
            // TimeToSecTP
            // 
            TimeToSecTP.Location = new Point(4, 29);
            TimeToSecTP.Name = "TimeToSecTP";
            TimeToSecTP.Padding = new Padding(3);
            TimeToSecTP.Size = new Size(398, 464);
            TimeToSecTP.TabIndex = 1;
            TimeToSecTP.Text = "Время ➝ Секунды";
            TimeToSecTP.UseVisualStyleBackColor = true;
            // 
            // QuestionsS_TP
            // 
            QuestionsS_TP.BackColor = Color.LightGray;
            QuestionsS_TP.Controls.Add(panel7);
            QuestionsS_TP.Location = new Point(0, 0);
            QuestionsS_TP.Name = "QuestionsS_TP";
            QuestionsS_TP.Size = new Size(406, 497);
            QuestionsS_TP.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(BackB1);
            panel7.Location = new Point(14, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(364, 426);
            panel7.TabIndex = 2;
            // 
            // label8
            // 
            label8.Location = new Point(13, 237);
            label8.Name = "label8";
            label8.Size = new Size(316, 110);
            label8.TabIndex = 6;
            label8.Text = "- Для обратного перевода, впишите\r\n   значения часов, минут, секунд в \r\n   формате 00:00:00, далее выполните \r\n   все те же действия, что и в предыдущем\r\n   окне.";
            // 
            // label12
            // 
            label12.Location = new Point(13, 52);
            label12.Name = "label12";
            label12.Size = new Size(279, 172);
            label12.TabIndex = 2;
            label12.Text = resources.GetString("label12.Text");
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(13, 18);
            label13.Name = "label13";
            label13.Size = new Size(173, 23);
            label13.TabIndex = 5;
            label13.Text = "Время ⟷ Секунды";
            // 
            // BackB1
            // 
            BackB1.Dock = DockStyle.Bottom;
            BackB1.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            BackB1.Location = new Point(0, 387);
            BackB1.Name = "BackB1";
            BackB1.Size = new Size(364, 39);
            BackB1.TabIndex = 4;
            BackB1.Text = "Назад";
            BackB1.UseVisualStyleBackColor = true;
            BackB1.Click += BackB1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(414, 504);
            Controls.Add(QuestionsS_TP);
            Controls.Add(MenuP);
            Controls.Add(TimeAndSecsP);
            Controls.Add(QuestionsP);
            Name = "MainForm";
            Text = "Лабораторная работа №2";
            MenuP.ResumeLayout(false);
            MenuButtonsP.ResumeLayout(false);
            MenuHeadP.ResumeLayout(false);
            MenuHeadP.PerformLayout();
            QuestionsP.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            TimeAndSecsP.ResumeLayout(false);
            TimeAndSecsTC.ResumeLayout(false);
            SecToTimeTP.ResumeLayout(false);
            SecToTimeTP.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            QuestionsS_TP.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuP;
        private Panel MenuButtonsP;
        private Panel MenuHeadP;
        private Button TimeConvB;
        private Button WatchPaintB;
        private Button AgeCalcB;
        private Button QuestionsB;
        private Label MenuHeadL;
        private Panel QuestionsP;
        private Panel panel3;
        private Button GoToMenuB;
        private Label TimeAndSecsTextL;
        private Label TimaAndSecsHeadL;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Panel TimeAndSecsP;
        private TabControl TimeAndSecsTC;
        private TabPage SecToTimeTP;
        private TabPage TimeToSecTP;
        private Panel panel2;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private TextBox TimeTB1;
        private TextBox SecTB1;
        private TextBox ErrorTB1;
        private Button CalcB1;
        private Panel panel5;
        private Label label7;
        private Button questionsT_SB;
        private Panel QuestionsS_TP;
        private Panel panel7;
        private Label label12;
        private Label label13;
        private Button BackB1;
        private Label label8;
        private Button FromT_S_To_MenuB;
    }
}
