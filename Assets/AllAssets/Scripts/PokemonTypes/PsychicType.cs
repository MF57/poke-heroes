using System;
using System.Collections.Generic;

public class PsychicType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.PSYCHIC, PokemonTypeEnum.STEEL};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.FIGHTNING, PokemonTypeEnum.POISON};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.DARK};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.PSYCHIC;
	}
}

