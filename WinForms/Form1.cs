using APP;

namespace WinForms2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Список всех панелей, которые должны быть на форме
            Panel[] panels = { MenuP, QuestionsP, TimeAndSecsP, QuestionsS_TP, RealAgeP, QuesRealAgeP, T_in_W_P, ques_T_in_W_P };

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

                p.Location = new Point(0, 0); //Располагаем панели в левом верхнем углу
            }
            OpenNeedPanel(MenuP);

            this.ClientSize = RealAgeP.Size; //Размер окна формы без рамок и интерфейса (ClientSize) равен размеру окна (Можно любое, они все 400x500)
        }

        private void OpenNeedPanel(Panel panel)
        {
            QuestionsS_TP.Visible = false;
            QuestionsP.Visible = false;
            MenuP.Visible = false;
            TimeAndSecsP.Visible = false;
            RealAgeP.Visible = false;
            QuesRealAgeP.Visible = false;
            T_in_W_P.Visible = false;
            ques_T_in_W_P.Visible = false;

            panel.Visible = true;
            //panel.Dock = DockStyle.Fill; //Пытался просто растянуть панель по окну
            this.ClientSize = panel.Size;
        }

        //МЕНЮ
        private void GoToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню из окна справки
        }

        private void TimeConvB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(TimeAndSecsP); //Переход к окну 1 задания
        }

        private void QuestionsB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuestionsP); //Переход к окну справки (Меню)
        }

        private void AgeCalcB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(RealAgeP); //Переход к окну 2 задания
        }

        private void WatchPaintB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(T_in_W_P); //Переход к окну 3 задания
            //this.ClientSize = T_in_W_P.Size;
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


        //2 задание

        private void FromRealAgeToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню
        }

        private void QuesRealAgeB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(QuesRealAgeP); //Окно справки (2 задание)
        }

        private void BackToRealAgeB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(RealAgeP); //Возврат к основному окну
        }

        private void CalcAgeB_Click(object sender, EventArgs e) //Расчёты
        {
            //Уборка
            ResultOrErrorAgeL.Text = null;

            string[] spawnDate = { DayTB.Text, MonthTB.Text, YearTB.Text };

            Age age = new Age();
            ResultOrErrorAgeL.Text = age.CalcAge(spawnDate);

            if (age.flagError)
                ResultOrErrorAgeL.ForeColor = Color.Red;
            else
                ResultOrErrorAgeL.ForeColor = Color.Black;
        }


        //3 задание

        private void DrawB_Click(object sender, EventArgs e)
        {
            //Основная логика
        }

        private void From_T_in_W_ToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню
        }

        private void T_in_W_quesB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(ques_T_in_W_P); //Окно справки (3 задание)
            //this.ClientSize = ques_T_in_W_P.Size;
        }

        private void backTo_T_in_W_B_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(T_in_W_P); //Возврат к основному окну
            //this.ClientSize = T_in_W_P.Size;
        }
    }
}
