﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
	public class Player
	{

		//player animation
		public Texture2D  PlayerTexture;
		public Vector2 Position;
		public bool Active;
		public int Health;
		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture;
			Position = position;
			Active = true;
			Health = 100;
		}

		public void Update()
		{
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (PlayerTexture, Position, 
				null, Color.White, 0f, Vector2.Zero, 1f,
				SpriteEffects.None, 0f);
		}

		public int Width
		{
			get {return PlayerTexture.Width;}
		}

		public int Height 
		{
			get{ return PlayerTexture.Height; }
		}

	}
}

