using eTicket.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{
    public class AppDbIntializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name= "cinema 1",
                            Logo="https://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description="This is the decription of Cinema-1"
                        },
                        new Cinema()
                        {
                            Name= "cinema 2",
                            Logo="https://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description="This is the decription of Cinema-2"
                        },
                        new Cinema()
                        {
                            Name= "cinema 3",
                            Logo="https://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description="This is the decription of Cinema-3"
                        },
                        new Cinema()
                        {
                            Name= "cinema 4",
                            Logo="https://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description="This is the decription of Cinema-4"
                        }

                    });
                    context.SaveChanges();
                }
                //actor
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName= "Actor 1",
                            Bio=
                            ProfilePictureURL="https://dotnethow.net/images/actor/actor-1.jpeg",
                        },
                        new Actor()
                        {
                            FullName= "Actor 1",
                            Bio=
                            ProfilePictureURL="https://dotnethow.net/images/actor/actor-1.jpeg",
                        },
                       new Actor()
                        {
                            FullName= "Actor 1",
                            Bio=
                            ProfilePictureURL="https://dotnethow.net/images/actor/actor-1.jpeg",
                        },
                        new Actor()
                        {
                            FullName= "Actor 4",
                            Bio=
                            ProfilePictureURL="https://dotnethow.net/images/actor/actor-1.jpeg",
                        }
                    });
                    context.SaveChanges();

                }
                //Movies
                if (!context.Movies.Any())
                {

                }
                //producer
                if (!context.Producers.Any())
                {

                }
                //Actor_Movie
                if (!context.Actor_Movies.Any())
                {

                }
            }
        }
    }
}
