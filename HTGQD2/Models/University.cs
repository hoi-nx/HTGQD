using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HTGQD2.Models
{
    public class University
    {
      
            [Key, Column(Order = 1)]
            public string UniversityName { get; set; }
            [Key, Column(Order = 2)]
            public string Major { get; set; }
            public double Fee { get; set; }
            public int Volumn { get; set; }
            public int Evaluation { get; set; }
            public float ExpectedPoint { get; set; }
            public float ExPoint { get; set; }
            public int Location { get; set; }
            public float TotalScore { get; set; }
        
    }
}