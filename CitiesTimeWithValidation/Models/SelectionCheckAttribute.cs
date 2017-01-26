using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CitiesTimeWithValidation.Models
{
    public class SelectionCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if ((int)value == 0)
                return false;
            else
                return true;
        }
    }
}