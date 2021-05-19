using DDD.Domain.Repositories;
using DDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class LatestViewModel : INotifyPropertyChanged
    {
        private IMeasureRepository _measureRepository;

        public event PropertyChangedEventHandler PropertyChanged;

        public LatestViewModel() : this(Factories.CreateMeasureRepository())
        {
        }

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
            var entity = _measureRepository.GetLatest();
            MeasureDate = entity.MeasureDate.DisplayValue;
            MeasureValue = entity.MeasureValue.DisplayValue;
        }

        private string _measureValue = "";
        public string MeasureValue
        {
            get => _measureValue;
            set => SetProperty(ref _measureValue, value);
        }

        private string _measureDate = "";
        public string MeasureDate
        {
            get => _measureDate;
            set => SetProperty(ref _measureDate, value);
        }

        protected virtual bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }

    }
}
