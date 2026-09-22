using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public virtual int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]
        public virtual string Title { get; set; }
        [StringLength(255)]
        public virtual string Description { get; set; }
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
