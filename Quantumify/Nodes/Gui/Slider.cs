using System.Numerics;
using Raylib_cs;

namespace Quantumify.Gui;

public class Slider : GuiElement
{
    private float pos;
    bool moved = false;
    
    public int Value;
    public int MaxValue;
    public int MinValue;

    public Slider() : base()
    {
        MinValue = 50;
        MaxValue = 100;
        Size = new Vector2(100, 0);
    }
    
    public override void Overlay()
    {
        base.Overlay();
        
        
        float size = GetRectangle().Width;
        
        //Raylib.DrawLineEx(Position,Position+new Vector2(size,0),15,Color.Black);
        Raylib.DrawRectangleRounded(new Rectangle(Position.X,Position.Y-7,size,15),2,1,Color.Black);

        
        
        if (Raylib.CheckCollisionPointLine(Raylib.GetMousePosition(), Position, Position + new Vector2(size, 0), 5)&&Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            moved = true;
        }

        if (Raylib.IsMouseButtonReleased(MouseButton.Left))
        {
            moved = false;
        }

        if (Raylib.IsMouseButtonDown(MouseButton.Left)&&moved)
        {
            pos = Raylib.GetMousePosition().X - Position.X;
            if (pos < 0)
            {
                pos = 0;
            }
            
            if (pos > size)
            {
                pos = size;
            }
        }
        
        Value = (int)((pos/size)*(MaxValue-MinValue))+MinValue;

        //Logger.Warn($"Value: {Value}");
        
        Raylib.DrawCircle((int)(pos + Position.X),(int)(Position.Y),10,Color.Red);
    }
}