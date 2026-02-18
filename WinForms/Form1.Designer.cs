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
            QuestionsB = new Button();
            MenuButtonsP = new Panel();
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
            TimeAndSecsTC = new TabControl();
            SecToTimeTP = new TabPage();
            ResultTimeL = new Label();
            ErrorL1 = new Label();
            FromT_S_To_MenuB = new Button();
            questionsT_SB = new Button();
            panel5 = new Panel();
            label7 = new Label();
            CalcB1 = new Button();
            panel4 = new Panel();
            label6 = new Label();
            SecTB = new TextBox();
            panel2 = new Panel();
            label5 = new Label();
            tabPage1 = new TabPage();
            ResultSecondsL = new Label();
            ErrorL2 = new Label();
            MinutsTB = new TextBox();
            SecondsTB = new TextBox();
            CalcB2 = new Button();
            panel1 = new Panel();
            label10 = new Label();
            HoursTB = new TextBox();
            panel6 = new Panel();
            label11 = new Label();
            FromS_T_To_MenuB = new Button();
            questionsS_TB = new Button();
            panel8 = new Panel();
            label9 = new Label();
            QuestionsS_TP = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            BackB1 = new Button();
            TimeAndSecsP = new Panel();
            RealAgeP = new Panel();
            FromRealAgeToMenuB = new Button();
            QuesRealAgeB = new Button();
            panel10 = new Panel();
            ResultOrErrorAgeL = new Label();
            label18 = new Label();
            CalcAgeB = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            YearTB = new TextBox();
            MonthTB = new TextBox();
            DayTB = new TextBox();
            MonthL = new Label();
            YearL = new Label();
            DayL = new Label();
            panel9 = new Panel();
            label14 = new Label();
            QuesRealAgeP = new Panel();
            panel12 = new Panel();
            label20 = new Label();
            label21 = new Label();
            BackToRealAgeB = new Button();
            MenuP.SuspendLayout();
            MenuButtonsP.SuspendLayout();
            MenuHeadP.SuspendLayout();
            QuestionsP.SuspendLayout();
            panel3.SuspendLayout();
            TimeAndSecsTC.SuspendLayout();
            SecToTimeTP.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            QuestionsS_TP.SuspendLayout();
            panel7.SuspendLayout();
            TimeAndSecsP.SuspendLayout();
            RealAgeP.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            QuesRealAgeP.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // MenuP
            // 
            MenuP.BackColor = Color.LightGray;
            MenuP.Controls.Add(QuestionsB);
            MenuP.Controls.Add(MenuButtonsP);
            MenuP.Controls.Add(MenuHeadP);
            MenuP.Location = new Point(548, 3);
            MenuP.Name = "MenuP";
            MenuP.Size = new Size(400, 500);
            MenuP.TabIndex = 0;
            // 
            // QuestionsB
            // 
            QuestionsB.Dock = DockStyle.Bottom;
            QuestionsB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            QuestionsB.Location = new Point(0, 461);
            QuestionsB.Name = "QuestionsB";
            QuestionsB.Size = new Size(400, 39);
            QuestionsB.TabIndex = 5;
            QuestionsB.Text = "Справка";
            QuestionsB.UseVisualStyleBackColor = true;
            QuestionsB.Click += QuestionsB_Click;
            // 
            // MenuButtonsP
            // 
            MenuButtonsP.BackColor = Color.Silver;
            MenuButtonsP.Controls.Add(WatchPaintB);
            MenuButtonsP.Controls.Add(AgeCalcB);
            MenuButtonsP.Controls.Add(TimeConvB);
            MenuButtonsP.Location = new Point(0, 140);
            MenuButtonsP.Name = "MenuButtonsP";
            MenuButtonsP.Size = new Size(400, 238);
            MenuButtonsP.TabIndex = 1;
            // 
            // WatchPaintB
            // 
            WatchPaintB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            WatchPaintB.Location = new Point(52, 162);
            WatchPaintB.Name = "WatchPaintB";
            WatchPaintB.Size = new Size(300, 47);
            WatchPaintB.TabIndex = 2;
            WatchPaintB.Text = "Время на часах";
            WatchPaintB.UseVisualStyleBackColor = true;
            // 
            // AgeCalcB
            // 
            AgeCalcB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AgeCalcB.Location = new Point(52, 92);
            AgeCalcB.Name = "AgeCalcB";
            AgeCalcB.Size = new Size(300, 47);
            AgeCalcB.TabIndex = 1;
            AgeCalcB.Text = "Точный возраст";
            AgeCalcB.UseVisualStyleBackColor = true;
            AgeCalcB.Click += AgeCalcB_Click;
            // 
            // TimeConvB
            // 
            TimeConvB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TimeConvB.Location = new Point(52, 22);
            TimeConvB.Name = "TimeConvB";
            TimeConvB.Size = new Size(300, 47);
            TimeConvB.TabIndex = 0;
            TimeConvB.Text = "Время ⟷ Секунды";
            TimeConvB.UseVisualStyleBackColor = true;
            TimeConvB.Click += TimeConvB_Click;
            // 
            // MenuHeadP
            // 
            MenuHeadP.BackColor = Color.DarkGray;
            MenuHeadP.Controls.Add(MenuHeadL);
            MenuHeadP.Dock = DockStyle.Top;
            MenuHeadP.Location = new Point(0, 0);
            MenuHeadP.Name = "MenuHeadP";
            MenuHeadP.Size = new Size(400, 68);
            MenuHeadP.TabIndex = 0;
            // 
            // MenuHeadL
            // 
            MenuHeadL.Dock = DockStyle.Top;
            MenuHeadL.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MenuHeadL.Location = new Point(0, 0);
            MenuHeadL.Name = "MenuHeadL";
            MenuHeadL.Size = new Size(400, 68);
            MenuHeadL.TabIndex = 5;
            MenuHeadL.Text = "Меню";
            MenuHeadL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionsP
            // 
            QuestionsP.BackColor = Color.LightGray;
            QuestionsP.Controls.Add(panel3);
            QuestionsP.Location = new Point(548, 509);
            QuestionsP.Name = "QuestionsP";
            QuestionsP.Size = new Size(400, 500);
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
            panel3.Location = new Point(0, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 488);
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
            GoToMenuB.Location = new Point(0, 449);
            GoToMenuB.Name = "GoToMenuB";
            GoToMenuB.Size = new Size(400, 39);
            GoToMenuB.TabIndex = 4;
            GoToMenuB.Text = "К меню";
            GoToMenuB.UseVisualStyleBackColor = true;
            GoToMenuB.Click += GoToMenuB_Click;
            // 
            // TimeAndSecsTC
            // 
            TimeAndSecsTC.Controls.Add(SecToTimeTP);
            TimeAndSecsTC.Controls.Add(tabPage1);
            TimeAndSecsTC.Location = new Point(0, 3);
            TimeAndSecsTC.Name = "TimeAndSecsTC";
            TimeAndSecsTC.SelectedIndex = 0;
            TimeAndSecsTC.Size = new Size(400, 494);
            TimeAndSecsTC.TabIndex = 5;
            // 
            // SecToTimeTP
            // 
            SecToTimeTP.BackColor = Color.LightGray;
            SecToTimeTP.Controls.Add(ResultTimeL);
            SecToTimeTP.Controls.Add(ErrorL1);
            SecToTimeTP.Controls.Add(FromT_S_To_MenuB);
            SecToTimeTP.Controls.Add(questionsT_SB);
            SecToTimeTP.Controls.Add(panel5);
            SecToTimeTP.Controls.Add(CalcB1);
            SecToTimeTP.Controls.Add(panel4);
            SecToTimeTP.Controls.Add(SecTB);
            SecToTimeTP.Controls.Add(panel2);
            SecToTimeTP.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SecToTimeTP.Location = new Point(4, 29);
            SecToTimeTP.Name = "SecToTimeTP";
            SecToTimeTP.Padding = new Padding(3);
            SecToTimeTP.Size = new Size(392, 461);
            SecToTimeTP.TabIndex = 0;
            SecToTimeTP.Text = "Секунды ➝ Время";
            // 
            // ResultTimeL
            // 
            ResultTimeL.BackColor = Color.White;
            ResultTimeL.Font = new Font("Segoe UI", 15F);
            ResultTimeL.Location = new Point(237, 129);
            ResultTimeL.Name = "ResultTimeL";
            ResultTimeL.Size = new Size(149, 42);
            ResultTimeL.TabIndex = 15;
            ResultTimeL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorL1
            // 
            ErrorL1.BackColor = Color.White;
            ErrorL1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            ErrorL1.ForeColor = Color.Red;
            ErrorL1.Location = new Point(7, 323);
            ErrorL1.Name = "ErrorL1";
            ErrorL1.Size = new Size(379, 64);
            ErrorL1.TabIndex = 14;
            // 
            // FromT_S_To_MenuB
            // 
            FromT_S_To_MenuB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FromT_S_To_MenuB.Location = new Point(7, 424);
            FromT_S_To_MenuB.Name = "FromT_S_To_MenuB";
            FromT_S_To_MenuB.Size = new Size(81, 34);
            FromT_S_To_MenuB.TabIndex = 13;
            FromT_S_To_MenuB.Text = "Меню";
            FromT_S_To_MenuB.UseVisualStyleBackColor = true;
            FromT_S_To_MenuB.Click += FromT_S_To_MenuB_Click;
            // 
            // questionsT_SB
            // 
            questionsT_SB.Cursor = Cursors.Help;
            questionsT_SB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionsT_SB.Location = new Point(351, 423);
            questionsT_SB.Name = "questionsT_SB";
            questionsT_SB.Size = new Size(35, 35);
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
            // CalcB1
            // 
            CalcB1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalcB1.Location = new Point(7, 199);
            CalcB1.Name = "CalcB1";
            CalcB1.Size = new Size(379, 51);
            CalcB1.TabIndex = 9;
            CalcB1.Text = "Рассчитать";
            CalcB1.UseVisualStyleBackColor = true;
            CalcB1.Click += CalcB1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(163, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(69, 43);
            panel4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 2);
            label6.Name = "label6";
            label6.Size = new Size(45, 38);
            label6.TabIndex = 0;
            label6.Text = "⮕";
            // 
            // SecTB
            // 
            SecTB.Cursor = Cursors.IBeam;
            SecTB.Font = new Font("Segoe UI", 15F);
            SecTB.Location = new Point(7, 129);
            SecTB.MaxLength = 10;
            SecTB.Multiline = true;
            SecTB.Name = "SecTB";
            SecTB.Size = new Size(150, 42);
            SecTB.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 74);
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
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(ResultSecondsL);
            tabPage1.Controls.Add(ErrorL2);
            tabPage1.Controls.Add(MinutsTB);
            tabPage1.Controls.Add(SecondsTB);
            tabPage1.Controls.Add(CalcB2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(HoursTB);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(FromS_T_To_MenuB);
            tabPage1.Controls.Add(questionsS_TB);
            tabPage1.Controls.Add(panel8);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(392, 461);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Время ➝ секунды";
            // 
            // ResultSecondsL
            // 
            ResultSecondsL.BackColor = Color.White;
            ResultSecondsL.Font = new Font("Segoe UI", 15F);
            ResultSecondsL.Location = new Point(238, 129);
            ResultSecondsL.Name = "ResultSecondsL";
            ResultSecondsL.Size = new Size(154, 42);
            ResultSecondsL.TabIndex = 26;
            ResultSecondsL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ErrorL2
            // 
            ErrorL2.BackColor = Color.White;
            ErrorL2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic);
            ErrorL2.ForeColor = Color.Red;
            ErrorL2.Location = new Point(5, 322);
            ErrorL2.Name = "ErrorL2";
            ErrorL2.Size = new Size(385, 64);
            ErrorL2.TabIndex = 25;
            // 
            // MinutsTB
            // 
            MinutsTB.Cursor = Cursors.IBeam;
            MinutsTB.Font = new Font("Segoe UI", 15F);
            MinutsTB.ForeColor = SystemColors.WindowText;
            MinutsTB.Location = new Point(55, 128);
            MinutsTB.MaxLength = 2;
            MinutsTB.Multiline = true;
            MinutsTB.Name = "MinutsTB";
            MinutsTB.Size = new Size(50, 42);
            MinutsTB.TabIndex = 24;
            // 
            // SecondsTB
            // 
            SecondsTB.Cursor = Cursors.IBeam;
            SecondsTB.Font = new Font("Segoe UI", 15F);
            SecondsTB.Location = new Point(107, 128);
            SecondsTB.MaxLength = 2;
            SecondsTB.Multiline = true;
            SecondsTB.Name = "SecondsTB";
            SecondsTB.Size = new Size(50, 42);
            SecondsTB.TabIndex = 23;
            // 
            // CalcB2
            // 
            CalcB2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalcB2.Location = new Point(7, 198);
            CalcB2.Name = "CalcB2";
            CalcB2.Size = new Size(385, 51);
            CalcB2.TabIndex = 18;
            CalcB2.Text = "Рассчитать";
            CalcB2.UseVisualStyleBackColor = true;
            CalcB2.Click += CalcB2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label10);
            panel1.Location = new Point(163, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(69, 43);
            panel1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(16, 2);
            label10.Name = "label10";
            label10.Size = new Size(45, 38);
            label10.TabIndex = 0;
            label10.Text = "⮕";
            // 
            // HoursTB
            // 
            HoursTB.Cursor = Cursors.IBeam;
            HoursTB.Font = new Font("Segoe UI", 15F);
            HoursTB.ForeColor = SystemColors.WindowText;
            HoursTB.Location = new Point(3, 128);
            HoursTB.MaxLength = 2;
            HoursTB.Multiline = true;
            HoursTB.Name = "HoursTB";
            HoursTB.Size = new Size(50, 42);
            HoursTB.TabIndex = 15;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkGray;
            panel6.Controls.Add(label11);
            panel6.Location = new Point(7, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(385, 68);
            panel6.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label11.Location = new Point(54, 11);
            label11.Name = "label11";
            label11.Size = new Size(255, 41);
            label11.TabIndex = 5;
            label11.Text = "Время - секунды";
            // 
            // FromS_T_To_MenuB
            // 
            FromS_T_To_MenuB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FromS_T_To_MenuB.Location = new Point(7, 426);
            FromS_T_To_MenuB.Name = "FromS_T_To_MenuB";
            FromS_T_To_MenuB.Size = new Size(81, 34);
            FromS_T_To_MenuB.TabIndex = 22;
            FromS_T_To_MenuB.Text = "Меню";
            FromS_T_To_MenuB.UseVisualStyleBackColor = true;
            FromS_T_To_MenuB.Click += FromS_T_To_MenuB_Click;
            // 
            // questionsS_TB
            // 
            questionsS_TB.Cursor = Cursors.Help;
            questionsS_TB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionsS_TB.Location = new Point(366, 426);
            questionsS_TB.Name = "questionsS_TB";
            questionsS_TB.Size = new Size(29, 34);
            questionsS_TB.TabIndex = 21;
            questionsS_TB.Text = "?";
            questionsS_TB.UseVisualStyleBackColor = true;
            questionsS_TB.Click += questionsS_TB_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Controls.Add(label9);
            panel8.Location = new Point(7, 284);
            panel8.Name = "panel8";
            panel8.Size = new Size(81, 35);
            panel8.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 8);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 0;
            label9.Text = "Ошибка:";
            // 
            // QuestionsS_TP
            // 
            QuestionsS_TP.BackColor = Color.LightGray;
            QuestionsS_TP.Controls.Add(panel7);
            QuestionsS_TP.Location = new Point(954, 509);
            QuestionsS_TP.Name = "QuestionsS_TP";
            QuestionsS_TP.Size = new Size(400, 500);
            QuestionsS_TP.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(BackB1);
            panel7.Location = new Point(0, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 488);
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
            BackB1.Location = new Point(0, 449);
            BackB1.Name = "BackB1";
            BackB1.Size = new Size(400, 39);
            BackB1.TabIndex = 4;
            BackB1.Text = "Назад";
            BackB1.UseVisualStyleBackColor = true;
            BackB1.Click += BackB1_Click;
            // 
            // TimeAndSecsP
            // 
            TimeAndSecsP.BackColor = Color.Silver;
            TimeAndSecsP.Controls.Add(TimeAndSecsTC);
            TimeAndSecsP.Location = new Point(954, 3);
            TimeAndSecsP.Name = "TimeAndSecsP";
            TimeAndSecsP.Size = new Size(400, 500);
            TimeAndSecsP.TabIndex = 6;
            // 
            // RealAgeP
            // 
            RealAgeP.BackColor = Color.LightGray;
            RealAgeP.Controls.Add(FromRealAgeToMenuB);
            RealAgeP.Controls.Add(QuesRealAgeB);
            RealAgeP.Controls.Add(panel10);
            RealAgeP.Controls.Add(panel9);
            RealAgeP.Location = new Point(1360, 0);
            RealAgeP.Name = "RealAgeP";
            RealAgeP.Size = new Size(400, 500);
            RealAgeP.TabIndex = 7;
            // 
            // FromRealAgeToMenuB
            // 
            FromRealAgeToMenuB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FromRealAgeToMenuB.Location = new Point(3, 463);
            FromRealAgeToMenuB.Name = "FromRealAgeToMenuB";
            FromRealAgeToMenuB.Size = new Size(81, 34);
            FromRealAgeToMenuB.TabIndex = 15;
            FromRealAgeToMenuB.Text = "Меню";
            FromRealAgeToMenuB.UseVisualStyleBackColor = true;
            FromRealAgeToMenuB.Click += FromRealAgeToMenuB_Click;
            // 
            // QuesRealAgeB
            // 
            QuesRealAgeB.Cursor = Cursors.Help;
            QuesRealAgeB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuesRealAgeB.Location = new Point(362, 462);
            QuesRealAgeB.Name = "QuesRealAgeB";
            QuesRealAgeB.Size = new Size(35, 35);
            QuesRealAgeB.TabIndex = 14;
            QuesRealAgeB.Text = "?";
            QuesRealAgeB.UseVisualStyleBackColor = true;
            QuesRealAgeB.Click += QuesRealAgeB_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Silver;
            panel10.Controls.Add(ResultOrErrorAgeL);
            panel10.Controls.Add(label18);
            panel10.Controls.Add(CalcAgeB);
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label16);
            panel10.Controls.Add(label15);
            panel10.Controls.Add(YearTB);
            panel10.Controls.Add(MonthTB);
            panel10.Controls.Add(DayTB);
            panel10.Controls.Add(MonthL);
            panel10.Controls.Add(YearL);
            panel10.Controls.Add(DayL);
            panel10.Location = new Point(0, 140);
            panel10.Name = "panel10";
            panel10.Size = new Size(400, 255);
            panel10.TabIndex = 7;
            // 
            // ResultOrErrorAgeL
            // 
            ResultOrErrorAgeL.BackColor = Color.White;
            ResultOrErrorAgeL.Font = new Font("Segoe UI", 7F);
            ResultOrErrorAgeL.Location = new Point(195, 186);
            ResultOrErrorAgeL.Name = "ResultOrErrorAgeL";
            ResultOrErrorAgeL.Size = new Size(190, 44);
            ResultOrErrorAgeL.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(144, 192);
            label18.Name = "label18";
            label18.Size = new Size(45, 38);
            label18.TabIndex = 11;
            label18.Text = "⮕";
            // 
            // CalcAgeB
            // 
            CalcAgeB.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CalcAgeB.Location = new Point(14, 186);
            CalcAgeB.Name = "CalcAgeB";
            CalcAgeB.Size = new Size(124, 45);
            CalcAgeB.TabIndex = 10;
            CalcAgeB.Text = "Вычислить";
            CalcAgeB.UseVisualStyleBackColor = true;
            CalcAgeB.Click += CalcAgeB_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label17.Location = new Point(111, 119);
            label17.Name = "label17";
            label17.Size = new Size(20, 31);
            label17.TabIndex = 8;
            label17.Text = ":";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(111, 70);
            label16.Name = "label16";
            label16.Size = new Size(20, 31);
            label16.TabIndex = 7;
            label16.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(111, 21);
            label15.Name = "label15";
            label15.Size = new Size(20, 31);
            label15.TabIndex = 6;
            label15.Text = ":";
            // 
            // YearTB
            // 
            YearTB.Location = new Point(137, 119);
            YearTB.Multiline = true;
            YearTB.Name = "YearTB";
            YearTB.Size = new Size(248, 37);
            YearTB.TabIndex = 5;
            // 
            // MonthTB
            // 
            MonthTB.Location = new Point(137, 70);
            MonthTB.Multiline = true;
            MonthTB.Name = "MonthTB";
            MonthTB.Size = new Size(248, 37);
            MonthTB.TabIndex = 4;
            // 
            // DayTB
            // 
            DayTB.Location = new Point(137, 21);
            DayTB.Multiline = true;
            DayTB.Name = "DayTB";
            DayTB.Size = new Size(248, 37);
            DayTB.TabIndex = 3;
            // 
            // MonthL
            // 
            MonthL.BackColor = Color.White;
            MonthL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MonthL.Location = new Point(14, 70);
            MonthL.Name = "MonthL";
            MonthL.Size = new Size(92, 37);
            MonthL.TabIndex = 2;
            MonthL.Text = "Месяц";
            MonthL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // YearL
            // 
            YearL.BackColor = Color.White;
            YearL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            YearL.Location = new Point(14, 119);
            YearL.Name = "YearL";
            YearL.Size = new Size(92, 37);
            YearL.TabIndex = 1;
            YearL.Text = "Год";
            YearL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DayL
            // 
            DayL.BackColor = Color.White;
            DayL.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DayL.Location = new Point(14, 21);
            DayL.Name = "DayL";
            DayL.Size = new Size(92, 37);
            DayL.TabIndex = 0;
            DayL.Text = "День";
            DayL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkGray;
            panel9.Controls.Add(label14);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(400, 68);
            panel9.TabIndex = 6;
            // 
            // label14
            // 
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(400, 68);
            label14.TabIndex = 5;
            label14.Text = "Точный возраст";
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuesRealAgeP
            // 
            QuesRealAgeP.BackColor = Color.LightGray;
            QuesRealAgeP.Controls.Add(panel12);
            QuesRealAgeP.Location = new Point(1360, 509);
            QuesRealAgeP.Name = "QuesRealAgeP";
            QuesRealAgeP.Size = new Size(400, 500);
            QuesRealAgeP.TabIndex = 8;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Silver;
            panel12.Controls.Add(label20);
            panel12.Controls.Add(label21);
            panel12.Controls.Add(BackToRealAgeB);
            panel12.Location = new Point(0, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(400, 488);
            panel12.TabIndex = 2;
            // 
            // label20
            // 
            label20.Location = new Point(13, 52);
            label20.Name = "label20";
            label20.Size = new Size(300, 172);
            label20.TabIndex = 2;
            label20.Text = "- Для вычисления возраста, введите\r\n   день, месяц, год рождения в соотв.\r\n   поля и нажмите клавишу \"Вычислить\"";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label21.Location = new Point(13, 18);
            label21.Name = "label21";
            label21.Size = new Size(143, 23);
            label21.TabIndex = 5;
            label21.Text = "Точный возраст";
            // 
            // BackToRealAgeB
            // 
            BackToRealAgeB.Dock = DockStyle.Bottom;
            BackToRealAgeB.Font = new Font("Yu Gothic UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            BackToRealAgeB.Location = new Point(0, 449);
            BackToRealAgeB.Name = "BackToRealAgeB";
            BackToRealAgeB.Size = new Size(400, 39);
            BackToRealAgeB.TabIndex = 4;
            BackToRealAgeB.Text = "Назад";
            BackToRealAgeB.UseVisualStyleBackColor = true;
            BackToRealAgeB.Click += BackToRealAgeB_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1761, 916);
            Controls.Add(QuesRealAgeP);
            Controls.Add(RealAgeP);
            Controls.Add(TimeAndSecsP);
            Controls.Add(QuestionsS_TP);
            Controls.Add(MenuP);
            Controls.Add(QuestionsP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Лаб. работа №2";
            MenuP.ResumeLayout(false);
            MenuButtonsP.ResumeLayout(false);
            MenuHeadP.ResumeLayout(false);
            QuestionsP.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            TimeAndSecsTC.ResumeLayout(false);
            SecToTimeTP.ResumeLayout(false);
            SecToTimeTP.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            QuestionsS_TP.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            TimeAndSecsP.ResumeLayout(false);
            RealAgeP.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            QuesRealAgeP.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuP;
        private Panel MenuButtonsP;
        private Panel MenuHeadP;
        private Button TimeConvB;
        private Button WatchPaintB;
        private Button AgeCalcB;
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
        private TabControl TimeAndSecsTC;
        private TabPage SecToTimeTP;
        private Panel panel2;
        private Label label5;
        private Panel panel4;
        private Label label6;
        private TextBox SecTB;
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
        private TabPage tabPage1;
        private Button CalcB2;
        private Panel panel1;
        private Label label10;
        private TextBox HoursTB;
        private Panel panel6;
        private Label label11;
        private Button FromS_T_To_MenuB;
        private Button questionsS_TB;
        private Panel panel8;
        private Label label9;
        private TextBox MinutsTB;
        private TextBox SecondsTB;
        private Label ErrorL1;
        private Label ResultTimeL;
        private Label ErrorL2;
        private Label ResultSecondsL;
        private Panel TimeAndSecsP;
        private Panel RealAgeP;
        private Button QuestionsB;
        private Panel panel9;
        private Label label14;
        private Panel panel10;
        private Label DayL;
        private Label MonthL;
        private Label YearL;
        private TextBox DayTB;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox YearTB;
        private TextBox MonthTB;
        private Button CalcAgeB;
        private Label ResultOrErrorAgeL;
        private Label label18;
        private Button FromRealAgeToMenuB;
        private Button QuesRealAgeB;
        private Panel QuesRealAgeP;
        private Panel panel12;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button BackToRealAgeB;
    }
}
