using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ETickets.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ETickets.Models
{
    public class Movie
    {
        [key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public double Price { get; set; }
        public string ImgURL { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
       
        public MovieCategory MovieCategory { get; set; }
        //relationship
        public List<Actor_Movie> Actor_Movies { get; set; }
       //cinema
        public Cinema Cinema { get; set; }
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
       


    }
}
