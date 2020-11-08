using System;
using System.Collections.Generic;

// Interface Class Graphic
interface Graphic
{
    void move(int x,int y);
    void draw();
}

// Class Circle Extends Dot
class Circle : Dot
{
    int radius;
    
    public Circle(int x, int y, int radius) : base(x, y)
    {
        this.radius = radius;
    }
    
    public override void draw()
    {
        Console.WriteLine("Circle: X=" + getX() + " Y=" + getY() + " Radius=" + radius);
    }
}

// Class Dot Implements Graphic
class Dot : Graphic
{
    int x, y;
    
    public Dot(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    
    public int getX()
    {
        return x;
    }
    
    public int getY()
    {
        return y;
    }
    
    public void move(int x, int y)
    {
        this.x += x;
        this.y += y;
    }

    public virtual void draw()
    {
        Console.WriteLine("Dot: X=" + x + " Y=" + y);
    }
}

// CompoundGraphic Implements Graphic
class CompoundGraphic : Graphic
{
    private List<Graphic> children = new List<Graphic>();
    
    public List<Graphic> getShapes()
    {
        return children;
    }

    public void add(Graphic children)
    {
        this.children.Add(children);
    }

    public void remove(Graphic children)
    {
        this.children.Remove(children);
    }

    public void move(int x, int y)
    {
        foreach (Graphic child in children)
        {
            child.move(x, y);
        }
    }

    public void draw()
    {
        foreach (Graphic shape in children)
        {
            shape.draw();
        }
    }
}

// Class ImageEditor
class ImageEditor
{
    CompoundGraphic all;
    public void load()
    {
        all = new CompoundGraphic();
        all.add(new Dot(1, 2));
        all.add(new Circle(5, 3, 10));
        groupSelected(all.getShapes().ToArray());
    }

    public void groupSelected(Graphic[] components)
    {
        CompoundGraphic group = new CompoundGraphic();
        foreach (Graphic component in components)
        {
            group.add(component);
            all.remove(component);
        }
        all.add(group);
        all.draw();  
    }
}

// Class Program (Main)
class Program
{
    static void Main(string[] args)
    {
        ImageEditor imgE = new ImageEditor();
        imgE.load();
    }
}
