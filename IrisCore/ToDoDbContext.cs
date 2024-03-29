﻿using IrisCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrisCore
{

    public class ToDoDbContex : DbContext
    {
        public ToDoDbContex(DbContextOptions<ToDoDbContex> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDo { get; set; }
    }
}
