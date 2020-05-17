using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_office2.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }
        public string RouteNumber { get; set; } //"J893"
     // public string AirLineName { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivaTime { get; set; }
        public decimal Price { get; set; }

    }
}
