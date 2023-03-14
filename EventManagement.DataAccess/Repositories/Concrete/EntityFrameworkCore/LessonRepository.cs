using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagement.DataAccess.Contexts;
using EventManagement.DataAccess.Repositories.Abstract;
using EventManagement.Entity;

namespace EventManagement.DataAccess.Repositories.Concrete.EntityFrameworkCore;

public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
{
    public LessonRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
