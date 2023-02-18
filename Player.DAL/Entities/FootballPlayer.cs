using Player.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL.Entities
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DOB { get; set; }
        public string Image { get; set; }
        public Positions Position { get; set; }
        [ForeignKey("Club")]
        public int ClubId { get; set; }
        public Club Club { get; set; }
    }
}
