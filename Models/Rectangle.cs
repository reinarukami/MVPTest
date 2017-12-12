using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }

        public double Calculatearea()
        {
            return width * height;
        }
    }
}
