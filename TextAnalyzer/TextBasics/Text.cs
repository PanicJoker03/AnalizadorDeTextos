using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzerBatoman.TextBasics
{
    //this class could use TextAnalyzer... is a facade...
    //use this to set the text on text instance.
    public class InitializeTextArgs { 
        public InitializeTextArgs() { }
        public string Text { get; set; } // set some value to work with the text instance
    }
    //initialization is complex to keep separation of concerns. TextAgent is responsible
    //to build Text instances.
    public class Text
    {
        private string text;
        //only methods ... text is facade if methods get numerous or massive
        public delegate void InitializeTextHandler(object sender, InitializeTextArgs e);
        public event InitializeTextHandler InitializeText;
        //akward initialization process to keep encapsulation on Text class.
        public Text(InitializeTextHandler initializer) {
            InitializeTextArgs initArgs = new InitializeTextArgs();
            InitializeText = initializer;
            InitializeText?.Invoke(this, initArgs);
            text = initArgs.Text;
        }
        //this could be optimized
        public uint CharactersCount {
            get {
                var analizer = new TextAnalysis.BasicAnalyzer();
                TextAnalysis.BasicAnalysisData data = analizer.Analyze(text);
                return data.characterCount;
            }
        }
        public string String => text;
    }
}
