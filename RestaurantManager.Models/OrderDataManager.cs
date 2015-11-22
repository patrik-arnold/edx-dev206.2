using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private List<MenuItem> _currentlySelectedMenuItems;
        private List<MenuItem> _menuItems;

        public List<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                if (Equals(_menuItems, value)) return;
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public List<MenuItem> CurrentlySelectedMenuItems
        {
            get { return _currentlySelectedMenuItems; }
            set
            {
                if (Equals(_currentlySelectedMenuItems, value)) return;
                _currentlySelectedMenuItems = value;
                OnPropertyChanged();
            }
        }

        protected override void OnDataLoaded()
        {
            MenuItems = Repository.StandardMenuItems;

            CurrentlySelectedMenuItems = new List<MenuItem>
            {
                MenuItems[3],
                MenuItems[5]
            };
        }
    }
}