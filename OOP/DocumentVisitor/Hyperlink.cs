using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVisitor
{
    internal class Hyperlink : DocumentPart
    {

        public Hyperlink(string text) : base(text){ }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
