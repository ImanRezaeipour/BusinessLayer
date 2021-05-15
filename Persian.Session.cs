namespace IR.BusinessLayer
{
    public partial class Persian
    {
        public static class Session
        {
            public static readonly string Farvardin = "فروردین";
            public static readonly string Ordibehesht = "اردیبهشت";
            public static readonly string Khordad = "خرداد";
            public static readonly string Tir = "تیر";
            public static readonly string Mordad = "مرداد";
            public static readonly string Shahrivar = "شهریور";
            public static readonly string Mehr = "مهر";
            public static readonly string Aban = "آبان";
            public static readonly string Azar = "آذر";
            public static readonly string Dey = "دی";
            public static readonly string Bahman = "بهمن";
            public static readonly string Esfand = "اسفند";
        }

        public static string[] GetSession()
        {
            string[] session = new string[]
            {
                "فروردین",
                "اردیبهشت",
                "خرداد",
                "تیر",
                "مرداد",
                "شهریور",
                "مهر",
                "آبان",
                "آذر",
                "دی",
                "بهمن",
                "اسفند"
            };
            return session;
        }
    }
}