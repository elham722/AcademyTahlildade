using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWork
{
    public class DateUtility
    {
        public string GetPersianDate(DateTime t)
        { 
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}/{pc.GetMonth(t).ToString()}/{pc.GetDayOfMonth(t).ToString()}";   
        }
        public string GetPersianTimeForFileName(DateTime t)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(t).ToString()}_{pc.GetMonth(t).ToString()}_{pc.GetDayOfMonth(t).ToString()}_{pc.GetHour(t).ToString()}_{pc.GetMinute(t).ToString()}_{pc.GetSecond(t).ToString()}_{pc.GetMilliseconds(t).ToString()}";
        }
    }
}
