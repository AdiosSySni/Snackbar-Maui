using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp10
{
    public class Food
    {
      public string Type { get; set; }
      public string Source { get; set; }
      public string Name { get; set; }
      public int Cost { get; set; }

      public Food(string type, string source, string name, int cost) 
      {
         Type = type;
         Source = source;
         Name = name;
         Cost = cost;
      }
    }
}
