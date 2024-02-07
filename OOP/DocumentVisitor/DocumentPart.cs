using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVisitor
{
    internal abstract class DocumentPart
    {
        public string Text { get; private set; }
        public DocumentPart(string text) { this.Text = text; }
        public abstract void Accept(IVisitor visitor);
    }
}
