using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Samplify.Models;
using Samplify.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samplify.ViewModels;

public partial class MonkeysViewModel: BaseViewModel
{
    private readonly MonkeyService monkeyService;
    public ObservableCollection<Monkey> Monkeys { get; } = new();

    public MonkeysViewModel(MonkeyService monkeyService) 
    {
        this.monkeyService = monkeyService;
        this.Title = "Monkey Finder";
    }

    [RelayCommand]
    async Task GetMonkeysAsync()
    {
        if(IsBusy) return;

        try
        {
            IsBusy = true;

            var monkeys = await monkeyService.GetMonkeysAsync();
            Monkeys.Clear();

            monkeys.ForEach(monkey => Monkeys.Add(monkey));
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Unable to get monkeys because " + ex.Message);
            await Shell.Current.DisplayAlert("Error", "Unable to get monkeys", "Ok");
        }
        finally { IsBusy = false; }
    }

    [RelayCommand]
    public async Task GoToDetailsAsync(Monkey monkey)
    {
        if (monkey is null)
            return;

        await Shell.Current.GoToAsync($"{nameof(MonkeyDetailsPage)}", true, new Dictionary<string, Object>() { { "Monkey", monkey } });

    }

    [RelayCommand]
    public void DisplayAlert()
    {
        Shell.Current.DisplayAlert(title: "Alert", "This is an alert message", "Ok");
    }
}
