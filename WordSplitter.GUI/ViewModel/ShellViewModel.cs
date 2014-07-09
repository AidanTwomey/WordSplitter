using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;

namespace WordSplitter.GUI.ViewModel
{
    public class CountEvent : CompositePresentationEvent<string> { }

    public class ShellViewModel : ViewModelBase
    {
        public string Input { get; set; }

        public ResultsViewModel ResultsViewModel { get; private set; }

        public ICommand SubmitCommand { get; private set; }

        public ShellViewModel(ResultsViewModel results, IEventAggregator aggregator)
            :base(aggregator)
        {
            ResultsViewModel = results;

            SubmitCommand= new DelegateCommand(() => _aggregator.GetEvent<CountEvent>().Publish(Input));
        }
    }
}
