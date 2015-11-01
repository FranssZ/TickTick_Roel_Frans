using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

partial class Bullet : AnimatedGameObject
    {
        
        protected Vector2 startPosition;
        double can_shoot = 0;
        

        public void bullet(bool moveToLeft, Vector2 startPosition)
        {
            this.LoadAnimation("Sprites/Rocket/spr_rocket@3", "default", true, 0.2f);
            this.PlayAnimation("default");
            this.Mirror = moveToLeft;
        }

        public override void Reset()
        {
            this.visible = false;
            this.position = startPosition;
            this.velocity = Vector2.Zero;
    }

    public override void HandleInput(InputHelper inputHelper)
        {
        if (inputHelper.KeyPressed(Keys.Space))
            if (can_shoot == 0)
            {
                this.visible = true;
                Mirror = true;
            }
        }

public override void Update(GameTime gameTime)
         {
            
            this.velocity.X = 600;
            Rocket rocket = GameWorld.Find("rocket") as Rocket;
            
            if (this.CollidesWith(rocket) && this.Visible)
                rocket.Reset();
            Rectangle screenBox = new Rectangle(0, 0, GameEnvironment.Screen.X, GameEnvironment.Screen.Y);
            if (!screenBox.Intersects(this.BoundingBox))
            this.Reset();
            if (can_shoot > 0)
            {
                can_shoot -= gameTime.ElapsedGameTime.TotalSeconds;
                return;
            }
    }

    }

