using Hell.Source;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Hell.Source.Engine.Rendering;
using Hell.Source.Engine;
using Hell.Source.Engine.Components;
using System;
using Unity.Mathematics;



namespace Hell
{
    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            Debug.Logger.InitializeLogger();
            Graphics.InitializeGraphics();


            //manual stuff for testing
            gameObject game1 = new gameObject();
            gameObject game2 = new gameObject();

            Transform t1 = game1.transform;
            Transform t2 = game2.transform;

            t1.localPosition = new float3(1, 2, 3);
            t2.localPosition = new float3(5, 5, 3);

            t2.SetParent(t1);

            Debug.Logger.LogInfo(t1.localPosition.ToString());
            Debug.Logger.LogInfo(t2.localPosition.ToString());
           
            t1.ResolveTransform();
            t1.ResolveChildrenTransform();

            Debug.Logger.LogInfo(t1.position.ToString());
            Debug.Logger.LogInfo(t2.position.ToString());


            base.Initialize();
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

            // manual bs (remove)




            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend);

            


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}