﻿using All_In_One_Planner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace All_In_One_Planner.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarPage : ContentPage
        
    {
        public CalendarPage()
        {
            InitializeComponent();
            BindingContext  =new CalendarViewModel();
        }
    }
}