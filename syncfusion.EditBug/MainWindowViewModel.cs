using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Syncfusion.Windows.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.EditBug
{
    internal class MainWindowViewModel: ObservableObject, INotifyPropertyChanged
    {

        //  ==============================================================================================
        //  PROPERTIES

        private string editText;
        private string editLanguage = "Text";
        private Languages selectedLanguage = Syncfusion.Windows.Edit.Languages.Text;

        public string EditText { get => editText; set => SetProperty(ref editText, value); }
        public IEnumerable<Languages> Languages { get => Enum.GetValues(typeof(Languages)).Cast<Languages>(); }
        public Languages SelectedLanguage { get => selectedLanguage; set => SetProperty(ref selectedLanguage, value); }

        //  ==============================================================================================
        //  COMMANDS




        public MainWindowViewModel()
        {
            EditText = Properties.Resources.SampleXML;
        }

  

    }
}
