using System.Windows.Input;

namespace PresentationLayerTests
{
    public class ViewModelAPIBase
    {
        public override ICommand AddBookCommand(decimal id, string title, string first_name, string last_name, string description, bool lent)
        {
            return TestCommand;

        }
    }
}