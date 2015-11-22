using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        private List<Order> _orderItems;

        public List<Order> OrderItems
        {
            get { return _orderItems; }
            set
            {
                if (Equals(_orderItems, value)) return;
                _orderItems = value;
                OnPropertyChanged();
            }
        }

        protected override void OnDataLoaded()
        {
            OrderItems = Repository.Orders;
        }
    }
}