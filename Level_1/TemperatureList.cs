using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_1
{
    public class TemperatureList
    {
        public DateTime Date { get; set; }
        public float Temperature { get; set; }
    }
    public class Templist
    {
        List<TemperatureList> TList = new List<TemperatureList>();
        public void Add(DateTime Date, float Temp)
        {
            TList.Add(new TemperatureList { Date = Date, Temperature = Temp });
        }
        public void Update(DateTime Date, float Temp)
        {
            if (TList.Exists(index => index.Date == Date))
            {
                TList[TList.FindIndex(index => index.Date == Date)].Temperature = Temp;
            }
        }
        public void Del(DateTime Date1, DateTime Date2)
        {
            for (DateTime date = Date1; date < Date2; date = date.AddDays(1))
            {
                var itemToRemove = TList.SingleOrDefault(index => index.Date == date);
                if (itemToRemove != null)
                    TList.Remove(itemToRemove);
            }
        }
        public List<TemperatureList> AddToList(DateTime Date1, DateTime Date2)
        {
            List<TemperatureList> Temperature = new List<TemperatureList>();
            for (DateTime date = Date1; date < Date2; date = date.AddDays(1))
            {
                if (TList.Exists(index => index.Date == date))
                {
                    Temperature.Add(new TemperatureList { Date = TList[TList.FindIndex(index => index.Date == date)].Date, Temperature = TList[TList.FindIndex(index => index.Date == date)].Temperature });
                }
            }
            return Temperature;
        }
    }
}

