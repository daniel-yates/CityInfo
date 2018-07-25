namespace CityInfo.API.Models
{
    using System.Collections.Generic;

    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberofPointsofInterest {
            get
            {
                return PointsofInterest.Count;
            }
        }

        public ICollection<PointOfInterestDto> PointsofInterest { get; set; }
        = new List<PointOfInterestDto>();
    }
}
