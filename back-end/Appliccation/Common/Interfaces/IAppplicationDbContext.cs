﻿using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Song> Song { get; set; }

        DbSet<Album> Album { get; set; }

        DbSet<Concert> Concert { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    }
}
