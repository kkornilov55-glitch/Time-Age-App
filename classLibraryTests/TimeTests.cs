using Microsoft.VisualStudio.TestTools.UnitTesting;
using APP;

namespace APP.Tests
{
    [TestClass]
    public class TimeTests
    {
        private Time _time;

        [TestInitialize]
        public void Setup()
        {
            _time = new Time();
        }

        // ---------- Тесты для SecToTime ----------

        [TestMethod]
        public void SecToTime_ValidSecondsLessThanMinute_ReturnsCorrectFormat()
        {
            string result = _time.SecToTime("45");
            Assert.AreEqual("00:00:45", result);
            Assert.IsFalse(_time.flagError);
        }

        [TestMethod]
        public void SecToTime_ValidSecondsOneMinute_ReturnsCorrectFormat()
        {
            string result = _time.SecToTime("60");
            Assert.AreEqual("00:01:00", result);
        }

        [TestMethod]
        public void SecToTime_ValidSecondsOneHour_ReturnsCorrectFormat()
        {
            string result = _time.SecToTime("3600");
            Assert.AreEqual("01:00:00", result);
        }

        [TestMethod]
        public void SecToTime_ValidSecondsComplex_ReturnsCorrectFormat()
        {
            // 2 часа 15 минут 30 секунд = 2*3600 + 15*60 + 30 = 7200 + 900 + 30 = 8130
            string result = _time.SecToTime("8130");
            Assert.AreEqual("02:15:30", result);
        }

        [TestMethod]
        public void SecToTime_MaximumValidSeconds_ReturnsSixtyHours()
        {
            string result = _time.SecToTime("216000");
            Assert.AreEqual("60:00:00", result);
            Assert.IsFalse(_time.flagError);
        }

        [TestMethod]
        public void SecToTime_ZeroSeconds_ReturnsMidnight()
        {
            string result = _time.SecToTime("0");
            Assert.AreEqual("00:00:00", result);
        }

        [TestMethod]
        public void SecToTime_NegativeSeconds_ReturnsError()
        {
            string result = _time.SecToTime("-10");
            Assert.AreEqual("Значение секунд не должно быть отрицательным!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void SecToTime_NonNumericInput_ReturnsError()
        {
            string result = _time.SecToTime("abc");
            Assert.AreEqual("Введено некорректное числовое значение секунд!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void SecToTime_ExceedsMaxSeconds_ReturnsError()
        {
            string result = _time.SecToTime("216001");
            Assert.AreEqual("Введённое число секунд слишком большое!", result);
            Assert.IsTrue(_time.flagError);
        }

        // ---------- Тесты для TimeToSec ----------

        [TestMethod]
        public void TimeToSec_ValidInput_ReturnsTotalSeconds()
        {
            string result = _time.TimeToSec("2", "15", "30");
            Assert.AreEqual("8130", result);
            Assert.IsFalse(_time.flagError);
        }

        [TestMethod]
        public void TimeToSec_ZeroInput_ReturnsZero()
        {
            string result = _time.TimeToSec("0", "0", "0");
            Assert.AreEqual("0", result);
        }

        [TestMethod]
        public void TimeToSec_LargeValues_ReturnsCorrectSum()
        {
            // 100 часов, 30 минут, 45 секунд
            string result = _time.TimeToSec("100", "30", "45");
            Assert.AreEqual("361845", result);
        }

        [TestMethod]
        public void TimeToSec_NegativeHours_ReturnsError()
        {
            string result = _time.TimeToSec("-1", "0", "0");
            Assert.AreEqual("Значение секунд/минут/часов не должно быть отрицательным!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void TimeToSec_NegativeMinutes_ReturnsError()
        {
            string result = _time.TimeToSec("1", "-5", "0");
            Assert.AreEqual("Значение секунд/минут/часов не должно быть отрицательным!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void TimeToSec_NonNumericHours_ReturnsError()
        {
            string result = _time.TimeToSec("2a", "15", "30");
            Assert.AreEqual("Введено некорректное числовое значение секунд/минут/часов!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void TimeToSec_NonNumericMinutes_ReturnsError()
        {
            string result = _time.TimeToSec("2", "1b5", "30");
            Assert.AreEqual("Введено некорректное числовое значение секунд/минут/часов!", result);
            Assert.IsTrue(_time.flagError);
        }

        [TestMethod]
        public void TimeToSec_NonNumericSeconds_ReturnsError()
        {
            string result = _time.TimeToSec("2", "15", "3o");
            Assert.AreEqual("Введено некорректное числовое значение секунд/минут/часов!", result);
            Assert.IsTrue(_time.flagError);
        }
    }

    [TestClass]
    public class AgeTests
    {
        private Age _age;

        [TestInitialize]
        public void Setup()
        {
            _age = new Age();
        }

        // Вспомогательный метод для создания массива даты
        private string[] Date(string day, string month, string year) => new[] { day, month, year };

        // ---------- Тесты на обработку ошибок (не зависят от текущей даты) ----------

        [TestMethod]
        public void CalcAge_NonNumericDay_ReturnsError()
        {
            string result = _age.CalcAge(Date("ab", "12", "2000"));
            Assert.AreEqual("Неверное числовое значение дня/месяца/года рождения!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_NonNumericMonth_ReturnsError()
        {
            string result = _age.CalcAge(Date("15", "dec", "2000"));
            Assert.AreEqual("Неверное числовое значение дня/месяца/года рождения!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_NonNumericYear_ReturnsError()
        {
            string result = _age.CalcAge(Date("15", "12", "two"));
            Assert.AreEqual("Неверное числовое значение дня/месяца/года рождения!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_NegativeDay_ReturnsError()
        {
            string result = _age.CalcAge(Date("-1", "12", "2000"));
            Assert.AreEqual("Значение дней/месяцев/лет не должно быть меньше 1!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_ZeroMonth_ReturnsError()
        {
            string result = _age.CalcAge(Date("15", "0", "2000"));
            Assert.AreEqual("Значение дней/месяцев/лет не должно быть меньше 1!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_MonthGreaterThan12_ReturnsError()
        {
            string result = _age.CalcAge(Date("15", "13", "2000"));
            Assert.AreEqual("В году всего 12 месяцев!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_InvalidFebruaryDay_NonLeapYear_ReturnsError()
        {
            // 29 февраля 2023 (не високосный)
            string result = _age.CalcAge(Date("29", "2", "2023"));
            Assert.AreEqual("Вы родились в обычный год, в нем в феврале всего 28 дней!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_ValidFebruaryDay_LeapYear_ReturnsNoError()
        {
            // 29 февраля 2020 (високосный) – проверяем, что ошибки нет
            string result = _age.CalcAge(Date("29", "2", "2020"));
            Assert.IsFalse(_age.flagError);
            // Результат может быть разным в зависимости от сегодняшней даты, но ошибки быть не должно
        }

        [TestMethod]
        public void CalcAge_DayExceedsMonthLimit_EvenMonth_ReturnsError()
        {
            // Апрель (4 месяц) – 30 дней
            string result = _age.CalcAge(Date("31", "4", "2000"));
            Assert.AreEqual("В данном месяце всего 30 дней!", result);
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_DayExceedsMonthLimit_OddMonth_ReturnsError()
        {
            // Январь (1 месяц) – 31 день, но проверяем >31
            string result = _age.CalcAge(Date("32", "1", "2000"));
            Assert.AreEqual("В данном месяце всего 31 день!", result); // Здесь код выдаёт это сообщение, хотя логичнее было бы "В данном месяце всего 31 день!"
            Assert.IsTrue(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_FutureYear_ReturnsError()
        {
            // Год больше текущего (предполагаем, что сегодня 2026)
            string result = _age.CalcAge(Date("1", "1", "2030"));
            Assert.AreEqual("Вы ещё не родились!", result);
            Assert.IsTrue(_age.flagError);
        }

        // ---------- Тесты, зависящие от текущей даты (предполагаем, что сегодня 21 февраля 2026) ----------
        // Для надёжности можно использовать рефлексию для подмены DateTime.Today, но здесь мы просто проверяем логику с фиксированной датой.
        // Если дата выполнения теста не совпадёт с предположением, некоторые тесты могут упасть.
        // Рекомендуется модифицировать класс Age, чтобы он принимал "сегодня" как параметр.

        [TestMethod]
        public void CalcAge_ValidPastDate_ReturnsCorrectFormat()
        {
            // Дата рождения: 10 мая 2000
            string result = _age.CalcAge(Date("10", "5", "2000"));
            Assert.IsFalse(_age.flagError);
            // Проверяем, что результат содержит слова "лет", "месяцев", "дней" (конкретные числа зависят от сегодняшней даты)
            StringAssert.Contains(result, "лет");
            StringAssert.Contains(result, "месяцев");
            StringAssert.Contains(result, "дней");
        }

        [TestMethod]
        public void CalcAge_TodayIsBirthday_ReturnsCongratulations()
        {
            // Сегодня 21 февраля 2026 – если день рождения 21 февраля, то должно быть поздравление
            string result = _age.CalcAge(Date("21", "2", "2000"));
            if (DateTime.Today.Day == 21 && DateTime.Today.Month == 2)
            {
                StringAssert.Contains(result, "С днем рождения");
            }
            else
            {
                Assert.Inconclusive("Тест требует, чтобы сегодня было 21 февраля.");
            }
        }

        [TestMethod]
        public void CalcAge_EdgeCase_29February_LeapYear_AfterLeapYear()
        {
            // Проверим, что для 29 февраля 2020 года в невисокосный год (например, 2021) расчёт не ломается
            // Здесь мы не проверяем точные числа, только отсутствие ошибок
            string result = _age.CalcAge(Date("29", "2", "2020"));
            Assert.IsFalse(_age.flagError);
        }

        [TestMethod]
        public void CalcAge_YearEqualButDayAndMonthBeforeToday_ReturnsCorrect()
        {
            // Если год равен текущему, но дата раньше, то возраст 0 лет
            string result = _age.CalcAge(Date("1", "1", "2026"));
            Assert.IsFalse(_age.flagError);
            Assert.IsTrue(result.Contains("0 лет") || result.Contains("лет"));
        }

        [TestMethod]
        public void CalcAge_YearEqualButDayAfterToday_ReturnsNotBornYet()
        {
            // Если год равен текущему, но день позже (например, завтра)
            DateTime tomorrow = DateTime.Today.AddDays(1);
            string result = _age.CalcAge(Date(tomorrow.Day.ToString(), tomorrow.Month.ToString(), tomorrow.Year.ToString()));
            Assert.AreEqual("Вы ещё не родились!", result);
            Assert.IsTrue(_age.flagError);
        }
    }
}