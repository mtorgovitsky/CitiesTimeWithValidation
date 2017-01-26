using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitiesTimeWithValidation.Models
{
    public class CitiesDB
    {
        public List<City> Cities { get; set; }
        [SelectionCheck(ErrorMessage = "Please Choose City from The List")]
        public int SelectedID { get; set; }

        public CitiesDB()
        {
            Cities = new List<City>
            {
                new City {ID = 0, Name = "Select City" },
                new City {ID = 1, Name = "Jerusalem", CurrentTime = DateTime.Now },
                new City {ID = 2, Name = "New York", CurrentTime = DateTime.Now.AddHours(-12) },
                new City {ID = 3, Name = "Uman", CurrentTime = DateTime.Now.AddHours(+1) }
            };
        }
    }
}