using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Core.Parser
{
    internal class LexerErrorListener : IAntlrErrorListener<int>
    {
        public void SyntaxError(
                TextWriter output,
                IRecognizer recognizer,
                int offendingSymbol,
                int line,
                int charPositionInLine,
                string msg, 
                RecognitionException e
            ) {
            throw new RequireAnotherTokenException(charPositionInLine);
        }
    }
}
