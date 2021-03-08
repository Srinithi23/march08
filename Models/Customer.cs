using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace march08.Models
{ 
    public class Customer
    {
        [Required (ErrorMessage = "Enter Your Id")]
        public int Id { get; set; }

       
        public String Name { get; set; }

        public String Phone { get; set; }
    }
}