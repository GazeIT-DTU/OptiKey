﻿using JuliusSweetland.OptiKey.UI.Controls;
using JuliusSweetland.OptiKey.Services;

namespace JuliusSweetland.OptiKey.UI.Views.Keyboards.Common
{
    /// <summary>
    /// Interaction logic for ExperimentalNumericAndSymbols1.xaml
    /// </summary>
    public partial class ExperimentalKeyboardWithoutPhrasesNumericAndSymbols1 : KeyboardView
    {
        public ExperimentalKeyboardWithoutPhrasesNumericAndSymbols1()
        {
            this.DataContext = InstanceGetter.Instance.MainViewModel.ExperimentMenuViewModel;
            InitializeComponent();
        }
    }
}