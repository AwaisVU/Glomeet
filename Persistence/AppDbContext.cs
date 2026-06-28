using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{   
    public DbSet<Activity> Activities {get; set;}

    public void RemoveAsync(ValueTask<Activity?> activity)
    {
        throw new NotImplementedException();
    }
}
