﻿using System;
using Neutronium.MVVMComponents;
using Neutronium.MVVMComponents.Relay;

namespace MVVM.ViewModel.Example
{
    public class FakeFactory<TIn,TOut> : ViewModelBase
    {
        public FakeFactory(Func<TIn, TOut> iFact)
        {
            CreateObject = RelayResultCommand.Create(iFact);
        }

        public IResultCommand CreateObject { get; set; }

        private string _Name=null;
        public string Name
        {
            get { return _Name; }
            set { Set(ref _Name, value, "Name"); }
        }
    }
}
