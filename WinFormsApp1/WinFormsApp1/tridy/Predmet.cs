namespace SchoolTimetable
{
    public class Predmet
    {
        public string Nazev { get; set; }
        public string Zkratka { get; set; }

        public override string ToString()
        {
            return Nazev + " (" + Zkratka + ")";
        }
    }
}
