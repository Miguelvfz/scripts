public class DateTimeValidator
{
   /// <summary>
   /// Transform a data string in this format '26/11/2019 14:57:07,857-03:00' to a DateTime
   /// </summary>
   /// <param name="date"></param>
   /// <returns></returns>
   public DateTime ValidateDateTime(string date)
   {
      string fullHours = date.Split(' ')[1].ToString().Split(',')[0];
      string fullDate = date.Split(' ')[0].ToString();
      int day = Convert.ToInt16(fullDate.Split('/')[0]);
      int month = Convert.ToInt16(fullDate.Split('/')[1]);
      int year = Convert.ToInt16(fullDate.Split('/')[2]);
      int hours = Convert.ToInt16(fullHours.Split(':')[0]);
      int minutes = Convert.ToInt16(fullHours.Split(':')[1]);
      int seconds = Convert.ToInt16(fullHours.Split(':')[2]);
      string utc = date.Split(' ')[1].ToString().Split('-')[1];            
      DateTime newData = new DateTime(year, month, day, hours,minutes,seconds);
      return newData;
   }
}
