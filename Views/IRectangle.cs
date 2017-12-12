 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Views
{
    public interface IRectangle
    {
        string heightText { get; set; }
        string widthText { get; set; }
        string areaText { get; set; }
    }
}
