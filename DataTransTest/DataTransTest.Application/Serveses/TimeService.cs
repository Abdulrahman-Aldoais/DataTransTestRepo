namespace DataTransTest.Serveses
{
    public class TimeService
    {
        public string GetDate()
        {
            var date = DateTime.Now.ToString("yyy-MM-dd");
            return date;
        }

        public string GetTime()
        {
            var time = DateTime.Now.ToString("h:mm:ss tt");
            return time;
        }

    }
}