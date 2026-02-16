namespace WinForms2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Список всех панелей, которые должны быть на форме
            Panel[] panels = { MenuP, QuestionsP, TimeAndSecsP, QuestionsS_TP };

            foreach (var p in panels)
            {
                // Если родитель не форма, перемещаем
                if (p.Parent != this)
                {
                    // Удаляем из текущего родителя
                    p.Parent?.Controls.Remove(p);
                    // Добавляем на форму
                    this.Controls.Add(p);
                }
            }
            OpenNeedPanel(MenuP);
        }

        private void OpenNeedPanel(Panel panel)
        {
            QuestionsS_TP.Visible = false;
            QuestionsP.Visible = false;
            MenuP.Visible = false;
            TimeAndSecsP.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        private void GoToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP);
        }

        private void QuestionsB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsP);
        }

        private void TimeConvB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(TimeAndSecsP);
        }



        private void questionsT_SB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsS_TP);
        }

        private void BackB1_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(TimeAndSecsP);
        }

        private void FromT_S_To_MenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP);
        }
    }
}
