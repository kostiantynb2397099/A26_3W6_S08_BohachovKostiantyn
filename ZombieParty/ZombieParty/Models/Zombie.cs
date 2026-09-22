using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class Zombie
    {
        public virtual int Id { get; set; }

        public virtual int Force { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [StringLength(255)]
        public virtual string ShortDesc { get; set; }

        [Range(1, 20, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public virtual int Point { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        public virtual int ZombieTypeId { get; set; }
        [ValidateNever] 
        public virtual ZombieType? ZombieType { get; set; }

        [ValidateNever] 
        public virtual List<HuntingLog> HuntingLogs { get; set; }
    }
}
