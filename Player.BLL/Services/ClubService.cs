using Player.BLL.Services.Interfaces;
using Player.BLL.ViewModels;
using Player.DAL.Entities;
using Player.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.BLL.Services
{
    public class ClubService : IClubService
    {
       private readonly IClubRepository _clubRepository;
        private readonly IUnitofWork _uow;
        public ClubService(IClubRepository clubRepository,IUnitofWork uow)
        {
            _clubRepository = clubRepository;
            _uow = uow;
        }   

        public void Add(ClubVM model)
        {
            Club club = new()
            {
                Name = model.Name,
                FoundingDate= model.FoundingDate,
                Stadium = model.Stadium,
            };
            _clubRepository.Add(club);
            _uow.Save();
        }

        public void Delete(int id)
        {
            _clubRepository.Delete(id);
            _uow.Save();
        }

        public List<ClubVM> GetAll()
        {
            var data = _clubRepository.GetAll().Select(c => new ClubVM()
            {
                FoundingDate = c.FoundingDate,
                Id = c.Id,
                Name = c.Name,
                Stadium = c.Stadium,
            }).ToList();
            return data;
        }

        public ClubVM GetById(int id)
        {
            var data = _clubRepository.GetById(id);
            ClubVM model = new ClubVM() 
            {
                FoundingDate = data.FoundingDate,
                Id = data.Id,
                Name = data.Name,
                Stadium = data.Stadium,
            };
            return model;
        }

        public ClubVM GetForEdit(int id)
        {
           
        }

        public void Update(ClubVM model)
        {
            
        }
    }
}
