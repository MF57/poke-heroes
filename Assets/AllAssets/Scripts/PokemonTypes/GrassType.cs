using System;
using System.Collections.Generic;

public class GrassType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.FIRE, PokemonTypeEnum.GRASS, PokemonTypeEnum.POISON, PokemonTypeEnum.FLYING, PokemonTypeEnum.BUG, PokemonTypeEnum.DRAGON};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.WATER, PokemonTypeEnum.GROUND, PokemonTypeEnum.ROCK};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.GRASS;
	}
}

