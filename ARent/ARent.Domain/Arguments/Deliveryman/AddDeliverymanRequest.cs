using ARent.Domain.Interfaces.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARent.Domain.Arguments.Deliveryman
{
    public class AddDeliverymanRequest : IRequest
    {
        public string name { get; set; }

        public int cnpj { get; set; }

        public DateTime birth { get; set; }

        public int cnhNumber { get; set; }

        public string cnhType { get; set; }

        public byte cnhImg { get; set; }
    }
}
