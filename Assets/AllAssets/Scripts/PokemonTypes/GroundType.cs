using System;
using System.Collections.Generic;


public class GroundType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new GrassType(), new BugType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new ElectricType(), new PoisonType(), new RockType(), new SteelType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new FlyingType()};
	}
}
