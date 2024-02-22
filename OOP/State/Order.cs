using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Order
    {
        private IOrderState orderState;
        public Order(IOrderState orderState) { this.orderState = orderState; }
        public String Id { get; set; }
        public String Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get { return orderState.Status; } }
        public override string ToString()
        {
            return "Dear " + Customer + ", your order " + Id + " is " + Status;
        }
        public bool CanCancel() { return orderState.CanCancel(this); }
        public bool CanShip() { return orderState.CanShip(this); }
        public void Cancel() { if (CanCancel()) orderState.Cancel(this); }
        public void Ship() { if (CanShip()) orderState.Ship(this); }
        public void Change(IOrderState orderState) { this.orderState = orderState; }
    }
}
