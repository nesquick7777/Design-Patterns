﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDecorater
{
    internal class EntitledConsoleMessage : ConsoleMessagerDecorater
    {
        String title;
        public EntitledConsoleMessage(String title, IMessage message) : base(message) { this.title = title; }

        public override void Print()
        {
            Console.WriteLine(title);
            base.Print();
        }
    }
}
