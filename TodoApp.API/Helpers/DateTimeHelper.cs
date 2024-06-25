namespace TodoApp.API.Helpers
{
    public static class DateTimeHelper
    {
        private static readonly TimeZoneInfo colombiaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SA Pacific Standard Time");

        public static DateTime LocalDateNow()
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, colombiaTimeZone);
        }
    }
}
