using System;

namespace LinqConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new LinqSamples();
            d.LoadData();
            d.Przyklad10Button_Click();
        }
    }
}
