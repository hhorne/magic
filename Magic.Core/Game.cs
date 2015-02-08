using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic.Core
{
	public class Game
	{
		public readonly List<Player> Players = new List<Player>();
		private readonly Turn turn = new Turn();

		public Game()
		{
		}

		public void TakeTurn(Player player)
		{
			turn.GetPhases().ForEach(player.EnterPhase);
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
