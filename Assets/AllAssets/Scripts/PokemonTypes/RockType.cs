using System;
using System.Collections.Generic;

public class RockType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIGHTNING, PokemonTypeEnum.GROUND, PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIRE, PokemonTypeEnum.FLYING, PokemonTypeEnum.ICE, PokemonTypeEnum.BUG};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.ROCK;
	}
}

