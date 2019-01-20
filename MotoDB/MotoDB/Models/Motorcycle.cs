using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotoDB.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        [Display(Name = "Engine Capacity")]
        public int EngineCapacity { get; set; }
        
        public int Year { get; set; }
        public string Description { get; set; }
    }
}
