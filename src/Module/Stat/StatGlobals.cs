namespace K4System
{
	using CounterStrikeSharp.API.Core;
	using CounterStrikeSharp.API.Core.Plugin;

	using Microsoft.Extensions.Logging;

	public partial class ModuleStat : IModuleStat
	{
		public class StatData
		{
			public Dictionary<string, int> StatFields { get; set; } = new Dictionary<string, int>();
		}

		public readonly PluginContext PluginContext;
		public readonly ILogger<ModuleStat> Logger;

		public required PluginConfig Config { get; set; }

		public CCSGameRules? globalGameRules = null;
		internal static PlayerCache<StatData> statCache = new PlayerCache<StatData>();
		public bool FirstBlood = false;
	}
}