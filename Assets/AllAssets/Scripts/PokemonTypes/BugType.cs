using System;
using System.Collections.Generic;

public class BugType : PokemonType {

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.BUG;
	}
		

	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.BUG, PokemonTypeEnum.FIGHTNING, PokemonTypeEnum.POISON, 
			PokemonTypeEnum.FLYING, PokemonTypeEnum.GHOST, PokemonTypeEnum.STEEL, PokemonTypeEnum.FAIRY};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GRASS, PokemonTypeEnum.PSYCHIC, PokemonTypeEnum.DARK};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {};
	}
}