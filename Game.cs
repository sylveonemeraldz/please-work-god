// CHALLENGE: Toggle the square's color between two colors (eg. red and green)
//            when the player either hits spacebar or does a left mouse click.

using Microsoft.VisualBasic.FileIO;
using System;
using System.Numerics;

namespace Game10003
{
    public class Game
    {
        public void Setup()
        {
            Window.SetTitle("Toggle Color");
            Window.SetSize(400, 400);
            
        }

        public void Update()
        {
            
            Window.ClearBackground(Color.OffWhite);
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.FillColor = Color.Yellow;
                Draw.Square(100, 100, 200);
            }
            else
            {


               
                Draw.FillColor = Color.Blue;

               
                Draw.Square(100, 100, 200);
            }
            
            }
        }
    }

