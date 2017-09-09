using System;
using System.Collections.Generic;

public class ElectricType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.ELECTRIC, PokemonTypeEnum.GRASS, PokemonTypeEnum.DRAGON};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FLYING, PokemonTypeEnum.WATER};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GROUND};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.ELECTRIC;
	}
}

