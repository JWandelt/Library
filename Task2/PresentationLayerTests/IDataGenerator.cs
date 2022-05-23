using Service.IData;
using System.Collections.Generic;

namespace PresentationLayerTests
{
    public interface IDataGenerator
    {
        decimal BookId { get; set; }
        List<IBook> Books { get; }
        string Description { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        decimal LendListId { get; set; }
        List<ILendList> LendLists { get; }
        decimal ReaderId { get; set; }
        List<IReader> Readers { get; }
        string Title { get; set; }

        void InitializeData();
    }
}