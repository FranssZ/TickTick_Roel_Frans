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

        public void camerabeweegcheck(Vector2 position)
        {
            //check position en camerapositie meer dan iets
            if (position.X + camerapositie.X <= 400 && camerapositie.X < 0)   //linkerkant
            {
                camerapositie.X += 8;
                
            }
            if (position.X + camerapositie.X >= 1040) //rechterkant
            {
                camerapositie.X -= 8;
            }
        }
        

        //hier moet komen wat besluit wat we zien

    }
}
