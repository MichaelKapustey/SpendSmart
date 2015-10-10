using System.Collections.Generic;

namespace SpendSmart.Models
{
    public class Spending
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }

        public float Price { get; set; }

        public Dictionary<string,object> Attacments { get; set; }
    }
}
