﻿using DDD.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.WinForm.ViewModels
{
    public class MeasureListViewModel
    {
        private IMeasureRepository _measureRepository;
        //public MeasureListViewModelMeasure() : this()

        public MeasureListViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;

            foreach (var entity in _measureRepository.GetData())
            {
                Measures.Add(new MeasureListViewModelMeasure());
            }
        }


        public BindingList<MeasureListViewModelMeasure> Measures { get; set; } = new BindingList<MeasureListViewModelMeasure>();
    }
}
