namespace BoxedDate
{
    //Задание 3
    public class Date
    {
        private int day;
        private int month;
        private int year;
        public Date(int day, int month, int year)
        {
            this.day = day; this.month = month; this.year = year;
        }
        public Date AddDays(int days)
        {
            DateTime date = new DateTime(year, month, day);
            date = date.AddDays(days);
            return new Date(date.Day, date.Month, date.Year);
        }
        public Date SubtractDays(int days)
        {
            DateTime date = new DateTime(year, month, day);
            date = date.AddDays(-days);
            return new Date(date.Day, date.Month, date.Year);
        }

        public static bool operator ==(Date date1, Date date2)
        {
            return date1.Equals(date2);
        }
        public static bool operator !=(Date date1, Date date2)
        {
            return !date1.Equals(date2);
        }
        public override string ToString()
        {
            return $"{day:D2}/{month:D2}/{year:D4}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Date other = (Date)obj;
            return day == other.day && month == other.month && year == other.year;
        }
    }
}
