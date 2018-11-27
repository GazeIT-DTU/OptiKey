﻿using System;
using JuliusSweetland.OptiKey.UI.ViewModels.Keyboards.Base;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Keyboards
{
    class ExperimentalKeyboardWithPhrasesNumbersAndSymbolsKeyboard1 : BackActionKeyboard, IConversationKeyboard
    {
        public ExperimentalKeyboardWithPhrasesNumbersAndSymbolsKeyboard1(Action backAction)
            : base(backAction, simulateKeyStrokes: false, multiKeySelectionSupported: true)
        {
        }
    }
}
