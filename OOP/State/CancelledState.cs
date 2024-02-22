using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class CancelledState : IOrderState
    {
        public bool CanShip(Order order) { return false; }
        public void Ship(Order order) { throw new InvalidOperationException("Cannot ship, already cancelled."); }
        public bool CanCancel(Order order) { return false; }
        public void Cancel(Order order) { throw new InvalidOperationException("Already cancelled."); }
        public OrderStatus Status { get { return OrderStatus.Cancelled; } }
    }
}
