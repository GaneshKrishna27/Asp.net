using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HandsOnMVCUsingModelValidation.Models
{
    public class User
    {
        [Required(ErrorMessage ="plz enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "invalid Email")]
        public string Email { get; set; }
        //[Range(typeof[DateTime],"01-01-1900","25-01-2020" ,ErrorMessage = "")]
        public DateTime Dob { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="invalid Data")]
        public string Mobno { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="invalid data")]
        public string Country { get; set; }
        [Required(ErrorMessage ="enter username")]
        public string Uname { get; set; }
        [RegularExpression(@"[a-z0-9]{6,10}",ErrorMessage ="invalid password")]
        public string Pwd { get; set; }
    }
}
