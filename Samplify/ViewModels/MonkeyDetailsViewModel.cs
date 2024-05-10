using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplify.ViewModels
{
    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeyDetailsViewModel: BaseViewModel
    {
        private readonly MonkeyService monkeyService;
        public MonkeyDetailsViewModel(MonkeyService monkeyService) 
        { 
            this.monkeyService = monkeyService;
            this.Title = "Monkey Details";
        }


        [ObservableProperty]
        private Monkey monkey;
    }
}
