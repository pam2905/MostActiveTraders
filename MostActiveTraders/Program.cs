using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostActiveTraders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> n = new List<string>();
            n.Add("pampa");
            n.Add("pampa");
            n.Add("pampa");
            n.Add("pampa");
            n.Add ("gaurav");
            n.Add("gaurav");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("tashya");
            n.Add("pampa");
            n.Add ("neha");
            n.Add("pampa");
            n.Add("pampa");
            n.Add("pampa");
            n.Add("pampa");
            mostActive(n);
        }
        public static List<string> mostActive(List<string> customers)
        {
            List<string> res = new List<string>();
            foreach (var c in customers)
            {
                double count = customers.Count(a => a.Contains(c));
                double per = (count / customers.Count()) * 100;
                if (!res.Contains(c) && per>=5)
                {
                    res.Add(c);
                }
            }
            return res.OrderBy(r=>r).ToList();
        }
    }
}
