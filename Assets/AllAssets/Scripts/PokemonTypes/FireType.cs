using System;
using System.Collections.Generic;


public class FireType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIRE, PokemonTypeEnum.WATER, PokemonTypeEnum.ROCK, PokemonTypeEnum.DRAGON};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GRASS, PokemonTypeEnum.BUG, PokemonTypeEnum.ICE, PokemonTypeEnum.STEEL};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.FIRE;
	}
}