using APP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APP.Tests
{
    [TestClass]
    public class TimeTests
    {
        private Time testTime;

        [TestInitialize]
        public void Setup()
        {
            testTime = new Time();
        }

        // ---------- Тесты для SecToTime ----------

        [TestMethod]
        public void SecToTime_PositiveNumber_ReturnsFormattedTime()
        {
            // Arrange
            string input = "8115"; // 2 ч 15 мин 15 с
            string expected = "02:15:15";

            // Act
            string actual = testTime.SecToTime(input);

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(testTime.flagError);
        }

        [TestMethod]
        public void SecToTime_Zero_ReturnsMidnight()
        {
            string input = "0";
            string expected = "00:00:00";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(testTime.flagError);
        }

        [TestMethod]
        public void SecToTime_OneMinute_ReturnsZeroOneZero()
        {
            string input = "60";
            string expected = "00:01:00";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecToTime_OneHour_ReturnsOneZeroZero()
        {
            string input = "3600";
            string expected = "01:00:00";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SecToTime_MaximumValidSeconds_ReturnsSixtyHours()
        {
            string input = "216000"; // 60 часов
            string expected = "60:00:00";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(testTime.flagError);
        }

        [TestMethod]
        public void SecToTime_NegativeNumber_ReturnsError()
        {
            string input = "-10";
            string expected = "Значение секунд не должно быть отрицательным!";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testTime.flagError);
        }

        [TestMethod]
        public void SecToTime_NonNumericInput_ReturnsError()
        {
            string input = "abc!";
            string expected = "Введено некорректное числовое значение секунд!";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testTime.flagError);
        }

        [TestMethod]
        public void SecToTime_ExceedsMaximum_ReturnsError()
        {
            string input = "216001"; // больше 60 часов
            string expected = "Введённое число секунд слишком большое!";

            string actual = testTime.SecToTime(input);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testTime.flagError);
        }

        // ---------- Тесты для TimeToSec ----------

        [TestMethod]
        public void TimeToSec_ValidInput_ReturnsTotalSeconds()
        {
            // Arrange
            string hours = "2";
            string mins = "15";
            string secs = "15";
            string expected = "8115";

            // Act
            string actual = testTime.TimeToSec(hours, mins, secs);

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(testTime.flagError);
        }

        [TestMethod]
        public void TimeToSec_ZeroInput_ReturnsZero()
        {
            string hours = "0";
            string mins = "0";
            string secs = "0";
            string expected = "0";

            string actual = testTime.TimeToSec(hours, mins, secs);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TimeToSec_NegativeHours_ReturnsError()
        {
            string hours = "-1";
            string mins = "0";
            string secs = "0";
            string expected = "Значение секунд/минут/часов не должно быть отрицательным!";

            string actual = testTime.TimeToSec(hours, mins, secs);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testTime.flagError);
        }

        [TestMethod]
        public void TimeToSec_NonNumericInput_ReturnsError()
        {
            string hours = "2a";
            string mins = "15";
            string secs = "15";
            string expected = "Введено некорректное числовое значение секунд/минут/часов!";

            string actual = testTime.TimeToSec(hours, mins, secs);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testTime.flagError);
        }

        [TestMethod]
        public void TimeToSec_LargeValues_ReturnsCorrectSum()
        {
            string hours = "100";
            string mins = "30";
            string secs = "45";
            // 100*3600 + 30*60 + 45 = 360000 + 1800 + 45 = 361845
            string expected = "361845";

            string actual = testTime.TimeToSec(hours, mins, secs);

            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class AgeTests
    {
        private Age testAge;

        [TestInitialize]
        public void Setup()
        {
            testAge = new Age();
        }

        // Вспомогательный метод: создаёт массив из трёх строк
        private string[] DateArray(string day, string month, string year) => new[] { day, month, year };

        // Тесты, проверяющие обработку ошибок (не зависят от текущей даты)

        [TestMethod]
        public void CalcAge_NonNumericInput_ReturnsError()
        {
            // Arrange
            var input = DateArray("01", "abc", "2000");
            string expected = "Неверное числовое значение дня/месяца/года рождения!";

            // Act
            string actual = testAge.CalcAge(input);

            // Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testAge.flagError);
        }

        [TestMethod]
        public void CalcAge_NegativeDay_ReturnsError()
        {
            var input = DateArray("-5", "12", "1990");
            string expected = "Значение дней/месяцев/лет не должно быть меньше 1!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testAge.flagError);
        }

        [TestMethod]
        public void CalcAge_InvalidFebruaryDate_NonLeapYear_ReturnsError()
        {
            // 29 февраля 2023 (невисокосный год)
            var input = DateArray("29", "2", "2023");
            string expected = "Вы родились в обычный год, в нем в феврале всего 28 дней!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcAge_ValidFebruaryDate_LeapYear_ReturnsOk()
        {
            // 29 февраля 2020 (високосный) – предполагаем, что этот день уже наступил
            var input = DateArray("29", "2", "2020");
            string result = testAge.CalcAge(input);

            // Не должно быть ошибки, результат содержит возраст (зависит от сегодняшней даты)
            Assert.IsFalse(testAge.flagError);
            Assert.IsTrue(result.Contains("лет") || result.Contains("С днем рождения"));
        }

        [TestMethod]
        public void CalcAge_MonthGreaterThan12_ReturnsError()
        {
            var input = DateArray("15", "13", "2000");
            string expected = "В году всего 12 месяцев!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcAge_DayExceedsMonthLimit_ReturnsError()
        {
            // Апрель (4 месяц) – 30 дней
            var input = DateArray("31", "4", "2000");
            string expected = "В данном месяце всего 30 дней!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
        }

        // Тесты, зависящие от текущей даты (предполагаем, что сегодня 15 февраля 2026)

        [TestMethod]
        public void CalcAge_BirthdateInFuture_ReturnsError()
        {
            // Год больше текущего (2026)
            var input = DateArray("1", "1", "2030");
            string expected = "Вы ещё не родились!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(testAge.flagError);
        }

        [TestMethod]
        public void CalcAge_EqualYearButFutureDay_ReturnsError()
        {
            // Текущий год, но день позже сегодняшнего (предположим, сегодня 15.02.2026)
            var input = DateArray("16", "2", "2026");
            string expected = "Вы ещё не родились!";

            string actual = testAge.CalcAge(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalcAge_ValidPastDate_ReturnsNonEmptyString()
        {
            // Дата рождения: 10 мая 2000
            var input = DateArray("10", "5", "2000");
            string result = testAge.CalcAge(input);

            Assert.IsFalse(testAge.flagError);
            // Проверяем, что результат содержит ожидаемые подстроки
            StringAssert.Contains(result, "лет");
            StringAssert.Contains(result, "месяцев");
            StringAssert.Contains(result, "дней");
        }

        [TestMethod]
        public void CalcAge_TodayIsBirthday_ReturnsCongratulations()
        {
            var input = DateArray("15", "2", "2000");
            string expectedSubstring = "С днем рождения";

            string result = testAge.CalcAge(input);

            if (DateTime.Today.Day == 15 && DateTime.Today.Month == 2)
            {
                StringAssert.Contains(result, expectedSubstring);
            }
            else
            {
                Assert.Inconclusive("Тест требует, чтобы сегодня было 15 февраля.");
            }
        }
    }
}