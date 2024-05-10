using Antlr4.Runtime;
using System.IO;

namespace WindowsFormsApp1.Core.Parser
{
    internal class ErrorListener : BaseErrorListener
    {
        public override void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            throw new RequireAnotherTokenException(charPositionInLine);
        }
    }
}
