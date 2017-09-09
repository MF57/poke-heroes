using System;
using System.Collections.Generic;

public class PoisonType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.POISON, PokemonTypeEnum.GROUND, PokemonTypeEnum.ROCK, PokemonTypeEnum.GHOST};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GRASS, PokemonTypeEnum.FAIRY};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.STEEL};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.POISON;
	}
}

