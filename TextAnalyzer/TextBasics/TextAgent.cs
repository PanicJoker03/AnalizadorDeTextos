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
        private static TextAgent? instance;
        public static TextAgent Instance {
            get {
                if (instance == null)
                    instance = new TextAgent();
                return instance;
            }
        }
        private TextAgent() { }
        //From ... string... outs Text...
        public Text FromString(string txt) {
            Text.InitializeTextHandler initializer = (object sender, InitializeTextArgs args) => { 
                args.Text = txt;
            };
            var text = new Text(initializer);
            return text;
        }
    }
}
