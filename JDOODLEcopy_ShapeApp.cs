using System;
using System.Collections.Generic;

// Abstract Class Shape
abstract class Shape
{
    private int x, y;
    private string color;

    public void setX(int x)
    {
        this.x = x;
    }
    public void setY(int y)
    {
        this.y = y;
    }
    public void setColor(string color)
    {
        this.color = color;
    }
    
    public Shape()
    {

    }

    public Shape(Shape source)
    {
        
    }

    public abstract Shape clone();

    public virtual Boolean shapeMatch(object object2)
    {
        if (!(object2 is Shape)) { return false; }
        else
        {
            Shape shape2 = (Shape) object2;
            return shape2.x == x
                && shape2.y == y
                && shape2.color == color;
        }
    }
}

// Class Circle Extends Shape
class Circle : Shape
{
    private int radius;

    public void setRadius(int r)
    {
        this.radius = r;
    }

    public Circle()
    {

    }

    public Circle(Circle source)
    {
        
    }

    public override Shape clone()
    {
        return this.MemberwiseClone() as Circle;
    }

    public override Boolean shapeMatch(object object2)
    {
        if (!(object2 is Shape) || !base.shapeMatch(object2)) { return false; }
        else
        {
            Circle shape2 = (Circle) object2;
            return shape2.radius == radius;
        }
    }
}

// Class Rectangle Extends Shape
class Rectangle : Shape
{
    private int width,height;

    public void setWidth(int w)
    {
        this.width = w;
    }
    public void setHeight(int h)
    {
        this.height = h;
    }

    public Rectangle()
    {

    }

    public Rectangle(Rectangle source)
    {
        
    }

    public override Shape clone()
    {
        return this.MemberwiseClone() as Shape;
    }

    public override Boolean shapeMatch(object object2)
    {
        if (!(object2 is Shape) || !base.shapeMatch(object2)) { return false; }
        else
        {
            Rectangle shape2 = (Rectangle) object2;
            return shape2.width == width
                && shape2.height == height;
        }
    }
}

// Class Application (Main)
class Application
{
    static void Main(string[] args)
    {
        Application app = new Application();
        app.runApplication();
        Console.ReadKey();
    }

    public void runApplication()
    {
        List<Shape> shapes = new List<Shape>();
        List<Shape> copyShapes = new List<Shape>();

        Circle circle = new Circle();
        circle.setX(10);
        circle.setY(30);
        circle.setRadius(20);
        circle.setColor("Black");
        shapes.Add(circle);

        Circle anotherCircle = (Circle) circle.clone();
        shapes.Add(anotherCircle);

        Rectangle rectangle = new Rectangle();
        rectangle.setWidth(40);
        rectangle.setHeight(20);
        rectangle.setColor("White");
        shapes.Add(rectangle);

        shapeScan(shapes, copyShapes);
    }
    private void shapeScan(List<Shape> shapeList, List<Shape> copyshapeList)
    {
        foreach (Shape shape in shapeList)
        {
            copyshapeList.Add(shape.clone());
        }

        for (int i = 0; i < shapeList.ToArray().Length; i++)
        {
            Boolean sameObject = shapeList[i] == copyshapeList[i];
            Boolean objectIdentical = shapeList[i].shapeMatch(copyshapeList[i]);
            Console.WriteLine("Is Pair " + i + " the same? " + sameObject);
            Console.WriteLine("Is Pair " + i + " identical? " + objectIdentical);
            Console.WriteLine("");
        }
    }
}
