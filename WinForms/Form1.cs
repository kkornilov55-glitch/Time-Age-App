using APP;

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

        //МЕНЮ
        private void GoToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню из окна справки
        }

        private void QuestionsB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsP); //Переход к окну справки (Меню)
        }

        private void TimeConvB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(TimeAndSecsP); //Переход к окну 1 задания
        }


        //1 задание

        //1 вкладка
        private void questionsT_SB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsS_TP); //Окно справки (1 задание)
        }

        private void FromT_S_To_MenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню
        }

        private void CalcB1_Click(object sender, EventArgs e) //Расчёты
        {
            //Уборка
            ErrorL1.Text = null;
            ResultTimeL.Text = null;

            Time time = new Time();

            //Получаем число секунд
            string inputSeconds = SecTB.Text;

            //Считаем время
            string result = time.SecToTime(inputSeconds);

            //Возвращяем время или ошибку
            if (time.flagError)
                ErrorL1.Text = result;
            else
                ResultTimeL.Text = result;
        }

        //2 вкладка
        private void FromS_T_To_MenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню
        }

        private void questionsS_TB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsS_TP); //Окно справки (1 задание)
        }

        private void CalcB2_Click(object sender, EventArgs e) //Расчёты
        {
            //Уборка
            ErrorL2.Text = null;
            ResultSecondsL.Text = null;

            Time time = new Time();

            //Получаем значения для времени
            string inputHours = HoursTB.Text;
            string inputMins = MinutsTB.Text;
            string inputSeconds = SecondsTB.Text;


            //Считаем секунды
            string result = time.TimeToSec(inputHours, inputMins, inputSeconds);

            //Возвращяем время или ошибку
            if (time.flagError)
                ErrorL2.Text = result;  
            else
                ResultSecondsL.Text = result;
        }

        //Общее
        private void BackB1_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(TimeAndSecsP); //Возврат к основному окну
        }
    }
}
