using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_project_Starter.Models;

namespace MVC_project_Starter.Data
{
    public class MvcSongContext : DbContext
    {
        public MvcSongContext(DbContextOptions<MvcSongContext> options) : base(options)
        {

        }

        public DbSet<Song> Song { get; set; }
    }
}
