namespace W03._1._2O04
{
    using System;

    public class DayOfWeek
    {
        private static readonly string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        private int currentIndex;

        private static int NormalizeIndex(int index)
        {
            return ((index % 7) + 7) % 7;
        }

        public DayOfWeek(int index)
        {
            currentIndex = NormalizeIndex(index);
        }

        public static string IndexToDay(int index) => NormalizeIndex(index) switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
            _ => throw new ArgumentOutOfRangeException()
        };

        public string CurrentDay() => Days[currentIndex];

        public void NextDay()
        {
            currentIndex = (currentIndex + 1) % 7;
        }

        public bool IsWeekend() => currentIndex == 5 || currentIndex == 6;
    }
}
