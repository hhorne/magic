﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Core.SpellTypes;

namespace Magic.Core
{
	public class Game
	{
		public int TurnNumber { get; private set; }
		public readonly List<Player> Players = new List<Player>();

		public Game()
		{
			TurnNumber = 1;
		}

		public void TakeTurn(Player player)
		{
			// so the game can know about the various effects of other's ICards and apply them appropriately
			TurnNumber++;
		}

		public IEnumerable<GameState> Play()
		{
			var game = from player in Players.CycleForever()
						select new GameState
						{
							Game = this,
							ActivePlayer = player,
							OtherPlayers = Players.Where(p => p != player).ToList()
						};
			var gamePlay = from state in game
							where state.ActivePlayer.Lost == false
							&& state.OtherPlayers.All(p => p.Lost == false)
							select state;
			return game;
		}
	}

	public class GameState
	{
		public Game Game { get; set; }
		public Player ActivePlayer { get; set; }
		public List<Player> OtherPlayers { get; set; }
	}
}
