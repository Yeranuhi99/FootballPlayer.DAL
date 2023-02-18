using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.DAL.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string Stadium { get; set; }
        public virtual ICollection<FootballPlayer> Players { get; set; }
    }
}
