using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineExam.App.Models
{
    public class UserLoginViewModel
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "User Name Is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }
        public string UserType { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        [StringLength(50, MinimumLength = 3)]

        [DataType(DataType.Password)]
        public string Password { get; set; }
         [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        [StringLength(50, MinimumLength = 3)]

       
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime CreateDate { get; set; }
        //[ForeignKey("User")]
        public int CreateById { get; set; }
        public DateTime LastLogIn { get; set; }
        public string Status { get; set; }


    }
}