using System;

namespace CityGuide.Models
{
    public class City
    {

        public Guid  ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public bool isFeatured { get; set; }

        public DateTime PublishedAt { get; set; }

        public bool isActive { get; set; }

    }
}
