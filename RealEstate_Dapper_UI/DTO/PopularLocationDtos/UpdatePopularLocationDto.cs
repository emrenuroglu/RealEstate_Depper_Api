﻿namespace RealEstate_Dapper_UI.DTOS.PopularLocationDtos
{
    public class UpdatePopularLocationDto
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public string ImageUrl { get; set; }
        public int PropertyCount { get; set; }

    }
}
