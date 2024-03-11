using PhoneBookWPF.View;
using PhoneBookWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PhoneBookWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static PhoneBookWindow PhoneBookWindow = new PhoneBookWindow();

        public static RecordsView RecordsView = new RecordsView();

        public static ActionsWithRecordView ActionsWithRecordView = new ActionsWithRecordView();

    }
}
