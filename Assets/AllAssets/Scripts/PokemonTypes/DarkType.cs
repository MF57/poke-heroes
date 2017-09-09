using System;
using System.Collections.Generic;

public class DarkType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new DarkType(), new FairyType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new PsychicType(), new GhostType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

