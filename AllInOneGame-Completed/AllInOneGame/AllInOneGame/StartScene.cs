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
    public class StartScene : GameScene
    {
        public MenuComponent Menu;
        public Texture2D background;

        private SpriteBatch spriteBatch;
        List<string> menuItems = new List<string> {"Start Game",
                                "About",
                                "Help",
                                "High Score",
                                "Credit",
                                "Quit"};
        public StartScene(Game game): base(game)
        {
            GameWorld g = (GameWorld)game;

            this.spriteBatch = g.spriteBatch;
            SpriteFont regularFont = g.Content.Load<SpriteFont>("Fonts/regularFont");
            SpriteFont highlightFont = game.Content.Load<SpriteFont>("Fonts/hilightFont");
            background = game.Content.Load<Texture2D>("Images/background");

            Menu = new MenuComponent(game, spriteBatch,regularFont,highlightFont, menuItems);
            this.Components.Add(Menu);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
