using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzerBatoman.TextBasics;

namespace TextAnalyzerBatoman.TextAnalysis
{
    internal abstract class BasicAnalyzer
    {
        abstract protected void Analyze(string text);
    }
}
