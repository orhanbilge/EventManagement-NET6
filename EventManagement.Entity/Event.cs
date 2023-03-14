using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Entity;

public class Event : BaseEntity
{
    public DateTime Date { get; set; }
    public ClassRoom ClassRoom { get; set; }
    public Lesson Lesson { get; set; }
    public Teacher Teacher { get; set; }
}