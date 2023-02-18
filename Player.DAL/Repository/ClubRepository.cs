using Microsoft.EntityFrameworkCore;
using Player.DAL.Entities;
using Player.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly FootballPlayerDBContext _context;
        public ClubRepository(FootballPlayerDBContext context)
        {
            _context = context;
        }

        public void Add(Club model)
        {
            _context.Club.Add(model);
        }

        public void Delete(int id)
        {
            _context.Club.Remove(GetById(id));
        }

        public List<Club> GetAll()
        {
            return _context.Club.AsNoTracking().ToList();
        }

        public Club GetById(int id)
        {
            var data = _context.Club.Where(fb => fb.Id == id).AsNoTracking().FirstOrDefault();
            return data;

        }

        public Club GetForEdit(int id)
        {
            var data = _context.Club.Where(fb => fb.Id == id).FirstOrDefault();
            return data;
        }

        public void Update(Club model)
        {
            var data = _context.Club.FirstOrDefault(fb => fb.Id == model.Id);
            data.Name = model.Name;
            data.FoundingDate = model.FoundingDate;
            data.Stadium = model.Stadium;
        }
    }
}
