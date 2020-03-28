using System;

namespace BuliderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractBuilder builder = new VacationBuilder();
            builder.BuildDay(3);
            builder.Hotel("丽晶大宾馆");
            builder.Park("人民公园");
            builder.Activity("丢手绢");
            builder.Meal("满汉全席");

            Vacation vacation = builder.GetVacationPlanner();
            Console.WriteLine($"天数:{vacation.Day},旅馆：{vacation.Hotel},公园：{vacation.Park},活动：{vacation.Activity},用餐：{vacation.Meal}");
            Console.ReadKey();
        }
    }
}
