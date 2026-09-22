using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        [Key]
        public virtual int Id { get; set; }
        [DisplayName("Type Name")]
        [StringLength(25, MinimumLength = 5)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} has to be filled.")]
        public virtual string TypeName { get; set; }

        [Range(2, 5, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public virtual int Point { get; set; }

        public virtual int Force { get; set; }

        [ValidateNever]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
