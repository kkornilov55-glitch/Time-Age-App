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
        public int hours, minutes, seconds;
        public bool error = false;

        private void DrawB_Click(object sender, EventArgs e)
        {
            //Основная логика

            //Уборка
            ErrorL3.Text = null;
            error = false;

            try
            {
                hours = int.Parse(T_in_W_hourTB.Text);
                minutes = int.Parse(T_in_W_minTB.Text);
                seconds = int.Parse(T_in_W_secsTB.Text);
            }
            catch
            {
                ErrorL3.Text = "Ошибка: введены некорректные числовые значения";
                error = true;
                return;
            }

            //Проверка диапазонов
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59 || seconds < 0 || seconds > 59)
            {
                ErrorL3.Text = "Ошибка: значения часов/минут/секунд выходят за допустымые диапазоны";
                error = true;
                return;
            }

            //Больше значения времени не нужны
            T_in_W_hourTB.Text = null;
            T_in_W_minTB.Text = null;
            T_in_W_secsTB.Text = null;

            if (!error)
                WatchPB.Invalidate();




        }

        private void From_T_in_W_ToMenuB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(MenuP); //Возврат к меню
        }

        private void T_in_W_quesB_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(ques_T_in_W_P); //Окно справки (3 задание)
        }

        private void backTo_T_in_W_B_Click(object sender, EventArgs e)
        {
            OpenNeedPanel(T_in_W_P); //Возврат к основному окну
        }

        //private void WatchPB_Paint(object sender, PaintEventArgs e)
        //{
        //    if (error) return;

        //    //Получение данных

        //    Graphics graphics = e.Graphics;

        //    Pen penBase10 = new Pen(Color.FromName("DarkGray"), 10); //Темно серое перо 10 пикселей шириной
        //    Pen penBlack10 = new Pen(Color.Black, 10); //Черное перо 10 пикселей шириной
        //    Pen penHoursArrow = new Pen(Color.Black, 15); //Часовая стрелка
        //    SolidBrush brushWhite = new SolidBrush(Color.White); //Белая заливка
        //    SolidBrush brushBlack = new SolidBrush(Color.Black); //Черная заливка






        //    //Рисуем и заливаем рамку часов
        //    int diameterFrameCircle = WatchPB.Size.Width - 50; //Диаметр окружности
        //    //Координаты левого верхнего угла рамки
        //    int frameCircleX = (WatchPB.Size.Width - diameterFrameCircle) / 2;
        //    int frameCircleY = (WatchPB.Size.Height - diameterFrameCircle) / 2;

        //    graphics.DrawEllipse(penBlack10, frameCircleX, frameCircleY, diameterFrameCircle, diameterFrameCircle); 
        //    graphics.FillEllipse(brushWhite, frameCircleX, frameCircleY, diameterFrameCircle, diameterFrameCircle);



        //    //Рисуем точечку в центре
        //    int diameterMiddleCircle = 10;
        //    int middleCircleX = (WatchPB.Size.Width - diameterMiddleCircle) / 2 ;
        //    int middleCircleY = (WatchPB.Size.Height - diameterMiddleCircle) / 2 ;

        //    graphics.FillEllipse(brushBlack, middleCircleX, middleCircleY, diameterMiddleCircle, diameterMiddleCircle);



        //    //Рисуем стрелки

        //    //Сдвиг в градусах для каждой стрелки
        //    int moveHour = 360 / 12;
        //    int moveMinute = moveHour / 60;
        //    int moveSecond = moveMinute / 60;
        //    //Длинна стрелок
        //    double hoursArrowLen = diameterFrameCircle / 1.5;
        //    double minsArrowLen = diameterFrameCircle / 1.2;
        //    double secsArrowLen = minsArrowLen;
        //    //Разница
        //    //Начально стрелок
        //    Point middlePoint = new Point(WatchPB.Width / 2, WatchPB.Height / 2);

        //    //Вычисление конца
        //    int X, Y;
        //    X = 


        //    graphics.DrawLine(penHoursArrow, middlePoint, )

        //}

        private void WatchPB_Paint(object sender, PaintEventArgs e)
        {
            if (error) return;

            Graphics graphics = e.Graphics;
            
            //Перья и заливки
            Pen penBase10 = new Pen(Color.DarkGray, 10);
            Pen penBlack10 = new Pen(Color.Black, 10);
            Pen penHoursArrow = new Pen(Color.Black, 15);  // часовая стрелка
            Pen penMinsArrow = new Pen(Color.Blue, 8);    // минутная стрелка
            Pen penSecsArrow = new Pen(Color.Red, 4);      // секундная стрелка
            SolidBrush brushWhite = new SolidBrush(Color.White);
            SolidBrush brushBlack = new SolidBrush(Color.Black);
            {
                //Рисуем циферблат (окружность)
                int diameterFrameCircle = WatchPB.Size.Width - 50; // диаметр
                int frameCircleX = (WatchPB.Size.Width - diameterFrameCircle) / 2;
                int frameCircleY = (WatchPB.Size.Height - diameterFrameCircle) / 2;

                graphics.DrawEllipse(penBlack10, frameCircleX, frameCircleY, diameterFrameCircle, diameterFrameCircle);
                graphics.FillEllipse(brushWhite, frameCircleX, frameCircleY, diameterFrameCircle, diameterFrameCircle);

                //Центр часов
                int centerX = WatchPB.Width / 2;
                int centerY = WatchPB.Height / 2;

                //Рисуем маленькую чёрную точку в центре
                int dotSize = 15;
                graphics.FillEllipse(brushBlack, centerX - dotSize / 2, centerY - dotSize / 2, dotSize, dotSize);

                //Рисуем часовые метки

                int radius = diameterFrameCircle / 2; // радиус циферблата
                for (int i = 0; i < 12; i++)
                {
                    // Угол для i-й метки (30 градусов между метками, сдвиг -90°, чтобы 0 было вверху)
                    double angle = (i * 30 - 90) * Math.PI / 180;
                    int x1 = (int)(centerX + (radius - 15) * Math.Cos(angle));
                    int y1 = (int)(centerY + (radius - 15) * Math.Sin(angle));
                    int x2 = (int)(centerX + radius * Math.Cos(angle));
                    int y2 = (int)(centerY + radius * Math.Sin(angle));
                    graphics.DrawLine(Pens.Black, x1, y1, x2, y2);
                }

                //Вычисляем углы для стрелок

                // Секундная стрелка: 360° / 60 = 6° на секунду
                double secAngle = (seconds * 6 - 90) * Math.PI / 180;

                // Минутная стрелка: 6° на минуту + плавное смещение от секунд (0.1° на секунду)
                double minAngle = (minutes * 6 + seconds * 0.1 - 90) * Math.PI / 180;

                // Часовая стрелка: 30° на час + 0.5° на минуту; используем hours % 12 для 12-часового формата
                double hourAngle = ((hours % 12) * 30 + minutes * 0.5 - 90) * Math.PI / 180;

                // Длины стрелок (от центра до кончика)
                int secLen = (int)(radius * 0.9);   // почти до края
                int minLen = (int)(radius * 0.75);
                int hourLen = (int)(radius * 0.6);

                // Конечные точки стрелок
                int secX = (int)(centerX + secLen * Math.Cos(secAngle));
                int secY = (int)(centerY + secLen * Math.Sin(secAngle));

                int minX = (int)(centerX + minLen * Math.Cos(minAngle));
                int minY = (int)(centerY + minLen * Math.Sin(minAngle));

                int hourX = (int)(centerX + hourLen * Math.Cos(hourAngle));
                int hourY = (int)(centerY + hourLen * Math.Sin(hourAngle));

                // Рисуем стрелки
                graphics.DrawLine(penSecsArrow, centerX, centerY, secX, secY);
                graphics.DrawLine(penMinsArrow, centerX, centerY, minX, minY);
                graphics.DrawLine(penHoursArrow, centerX, centerY, hourX, hourY);
            }
        }
    }
}
