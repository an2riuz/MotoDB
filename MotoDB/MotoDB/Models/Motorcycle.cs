using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoDB.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int EngineCapacity { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
