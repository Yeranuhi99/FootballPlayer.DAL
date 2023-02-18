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
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FootballPlayerDBContext _context;
        public PlayerRepository(FootballPlayerDBContext context)
        {
            _context = context;
        }
        public void Add(FootballPlayer model)
        {
            _context.FootballPlayer.Add(model);
        }

        public void Delete(int id)
        {
            _context.FootballPlayer.Remove(GetById(id));

        }

        public List<FootballPlayer> GetAll()
        {
            var data = _context.FootballPlayer.AsNoTracking().ToList();
            return data;
        }

        public FootballPlayer GetById(int id)
        {
            var data = _context.FootballPlayer.Where(fb => fb.Id == id).AsNoTracking().FirstOrDefault();
            return data;

        }

        public FootballPlayer GetForEdit(int id)
        {
            var data = _context.FootballPlayer.Where(fb => fb.Id == id).FirstOrDefault();
            return data;
        }

        public void Update(FootballPlayer model)
        {
            var data = _context.FootballPlayer.FirstOrDefault(fb => fb.Id == model.Id);
            data.Name = model.Name;
            data.SurName = model.SurName;
            data.DOB = model.DOB;
            data.ClubId = model.ClubId;
            data.Image = model.Image;
            data.Position = model.Position;
        }
    }
}
