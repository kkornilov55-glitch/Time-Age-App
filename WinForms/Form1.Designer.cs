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
            MenuP.SuspendLayout();
            MenuButtonsP.SuspendLayout();
            MenuHeadP.SuspendLayout();
            QuestionsP.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // MenuP
            // 
            MenuP.BackColor = Color.LightGray;
            MenuP.Controls.Add(MenuButtonsP);
            MenuP.Controls.Add(MenuHeadP);
            MenuP.Dock = DockStyle.Left;
            MenuP.Location = new Point(0, 0);
            MenuP.Name = "MenuP";
            MenuP.Size = new Size(388, 450);
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
            QuestionsP.Size = new Size(388, 450);
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
            panel3.Size = new Size(364, 426);
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
            GoToMenuB.Location = new Point(0, 387);
            GoToMenuB.Name = "GoToMenuB";
            GoToMenuB.Size = new Size(364, 39);
            GoToMenuB.TabIndex = 4;
            GoToMenuB.Text = "К меню";
            GoToMenuB.UseVisualStyleBackColor = true;
            GoToMenuB.Click += GoToMenuB_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(388, 450);
            Controls.Add(QuestionsP);
            Controls.Add(MenuP);
            Name = "MainForm";
            Text = "Лабораторная работа №2";
            MenuP.ResumeLayout(false);
            MenuButtonsP.ResumeLayout(false);
            MenuHeadP.ResumeLayout(false);
            MenuHeadP.PerformLayout();
            QuestionsP.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
    }
}
