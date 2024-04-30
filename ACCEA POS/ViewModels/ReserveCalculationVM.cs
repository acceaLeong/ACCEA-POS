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
    public string _fiftys = "0";

    partial void OnFiftysChanged(string value)
    {
        OnPropertyChanged(nameof(FiftysTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiftysTotal => Int32.Parse(!string.IsNullOrEmpty(Fiftys) ? Fiftys : "0") * 50.00M;

    // Twentys
    [ObservableProperty]
    public string _twentys = "0";

    partial void OnTwentysChanged(string value)
    {
        OnPropertyChanged(nameof(TwentysTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TwentysTotal => Int32.Parse(!string.IsNullOrEmpty(Twentys) ? Twentys : "0") * 20.00M;

    // Tens
    [ObservableProperty]
    public string _tens = "0";

    partial void OnTensChanged(string value)
    {
        OnPropertyChanged(nameof(TensTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TensTotal => Int32.Parse(!string.IsNullOrEmpty(Tens) ? Tens : "0") * 10.00M;

    // Fives
    [ObservableProperty]
    public string _fives = "0";

    partial void OnFivesChanged(string value)
    {
        OnPropertyChanged(nameof(FivesTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FivesTotal => Int32.Parse(!string.IsNullOrEmpty(Fives) ? Fives : "0") * 5.00M;

    // Ones
    [ObservableProperty]
    public string _ones = "0";

    partial void OnOnesChanged(string value)
    {
        OnPropertyChanged(nameof(OnesTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal OnesTotal => Int32.Parse(!string.IsNullOrEmpty(Ones) ? Ones : "0") * 1.00M;

    // FiftyCents
    [ObservableProperty]
    public string _fiftyCents = "0";

    partial void OnFiftyCentsChanged(string value)
    {
        OnPropertyChanged(nameof(FiftyCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiftyCentsTotal => Int32.Parse(!string.IsNullOrEmpty(FiftyCents) ? FiftyCents : "0") * 0.50M;

    // TwentyCents
    [ObservableProperty]
    public string _twentyCents = "0";

    partial void OnTwentyCentsChanged(string value)
    {
        OnPropertyChanged(nameof(TwentyCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TwentyCentsTotal => Int32.Parse(!string.IsNullOrEmpty(TwentyCents) ? TwentyCents : "0") * 0.20M;

    // TenCents
    [ObservableProperty]
    public string _tenCents = "0";

    partial void OnTenCentsChanged(string value)
    {
        OnPropertyChanged(nameof(TenCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal TenCentsTotal => Int32.Parse(!string.IsNullOrEmpty(TenCents) ? TenCents : "0") * 0.10M;

    // FiveCents
    [ObservableProperty]
    public string _fiveCents = "0";

    partial void OnFiveCentsChanged(string value)
    {
        OnPropertyChanged(nameof(FiveCentsTotal));
        OnPropertyChanged(nameof(GrandTotal));
    }

    public Decimal FiveCentsTotal => Int32.Parse(!string.IsNullOrEmpty(FiveCents) ? FiveCents : "0") * 0.05M;

    public Decimal GrandTotal => HundredsTotal + FiftysTotal + TwentysTotal + TensTotal + FivesTotal + OnesTotal + FiftyCentsTotal + TwentyCentsTotal + TenCentsTotal + FiveCentsTotal;

    private string selected = "";

    [RelayCommand]
    private void UpdateNumberInput(object obj)
    {
        if (obj.ToString() != ".")
        {
            switch (selected)
            {
                case "100":
                    Hundreds += obj.ToString();
                    break;
                case "50":
                    Fiftys += obj.ToString();
                    break;
                case "20":
                    Twentys += obj.ToString();
                    break;
                case "10":
                    Tens += obj.ToString();
                    break;
                case "5":
                    Fives += obj.ToString();
                    break;
                case "1":
                    Ones += obj.ToString();
                    break;
                case "0.5":
                    FiftyCents += obj.ToString();
                    break;
                case "0.2":
                    TwentyCents += obj.ToString();
                    break;
                case "0.1":
                    TenCents += obj.ToString();
                    break;
                case "0.05":
                    FiveCents += obj.ToString();
                    break;
                default:
                    break;
            }
        }
    }

    [RelayCommand]
    private void GotFocus(object obj)
    {
        selected = obj.ToString() ?? "";
    }
}

