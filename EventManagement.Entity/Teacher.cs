﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Entity;

public class Teacher : BaseEntity
{
    public string Name { get; set; }
    public string SurName { get; set; }
}