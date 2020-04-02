using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_project_Starter.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_project_Starter.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcSongContext(serviceProvider.
                GetRequiredService<DbContextOptions<MvcSongContext>>());

            if (context.Song.Any())
                return;     //songs in the db. Don't do anything We are good to go

            context.Song.AddRange
                (
                new Song
                {
                    title = "Don't Stop Believing",
                    artist = "Journey",
                    genre = "Soft Rock",
                    album = "Escape",
                    ReleaseDate = DateTime.Parse("1981-3-13")
                },
                new Song
                {
                    title = "Thriller",
                    artist = "Michael Jackson",
                    genre = "Soft Rock",
                    album = "Escape",
                    ReleaseDate = DateTime.Parse("1981-3-13")
                },
                new Song
                {
                    title = "Eye of the Tiger",
                    artist = "Journey",
                    genre = "Soft Rock",
                    album = "Escape",
                    ReleaseDate = DateTime.Parse("1981-3-13")
                },
                new Song
                {
                    title = "Song 4",
                    artist = "Journey",
                    genre = "Soft Rock",
                    album = "Escape",
                    ReleaseDate = DateTime.Parse("1981-3-13")
                },
                new Song
                {
                    title = "Song 5",
                    artist = "Journey",
                    genre = "Soft Rock",
                    album = "Escape",
                    ReleaseDate = DateTime.Parse("1981-3-13")
                }
                );
            context.SaveChanges();
            {

            }
        }
    }
}
