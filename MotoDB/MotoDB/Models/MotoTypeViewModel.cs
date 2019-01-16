using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoDB.Models
{
    public class MotoTypeViewModel
    {
        public List<Motorcycle> Motorcycles;
        public SelectList Type;
        public string MotoType { get; set; }
        public string SearchString { get; set; }
    }
}
