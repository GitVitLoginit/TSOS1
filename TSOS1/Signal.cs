using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSOS1
{
    public enum Signal
    {
        
        syn,
        rectangle,
        triangle,
        saw,
        SinSaw,
        SinRect,
        SinTriangle,
        SawRect,
        SinRectSaw,
        RectTriangleSaw
    }

    public enum parameter
    {

        amp,
        fre,
        phase
    }
}
