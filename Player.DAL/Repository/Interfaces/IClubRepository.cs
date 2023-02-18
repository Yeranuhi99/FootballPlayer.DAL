using Player.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL.Repository.Interfaces
{
    public interface IClubRepository
    {
        void Add (Club model);
        void Update(Club model);
        void Delete(int id);
        Club GetById(int id);
        Club GetForEdit(int id);
        List<Club> GetAll();
    }
}
