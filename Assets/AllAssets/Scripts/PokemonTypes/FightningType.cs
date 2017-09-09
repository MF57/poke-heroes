using System;
using System.Collections.Generic;

public class FightningType : PokemonType {
	override public List<PokemonTypeEnum> notVeryEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.POISON, PokemonTypeEnum.FLYING, PokemonTypeEnum.PSYCHIC, PokemonTypeEnum.BUG, PokemonTypeEnum.FAIRY};
	}
	override public List<PokemonTypeEnum> superEffectiveTypes() {
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.NORMAL, PokemonTypeEnum.ICE, PokemonTypeEnum.ROCK, PokemonTypeEnum.STEEL, PokemonTypeEnum.DARK};
	}

	override public List<PokemonTypeEnum> immuneTypes(){
		return new List<PokemonTypeEnum> () {PokemonTypeEnum.GHOST};
	}

	public override PokemonTypeEnum typeEnum ()
	{
		return PokemonTypeEnum.FIGHTNING;
	}
}
