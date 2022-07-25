using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Account
    {
        /*
         * 
         * This is the Account Model which keeps the informations of Customers
         * 
         */
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Account Id
        [Required]
        public string Name { get; set; } // Customer Name
        [Required]
        public string LastName { get; set; } // Customer LastName
        [Required]
        public string NationIdentity { get; set; } // Turkish Citizen ID
        public DateTime Created { get; set; } // Account Creation Date
        public string Address { get; set; } // Customer Contact Address
        public bool Status { get; set; } // Account Status -> Inactive or Active
        public int CardId { get; set; } // Connection between Card Model and Account Model

        [ForeignKey("CardId")]
        public Card Cards { get; set; }
    }
}
