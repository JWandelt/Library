using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class DeleteReaderCommand : CommandBase
    {
        LibraryViewModel library;
        ReaderModel reader;

        public DeleteReaderCommand(LibraryViewModel library, ReaderModel readerModel)
        {
            this.library = library;
            this.reader = readerModel;
        }

        public override void Execute(object parameter)
        {
            reader.Service.removeReader(library.ReaderIDToremove);
            library.ReaderIDToremove = 0;
            library.RefreshReaders();
        }
    }
}
