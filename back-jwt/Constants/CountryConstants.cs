using System;
using back_jwt.Models;

namespace back_jwt.Constants
{
	public class CountryConstants
	{
        public static List<CountryModel> Countrys = new List<CountryModel>()
        {
            new CountryModel() { Name = "Argentina"},
            new CountryModel() { Name = "Peru"},
            new CountryModel() { Name = "Mexico"},
        };
    }
}

