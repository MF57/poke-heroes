using System;
using System.Collections.Generic;

public class SteelType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIRE, PokemonTypeEnum.ELECTRIC, PokemonTypeEnum.STEEL, PokemonTypeEnum.WATER};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.ICE, PokemonTypeEnum.ROCK, PokemonTypeEnum.FAIRY};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.STEEL;
	}
}
