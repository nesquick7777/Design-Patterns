using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVisitor
{
    internal class PlainText : DocumentPart
    {

        public PlainText(string text) : base(text){ }
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
