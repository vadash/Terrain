﻿using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace Terrain
{
	class TerrainSettings : ISettings
	{
		public ColorNode TerrainColor { get; set; } = new ColorNode(0x9F9F9F4D);
		public ToggleNode Enable { get; set; } = new ToggleNode(false);
	}
}