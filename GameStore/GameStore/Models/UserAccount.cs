using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage ="Imie jest wymagane.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Nazwisko jest wymagane.")]
        public string LastName { get; set; }
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Podaj prawidlowy adres email.")]
        public string EmailUser { get; set; }
        [Required(ErrorMessage ="Nazwa uzytkownika jest wymagana.")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Haslo jest wymagane.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Potwierdz swoje haslo.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}