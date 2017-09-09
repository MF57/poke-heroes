using System;
using System.Collections.Generic;

public class PsychicType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new PsychicType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new PoisonType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new DarkType()};
	}
}

