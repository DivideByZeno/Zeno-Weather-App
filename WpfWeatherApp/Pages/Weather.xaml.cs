﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using WpfWeatherApp;
using ZenoWeatherApp.Model;
using ZenoWeatherApp.Services;

namespace ZenoWeatherApp.Pages;
/// <summary>
/// Interaction logic for Weather.xaml
/// </summary>
public partial class Weather : Page
{
    public Weather()
    {
        InitializeComponent();
    }

    private async void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            if (MainWindow.MainViewModel.WeatherViewModel.GetForecast.CanExecute(null))
                MainWindow.MainViewModel.WeatherViewModel.GetForecast.Execute(null);
        }
    }
}
