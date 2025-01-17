﻿using All_In_One_Planner.ViewModels;
using All_In_One_Planner.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace All_In_One_Planner
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MemoDetailPage), typeof(MemoDetailPage));
            Routing.RegisterRoute(nameof(NewMemoPage), typeof(NewMemoPage));
            Routing.RegisterRoute(nameof(WeeklyPage), typeof(WeeklyPage));
            Routing.RegisterRoute(nameof(CalendarPage), typeof(CalendarPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
