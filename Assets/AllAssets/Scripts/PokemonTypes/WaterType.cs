using System;
using System.Collections.Generic;

public class WaterType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.WATER, PokemonTypeEnum.GRASS, PokemonTypeEnum.DRAGON};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.FIRE, PokemonTypeEnum.GROUND, PokemonTypeEnum.ROCK};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.WATER;
	}
}

