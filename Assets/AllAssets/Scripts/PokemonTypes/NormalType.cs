﻿using System;
using System.Collections.Generic;


public class NormalType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new RockType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () { new GhostType()};
	}
}