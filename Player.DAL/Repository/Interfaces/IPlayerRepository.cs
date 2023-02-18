using Player.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL.Repository.Interfaces
{
    public interface IPlayerRepository 
    {
        void Add(FootballPlayer model);
        void Update(FootballPlayer model);
        void Delete(int id);
        FootballPlayer GetById (int id);
        FootballPlayer GetForEdit(int id);
        List<FootballPlayer> GetAll();
    }
}
