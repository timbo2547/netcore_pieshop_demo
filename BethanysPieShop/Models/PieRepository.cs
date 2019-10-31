using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        //Since 
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _dbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek 
        {
            get
            {
                return _dbContext.Pies.Include(c => c.Category).Where(pie => pie.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
