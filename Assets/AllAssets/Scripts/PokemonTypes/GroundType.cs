using System;
using System.Collections.Generic;


public class GroundType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.GRASS, PokemonTypeEnum.BUG};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIRE, PokemonTypeEnum.ELECTRIC, PokemonTypeEnum.POISON, PokemonTypeEnum.ROCK, PokemonTypeEnum.STEEL};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FLYING};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.GROUND;
	}
}
