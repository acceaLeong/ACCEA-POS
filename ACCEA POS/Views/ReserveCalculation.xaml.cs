﻿using ACCEA_POS.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ACCEA_POS.Views;

/// <summary>
/// Interaction logic for ReserveCalculation.xaml
/// </summary>
public partial class ReserveCalculation : Window
{
    public ReserveCalculation()
    {
        DataContext = new ReserveCalculationVM();

        InitializeComponent();
    }
}
