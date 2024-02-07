using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVisitor
{
    internal class HtmlVisitor : IVisitor
    {
        public string Output { get; private set; }
        public void Visit(Hyperlink docPart)
        {
            this.Output += docPart + Environment.NewLine;
        
        }

        public void Visit(BoldText docPart)
        {
            this.Output += "<b>" + docPart + "</b>" + Environment.NewLine;
        }

        public void Visit(PlainText docPart)
        {
            this.Output += "<a href=\"" + docPart + "\">" + Environment.NewLine;
        }
    }
}
