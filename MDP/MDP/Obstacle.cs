using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MDP
{
    public class Obstacle : DrawableGameComponent
    {
        private Texture2D solidTexture;
        private Rectangle bBox;
        private Color color;
        private SpriteBatch sb;

        public Obstacle(Game game, SpriteBatch sb, int x, int y, int xv, int yv) : base(game)
        {

            this.sb = sb;
            solidTexture = new Texture2D(GraphicsDevice, 1, 1);
            solidTexture.SetData(new Color[] { Color.White });
            bBox = new Rectangle(x, y, 50, 50);
            color = Color.Red;

        }

        public override void Draw(GameTime gameTime)
        {
            sb.Draw(solidTexture, bBox, color);
            base.Draw(gameTime);
        }
    }
}
