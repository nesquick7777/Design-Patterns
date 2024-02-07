﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentVisitor
{
    internal class Document
    {
        private List<DocumentPart> parts = new List<DocumentPart>();

        public void Accept(IVisitor visitor)
        {
            foreach(DocumentPart part in parts)
            {
                part.Accept(visitor);
            }
        }

        public void Add(DocumentPart part)
        {
            parts.Add(part);
        }
    }
}
