﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace classSevenList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                PageDataViewModel pageData = args.SelectedItem as PageDataViewModel;
                //Page page = (Page)Activator.CreateInstance(pageData.Title);
                //await Navigation.PushAsync(page);
                await DisplayAlert("Clicked!", pageData.Title + " " + pageData.Description, "OK");
                }
            }
        }
    }
