﻿using System;
using Cosmos.IL2CPU.API.Attribs;
using Cosmos.System;

namespace KernelGen3 {
    static public class Boot {
        [BootEntry]
        static private void Init() {
            Cosmos.Platform.PC.Debug.ShowText();

            while (true) {
            }
        }
    }
}