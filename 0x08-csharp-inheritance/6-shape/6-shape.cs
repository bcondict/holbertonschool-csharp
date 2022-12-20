﻿using System;

///
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException ("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get { return width; }
        // set { width = value > 0 ? value : throw new ArgumentException ("Width must be greater than or equal to 0"); }
        set {
            if (value < 0)
                throw new ArgumentException ("Width must be greater than or equal to 0");
            width = value;
        }
    }

    public int Height
    {
        get { return height; }
        // set { height = value > 0 ? value : throw new ArgumentException ("Heigth must be greater than or equal to 0"); }
        set {
            if (value < 0)
                throw new ArgumentException ("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
