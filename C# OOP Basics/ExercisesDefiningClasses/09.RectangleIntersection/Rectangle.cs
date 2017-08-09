using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public string id;
    public double width;
    public double height;
    public double topLeftX;
    public double topLeftY;

    public bool Intersect(Rectangle second)
    {
        return (second.topLeftX + second.width >= this.topLeftX && second.topLeftX <= this.topLeftX + this.width)
               &&
               (second.topLeftY + second.height >= this.topLeftY && second.topLeftY <= this.topLeftY + this.height);
    }
}
