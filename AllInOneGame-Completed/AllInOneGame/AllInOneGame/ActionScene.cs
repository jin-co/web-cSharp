using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace AllInOneGame
{
    public class ActionScene : GameScene
    {
        private SpriteBatch spriteBatch;
        public Vector2 ScreenDimention;

        private Ball ball;
        private Bat bat;
        private Explosion explosion;
        private CollisionDetection collisionDetection;

        public ActionScene (Game game): base(game)
        {
            GameWorld g = (GameWorld)game;
            this.spriteBatch = g.spriteBatch;
            ContentManager Content = g.Content;
            ScreenDimention = Shared.ScreenDimension;

            Vector2 screenDimension = new Vector2(ScreenDimention.X, ScreenDimention.Y);

            ball = new Ball();
            ball.ScreenDimension = screenDimension;
            ball.Load(Content);

            bat = new Bat();
            bat.Load(Content);
            bat.ScreenDimension = screenDimension;

            explosion = new Explosion(Content);
            SoundEffect dingSound = Content.Load<SoundEffect>("Music/ding");
            ball.explosion = explosion;

            collisionDetection = new CollisionDetection(ball, bat, dingSound, explosion);

            Song song = Content.Load<Song>("Music/chimes");

            MediaPlayer.IsRepeating = true;
            MediaPlayer.Play(song);

        }

        public override void Update(GameTime gameTime)
        {
            ball.Update(gameTime);
            bat.Update(gameTime);
            explosion.Update(gameTime);
            collisionDetection.Update(gameTime);
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            ball.Draw(gameTime, spriteBatch);
            bat.Draw(gameTime, spriteBatch);
            explosion.Draw(gameTime, spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
