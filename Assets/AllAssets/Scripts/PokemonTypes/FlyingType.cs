using System;
using System.Collections.Generic;

public class FlyingType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.ELECTRIC, PokemonTypeEnum.ROCK, PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GRASS, PokemonTypeEnum.FIGHTNING, PokemonTypeEnum.BUG};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.FLYING;
	}
}

