using System;

namespace ARent.Domain.Entities
{
    public class Deliveryman
    {
        public Guid id { get; private set; }

        public string name { get; private set; }

        public int cnpj { get; private set; }

        public DateTime birth { get; private set; }

        public int cnhNumber { get; private set; }

        public string cnhType { get; private set; }

        public byte cnhImg { get; private set; }
    }
}
