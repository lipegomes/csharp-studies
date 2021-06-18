using System;
using System.Collections.Generic;
using System.Linq;
using DevStore.Domain.StoreContext.Enums;

namespace DevStore.Domain.StoreContext.Entities
{
    public class Order
    {
        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;
        public Order(Customer customer)
        {
            Customer = customer;
            CreateDate =DateTime.Now;
            Status = EOrderStatus.Created;
            _items = new List<OrderItem>();
            _deliveries = new List<Delivery>();
        }
        public Customer Customer { get; private set; }
        public string Number { get; private set; }
        public DateTime CreateDate { get; private set; }
        public EOrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.ToArray();
        public IReadOnlyCollection<Delivery> Deliveries  => _deliveries.ToArray();

        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }
        
        public void AddDelivery(Delivery delivery)
        {
            _deliveries.Add(delivery);
        }

        // To Place An Order
        public void Place(){
            // Gera o número do pedido
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            // Validar
        }
        
        // Pagar um pedido
        public void Pay()
        {
            Status = EOrderStatus.Paid;
        }
        // Enviar um pedido
        public void Ship()
        {
            // A cada 5 produtos é uma entrega
            var deliveries = new List<Delivery>();
            deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
            var count = 1;

            // Quebra as entregas
            foreach (var item in _items)
            {
                if (count == 5)
                {
                    count = 1;
                    deliveries.Add(new Delivery(DateTime.Now.AddDays(5)));
                }
                count++;
            }

            // Envia todos as entregas
            deliveries.ForEach(x => x.Ship());

            // Adiciona as entregas ao pedido
            deliveries.ForEach(x => _deliveries.Add(x));

            var delivery = new Delivery(DateTime.Now.AddDays(5));
            _deliveries.Add(delivery);
        }

        // Cancelar um pedido
        public void Cancel()
        {
            Status = EOrderStatus.Canceled;
            _deliveries.ToList().ForEach(x => x.Cancel());
        }
        
    }
}