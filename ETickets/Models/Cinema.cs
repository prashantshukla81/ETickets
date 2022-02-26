using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ETickets.Models
{
    public class Cinema
    {
        [key]
        public string Logo { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
 