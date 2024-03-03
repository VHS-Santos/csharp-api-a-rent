using ARent.Domain.Interfaces.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARent.Domain.Arguments.Deliveryman
{
    public class AddDeliverymanResponse : IResponse
    {
        public Guid id { get; set; }

        public string Message { get; set; }
    }
}
