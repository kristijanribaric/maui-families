﻿using MauiFamilies.ViewModel;

namespace MauiFamilies;

public partial class MainPage : ContentPage
{
    public MainPage( MainViewModel mvm ) {
        InitializeComponent();
        BindingContext = mvm;
    }
}

