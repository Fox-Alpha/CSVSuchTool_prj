using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSVSuchToolWPF.Models;
using Stylet;
using StyletIoC;

namespace CSVSuchToolWPF.ViewModels
{
    public class MainWindowViewModel : Screen
    {
        public MainWindowViewModel()
        {

        }

        [Inject]
        public SettingsModel Settings { get; private set; }
    }
}
