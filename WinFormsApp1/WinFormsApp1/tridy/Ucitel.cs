namespace SchoolTimetable
{
    public class Ucitel
    {
        public string Jmeno { get; set; }
        public string Zkratka { get; set; }

        public override string ToString()
        {
            return Jmeno + " (" + Zkratka + ")";
        }
    }
}
