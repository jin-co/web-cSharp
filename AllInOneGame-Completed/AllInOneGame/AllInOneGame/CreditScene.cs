using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AllInOneGame
{
    public class CreditScene : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D creditSprite;
        public CreditScene(Game game): base(game)
        {
            GameWorld g = (GameWorld)game;
            this.spriteBatch = g.spriteBatch;
            creditSprite = g.Content.Load<Texture2D>("Images/creditImage");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(creditSprite, Vector2.Zero, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
