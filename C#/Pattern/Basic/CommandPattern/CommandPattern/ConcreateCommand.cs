﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ConcreateCommand : ICommand
    {
        Reciever iRecoever;
        Message iMessage;
        Action iAction;
        public ConcreateCommand(Action aAction, Message aMesage)
        {
            iRecoever = new Reciever();
            iAction = aAction;
            iMessage = aMesage;
        }

        public void Excute()
        {
            iRecoever.Operation(iAction, iMessage);
        }

        public void UnExcute()
        {
            iAction = GetUnDo(); //获取取消操作
            iRecoever.Operation(iAction, iMessage);
        }

        private Action GetUnDo()
        {
            switch(iAction)
            {
                case Action.Delete:
                    return Action.Insert;
                case Action.Insert:
                    return Action.Delete;
                default:
                    return 0;
            }
        }
    }
}
