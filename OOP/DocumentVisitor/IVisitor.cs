namespace DocumentVisitor
{
    internal interface IVisitor
    {
        void Visit(Hyperlink docPart);
        void Visit(BoldText docPart);
        void Visit(PlainText docPart);
    }
}