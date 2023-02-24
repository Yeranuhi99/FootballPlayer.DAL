using Player.DAL.Entities;
using Player.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.BLL.ViewModels
{
    public class PlayerVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DOB { get; set; }
        public string Image { get; set; }
        public Positions Position { get; set; }
        public int ClubId { get; set; }
    }
}
