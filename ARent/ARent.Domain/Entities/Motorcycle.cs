using ARent.Domain.Entities.Enum;
using System;

namespace ARent.Domain.Entities
{
    public class Motorcycle
    {
        public Guid id { get; set; }

        public int year { get; set; }

        public string model { get; set; }

        public string licensePlate { get; set; }

        public StatusMotorcylce status { get; set; }
    }
}
