﻿using System;
using System.Collections.Generic;


public class IceType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIRE, PokemonTypeEnum.WATER, PokemonTypeEnum.ICE, PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GRASS, PokemonTypeEnum.ICE, PokemonTypeEnum.GROUND, PokemonTypeEnum.DRAGON};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}
	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.ICE;
	}
}

