using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GameManagement
{
    public class Camera
    {

        public Vector2 camerapositie = new Vector2(0,0);

        public void camerabeweegcheck(Vector2 position,Vector2 velocity)
        {
            //check position en camerapositie meer dan iets
            if (position.X - camerapositie.X <= 200)   //linkerkant
            {
                camerapositie.X += 10;
                //Console.WriteLine("iets");
            }
            if (position.X - camerapositie.X >= 600) //rechterkant
            {
                camerapositie.X += 10;
            }


        }


        //hier moet komen wat besluit wat we zien

    }
}
