using ARent.Domain.Arguments.Deliveryman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARent.Domain.Interfaces.Services
{
    public interface IServiceDeliveryman
    {
        AddDeliverymanResponse AddDeliveryman(AddDeliverymanRequest request);
    }
}
