﻿using Microsoft.EntityFrameworkCore;


namespace L02P02_2022VF650_2022MV652.Models
{
    public class libreriaDbContext : DbContext
    {
        public libreriaDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
