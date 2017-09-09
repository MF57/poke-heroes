using System;
using System.Collections.Generic;

public class BugType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new BugType(), new FightningType(), new PoisonType(), new FlyingType(), new GhostType(), new SteelType(), new FairyType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new PsychicType(), new DarkType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}