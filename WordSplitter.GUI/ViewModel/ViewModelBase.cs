using System;
using System.ComponentModel;
using Microsoft.Practices.Prism.Events;
using WordSplitter.GUI.Annotations;

namespace WordSplitter.GUI.ViewModel
{
    public abstract class ViewModelBase : IDataErrorInfo, INotifyPropertyChanged, IDisposable
    {
        protected readonly IEventAggregator _aggregator;

        protected ViewModelBase(IEventAggregator aggregator)
        {
            _aggregator = aggregator;
        }

        public string this[string columnName]
        {
            get { throw new NotImplementedException(); }
        }

        public string Error { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Dispose()
        {
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}