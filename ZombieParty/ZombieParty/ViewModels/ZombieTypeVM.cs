using ZombieParty.Models;

namespace ZombieParty.ViewModels
{
    public class ZombieTypeVM
    {
        public virtual ZombieType ZombieType { get; set; }
        public virtual List<Zombie> ZombiesList { get; set; } = new List<Zombie>();
        public virtual int ZombiesCount { get; set; }
        public virtual double PointsAverage { get; set; }

    }
}
