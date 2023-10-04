using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzerBatoman.MyLib
{
    public interface ISingleton<T> where T : class
    {
        static ISingleton<T> Instance { get; }
    }
}
