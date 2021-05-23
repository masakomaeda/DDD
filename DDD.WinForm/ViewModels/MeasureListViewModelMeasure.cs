using DDD.Domain.Entities;
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
    public class MeasureListViewModelMeasure 
    {

  
        public string MeasureValue => _entity.MeasureValue.DisplayValue;
        public string MeasureDate => _entity.MeasureDate.DisplayValue;
        //public MeasureListViewModelMeasure() : this(Factories.CreateSensorRepository())
        //{
        //}

        public MeasureListViewModelMeasure(MeasureEntity entity)
        {
            _entity = entity;
        }

        private MeasureEntity _entity;

        //public void Measures()
        //{
        //    var value = _sensorRepository.GetData();
        //    MeasureValue = value.DisplayValue;
        //}
    }
}
