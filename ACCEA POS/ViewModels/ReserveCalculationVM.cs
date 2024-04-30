using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ACCEA_POS.ViewModels;

public partial class ReserveCalculationVM : ObservableObject
{
    // Hundres
    [ObservableProperty]
    public string _hundreds = "0";

    partial void OnHundredsChanged(string value)
    {
        OnPropertyChanged(nameof(HundredsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal HundredsTotal => Int32.Parse(!string.IsNullOrEmpty(Hundreds) ? Hundreds : "0") * 100.00M;
    
    // Fiftys
    [ObservableProperty]
    public int _fiftys = 0;

    partial void OnFiftysChanged(int value)
    {
        OnPropertyChanged(nameof(FiftysTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiftysTotal => Fiftys * 50.00M;

    // Twentys
    [ObservableProperty]
    public int _twentys = 0;

    partial void OnTwentysChanged(int value)
    {
        OnPropertyChanged(nameof(TwentysTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TwentysTotal => Twentys * 20.00M;

    // Tens
    [ObservableProperty]
    public int _tens = 0;

    partial void OnTensChanged(int value)
    {
        OnPropertyChanged(nameof(TensTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TensTotal => Tens * 10.00M;

    // Fives
    [ObservableProperty]
    public int _fives = 0;

    partial void OnFivesChanged(int value)
    {
        OnPropertyChanged(nameof(FivesTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FivesTotal => Fives * 5.00M;

    // Ones
    [ObservableProperty]
    public int _ones = 0;

    partial void OnOnesChanged(int value)
    {
        OnPropertyChanged(nameof(OnesTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal OnesTotal => Ones * 1.00M;

    // FiftyCents
    [ObservableProperty]
    public int _fiftyCents = 0;

    partial void OnFiftyCentsChanged(int value)
    {
        OnPropertyChanged(nameof(FiftyCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiftyCentsTotal => FiftyCents * 0.50M;

    // TwentyCents
    [ObservableProperty]
    public int _twentyCents = 0;

    partial void OnTwentyCentsChanged(int value)
    {
        OnPropertyChanged(nameof(TwentyCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TwentyCentsTotal => TwentyCents * 0.20M;

    // TenCents
    [ObservableProperty]
    public int _tenCents = 0;

    partial void OnTenCentsChanged(int value)
    {
        OnPropertyChanged(nameof(TenCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TenCentsTotal => TenCents * 0.10M;

    // FiveCents
    [ObservableProperty]
    public int _fiveCents = 0;

    partial void OnFiveCentsChanged(int value)
    {
        OnPropertyChanged(nameof(FiveCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiveCentsTotal => FiveCents * 0.05M;

    public Decimal GrandTotal => HundredsTotal + FiftysTotal + TwentysTotal + TensTotal + FivesTotal + OnesTotal + FiftyCentsTotal + TwentyCentsTotal + TenCentsTotal + FiveCentsTotal;

    private int selected;

    [RelayCommand]
    private void UpdateOneClick()
    {
        switch (selected)
        {
            case 1:
                Hundreds += "1";

                break;
            default:
                break;
        }
    }

    [RelayCommand]
    private void GotFocus(object obj)
    {
        selected = Int16.Parse(obj.ToString() ?? "0");
    }
}

