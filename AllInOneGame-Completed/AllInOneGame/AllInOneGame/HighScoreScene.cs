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
    public class HighScoreScene : GameScene
    {
        private SpriteBatch spriteBatch;
        private Texture2D highScoreSprite;
        public HighScoreScene(Game game): base(game)
        {
            GameWorld g = (GameWorld)game;
            this.spriteBatch = g.spriteBatch;
            highScoreSprite = g.Content.Load<Texture2D>("Images/highScoreImage");
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(highScoreSprite, Vector2.Zero, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
