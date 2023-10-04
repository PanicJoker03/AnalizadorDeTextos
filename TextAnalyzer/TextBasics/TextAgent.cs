using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzerBatoman.MyLib;

namespace TextAnalyzerBatoman.TextBasics
{
    //builds a text from string, file?, stream?
    public class TextAgent : ISingleton<TextAgent>
    {
        public static ISingleton<TextAgent> Instance => throw new NotImplementedException();
        private TextAgent() { }
        //From ... string... outs Text...
    }
}
