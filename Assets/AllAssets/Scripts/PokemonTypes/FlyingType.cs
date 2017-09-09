using System;
using System.Collections.Generic;

public class FlyingType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new ElectricType(), new RockType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new FightningType(), new BugType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

