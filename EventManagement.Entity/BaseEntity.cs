﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Entity;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public DateTime CreatedAt {
        get
        {
            return DateTime.Now;
        }
        set
        {
            DateTime d = DateTime.Now;
        }
    }
}