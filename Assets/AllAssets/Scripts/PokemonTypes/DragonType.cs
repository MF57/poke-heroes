using System;
using System.Collections.Generic;

public class DragonType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.DRAGON};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FAIRY};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.DRAGON;
	}
}

