﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlCommandTest1.Interface
{
    interface Command
    {
        void execute();
        void undo();
    }
}
