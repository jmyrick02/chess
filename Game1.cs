using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Chess
{
    public class Game1 : Game
    {
        public static List<GameObject> GameObjects { get; private set; }
        
        public static GraphicsDevice GDevice { get; private set; }
        public static ContentManager ContentManager { get; private set; }
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            GameObjects = new List<GameObject>();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
            GDevice = GraphicsDevice;
            ContentManager = Content;

            new Board(new Vector2(_graphics.PreferredBackBufferWidth * 0.1f, _graphics.PreferredBackBufferHeight * 0.1f), Vector2.One * 50, new Tuple<Color, Color>(Color.Beige, Color.BurlyWood));
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            foreach (GameObject gameObject in GameObjects)
            {
                if (gameObject.IsActive) {
                    _spriteBatch.Draw(gameObject.Texture, gameObject.Position, null, Color.White, 0, new Vector2(gameObject.Texture.Width / 2f, gameObject.Texture.Height / 2f), new Vector2(gameObject.Scale.X / gameObject.Texture.Width, gameObject.Scale.Y / gameObject.Texture.Height), SpriteEffects.None, 0);
                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
