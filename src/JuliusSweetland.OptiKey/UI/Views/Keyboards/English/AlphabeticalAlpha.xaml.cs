﻿using JuliusSweetland.OptiKey.UI.Controls;

namespace JuliusSweetland.OptiKey.UI.Views.Keyboards.English
{
    /// <summary>
    /// Interaction logic for AlphabeticalAlpha.xaml
    /// </summary>
    public partial class AlphabeticalAlpha : KeyboardView
    {
        public AlphabeticalAlpha() : base(shiftAware: true)
        {
            InitializeComponent();
        }
    }
}
