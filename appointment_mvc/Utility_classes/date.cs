using System;
using System.Globalization;
using System.Net;
using System.Text;

internal class DateClass
{
    public string SqlDate(string myDate)
    {
        CultureInfo culture = new CultureInfo("en-GB"); // Use UK date format
        DateTime dateValue;
        if (DateTime.TryParse(myDate, culture, DateTimeStyles.None, out dateValue))
        {
            string formattedDate = dateValue.ToString("MM/dd/yy");
            return formattedDate;
        }
        else
        {
            return string.Empty; // Return an empty string if the date parsing fails
        }
    }
}
