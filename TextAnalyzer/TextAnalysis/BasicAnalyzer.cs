using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAnalyzerBatoman.TextBasics;

namespace TextAnalyzerBatoman.TextAnalysis
{
    //in these analyzer classes is where the concrete logic of text analysis happens
    internal class BasicAnalyzer
    {
        virtual public BasicAnalysisData Analyze(string text) { 
            var data = new BasicAnalysisData();
            data.characterCount = CountCharacters(text);
            return data;
        }

        //count if character is not empty space
        uint CountCharacters(string txt) => 
            (uint)txt.Count(
                ch => 
                    ch != ' ' && 
                    ch != '\t' && 
                    ch != '\n' && 
                    ch != '\f' &&
                    ch != '\x85' &&
                    ch != '\r' &&
                    ch != '\v'
            );
    }
}
