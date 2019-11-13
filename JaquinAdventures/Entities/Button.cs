﻿using System;
using JaquinAdventures.Interfaces;
using Otter;

namespace JaquinAdventures.Entities
{
    public class Button : ButtonBase 
    {
        private Player _player;
        
        public Button(Game game, Input input, Player player) : base(game, input)
        {
            _player = player;
            Sprite = Image.CreateRectangle(300,200);
            Sprite.CenterOrigin();
            X = 400;
            Y = 200;
            
        }

        protected override void OnCLick()
        {
            _player.Sprite.Color = Color.Random;
        }

    }
}