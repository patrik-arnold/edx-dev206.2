using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public abstract class DataManager : INotifyPropertyChanged
    {
        public DataManager()
        {
            LoadData();
        }

        protected RestaurantContext Repository { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void LoadData()
        {
            Repository = new RestaurantContext();
            await Repository.InitializeContextAsync();
            OnDataLoaded();
        }

        protected abstract void OnDataLoaded();

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}