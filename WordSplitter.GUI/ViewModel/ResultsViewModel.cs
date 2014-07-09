using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Practices.Prism.Events;
using WordSplitter.GUI.Display;

namespace WordSplitter.GUI.ViewModel
{
    public class ResultsViewModel : ViewModelBase
    {
        private readonly IInstanceCounter _counter;

        public ObservableCollection<ResultDisplay> Results { get; set; }
        
        public ResultsViewModel(IInstanceCounter counter, IEventAggregator aggregator)
            :base(aggregator)
        {
            _counter = counter;

            _aggregator.GetEvent<CountEvent>().Subscribe(SetResults);
        }

        private void SetResults(string sentence)
        {
            Results = new ObservableCollection<ResultDisplay>(_counter.Count(sentence).Select(r => new ResultDisplay(){Word = r.Key, Count = r.Value.ToString()} ));

            OnPropertyChanged("Results");
        }
    }
}

