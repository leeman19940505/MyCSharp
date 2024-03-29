﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 支持取消的操作.再设计Command的接口可以设计一个Unexcute用来实现将上一部的执行取消的操作.通过excute和unexcute来控制命令的执行效果.
    /// </summary>
    interface ICommand
    {
        void Excute();
        void UnExcute();
    }
}
