using System;
using System.Collections.Generic;

public class GhostType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.DARK};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GHOST, PokemonTypeEnum.PSYCHIC};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.NORMAL};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.GHOST;
	}
}

