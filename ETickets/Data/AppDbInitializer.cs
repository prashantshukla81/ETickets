using ETickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                       new Cinema()
                       {
                           Name=""
                       }
                    });
                
                }
                //actors
                if (!context.Actors.Any()) { }
                //producer
                if (!context.Producers.Any()) { }
                //movies
                if (!context.Movies.Any()) { }
                //actor_movies
                if (!context.Actor_Movies.Any()) { }

            }
        }
    }
}
