using Microsoft.VisualBasic;
using System.ComponentModel;

namespace APP
{
    public class Time
    {
        public bool flagError = false;

        private const int SecToMin = 60;
        private const int SecToHour = 3600;
        private const int MaxSec = 216000;

        public string SecToTime(string sec)
        {
            flagError = false;

            string ConvertResult = "";

            if (!int.TryParse(sec, out int NumSecs)) //Проверка ввода числового значения количества секунд
            {
                flagError = true;
                return "Введено некорректное числовое значение секунд!";
            }

            if (NumSecs < 0) //Проверка числа секунд на значение < 0
            {
                flagError = true;
                return "Значение секунд не должно быть отрицательным!";
            }

            if (NumSecs < SecToMin) //Секунд < 1 минуты 
                ConvertResult = $"00:00:{sec.PadLeft(2, '0')}";
            else if (NumSecs < SecToHour) //Секунд < 1 часа
            {
                string min = (NumSecs / SecToMin).ToString(); //Считаем сколько минут
                NumSecs %= SecToMin; //Убираем посчитанные минуты из числа секунд
                sec = NumSecs.ToString();

                //Форматируруем
                sec = sec.PadLeft(2, '0');
                min = min.PadLeft(2, '0');

                ConvertResult = $"00:{min}:{sec}";
            }
            else if (NumSecs <= MaxSec) //Секунд <= 60 часов
            {
                string hour = (NumSecs / SecToHour).ToString();
                NumSecs %= SecToHour;
                string min = (NumSecs / SecToMin).ToString();
                NumSecs %= SecToMin;
                sec = NumSecs.ToString();

                //Форматируруем
                sec = sec.PadLeft(2, '0');
                min = min.PadLeft(2, '0');
                hour = hour.PadLeft(2, '0');

                ConvertResult = $"{hour}:{min}:{sec}";
            }
            else
            {
                flagError = true;
                return "Введённое число секунд слишком большое!";
            }

            return ConvertResult;
        }
        public string TimeToSec(string hours, string mins, string secs)
        {
            if (!int.TryParse(secs, out int NumSecs) || !int.TryParse(mins, out int NumMins) || !int.TryParse(hours, out int NumHours)) //Проверка ввода числового значения количества секунд/минут/часов
            {
                flagError = true;
                return "Введено некорректное числовое значение секунд/минут/часов!";
            }

            if (NumSecs < 0 || NumMins < 0 || NumHours < 0) //Проверка числа секунд/минут/часв на значение < 0
            {
                flagError = true;
                return "Значение секунд/минут/часов не должно быть отрицательным!";
            }

            string ConvertResult = (NumSecs + NumMins * SecToMin + NumHours * SecToHour).ToString();
            return ConvertResult;

        }
    }
    public class Age()
    {
        public bool flagError = false;

        public string CalcAge(string[] spawnDate)
        {
            flagError = false;

            DateTime today = DateTime.Today;

            int day = today.Day;
            int month = today.Month;
            int year = today.Year;

            int spawnDay, spawnMonth, spawnYear; //Дробим дату на составляющие

            //Попытка получить отдельные значения даты рождения
            try
            {
                spawnDay = int.Parse(spawnDate[0]);
                spawnMonth = int.Parse(spawnDate[1]);
                spawnYear = int.Parse(spawnDate[2]);
            }
            catch
            {
                flagError = true;
                return "Неверное числовое значение дня/месяца/года рождения!";
            }

            //Проверка на отрицательность полученных данных
            if (spawnDay < 1 || spawnMonth < 1 || spawnYear < 1)
            {
                flagError = true;
                return "Значение дней/месяцев/лет не должно быть меньше 1!";
            }

            if (spawnMonth == 2)
            {
                if (LeapYear(spawnYear))
                {
                    if (spawnDay > 29)
                    {
                        flagError = true;
                        return "Вы родились в високосный год, в нем в феврале всего 29 дней!";
                    }
                }
                else
                {
                    if (spawnDay > 28)
                    {
                        flagError = true;
                        return "Вы родились в обычный год, в нем в феврале всего 28 дней!";
                    }
                }
            }
            else if (spawnMonth > 12)
            {
                flagError = true;
                return "В году всего 12 месяцев!";
            }
            else if (spawnMonth % 2 == 0)
            {
                if (spawnDay > 30)
                {
                    flagError = true;
                    return "В данном месяце всего 30 дней!";
                }
            }
            else
            {
                if (spawnMonth > 31)
                {
                    flagError = true;
                    return "В данном месяце всего 31 день!";
                }
            }
            

            //Проверка родился ли человек #1
            if (year < spawnYear)
            {
                flagError = true;
                return "Вы ещё не родились!";
            }

            //Проверка родился ли человек #2
            if (year == spawnYear && (DaysInSomeMonths(year, month) + day) < (DaysInSomeMonths(spawnYear, spawnMonth) + spawnDay))
            {
                flagError = true;
                return "Вы ещё не родились!";
            }


            int resultDays, resultMonths, resultYears;

            resultYears = year - spawnYear;

            if (month < spawnMonth)
            {
                resultYears -= 1;
                month += 12;
            }
            resultMonths = month - spawnMonth;

            if (day < spawnDay)
            {
                if (resultMonths != 0)
                    resultMonths -= 1;
                else
                {
                    resultYears -= 1;
                    resultMonths += 11;
                }
                if ((month - 1) == 2)
                {
                    if (LeapYear(year))
                        day += 29;
                    else
                        day += 28;
                }
                else
                {
                    if ((month - 1) % 2 == 0)
                        day += 30;
                    else
                        day += 31;
                }
            }
            resultDays = day - spawnDay;

            if (resultMonths == 0 && resultDays == 0)
                return $"С днем рождения!!!!! Вам сегодня {resultYears}!";
            else
                return $"Вам {resultYears} лет, {resultMonths} месяцев, {resultDays} дней";
        }
        private bool LeapYear(int year)
        {
            bool flag = false;

            if (year % 4 == 0)
            {
                flag = true;

                if (year % 100 == 0)
                {
                    flag = false;

                    if (year % 400 == 0)
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }
        private int DaysInSomeMonths(int year, int months)
        {
            int tempDays = 0; //Дней по итогу

            if (months - 1 == 0) //Полных 0 дней
                return 0;
            if (months - 1 == 1) //Полный январь -> 31 день
                return 31;



            for (int i = 1; i < months; i++) //Проверяем по дням родился ли уже человек или нет) считаем полные месяцы в году
            {
                if (i == 2) //В феврале високосный год -> 29 дней, обычный 28 дней
                {
                    if (LeapYear(year))
                        tempDays += 29;
                    else
                        tempDays += 28;
                }
                else //В других месяцах чередуются 30 и 31 день, по чётным 30 дней
                {
                    if (i % 2 == 0) //Четный месяц -> 30 дней
                        tempDays += 30;
                    else //Иначе 31 день
                        tempDays += 31;
                }
            }

            return tempDays; //Количество полных дней
        }
    }
    public class Watch()
    {
        public bool flagError = false;



    }
}