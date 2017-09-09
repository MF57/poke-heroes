using System;
using System.Collections.Generic;


public class NormalType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.ROCK, PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () { PokemonTypeEnum.GHOST};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.NORMAL;
	}
}
