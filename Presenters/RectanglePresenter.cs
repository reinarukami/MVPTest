using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVPTest.Models;
using MVPTest.Views;

namespace MVPTest.Presenters
{
    public class RectanglePresenter
    {
        IRectangle rectangleview;

        public RectanglePresenter(IRectangle view)
        {
            rectangleview = view;
        }

        public void CalculateArea()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.width = Int32.Parse(rectangleview.widthText);
            rectangle.height = Int32.Parse(rectangleview.heightText);
            rectangleview.areaText = rectangle.Calculatearea().ToString();
        }

    }


}
