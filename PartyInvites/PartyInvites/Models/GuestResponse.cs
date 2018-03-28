using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
                
namespace PartyInvites.Models
{
    public class GuestResponse
   {
        [Required(ErrorMessage = "Podaj imię i nazwisko")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj adres e-mail")]
        [RegularExpression(".+\\@.+\\..", ErrorMessage = "Podaj poprawny adres e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Podaj numer telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Będziesz czy nie??")]
        public bool? WillAttend { get; set; }
    }
}