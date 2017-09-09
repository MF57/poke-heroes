using System;
using System.Collections.Generic;

public class PoisonType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new PoisonType(), new GroundType(), new RockType(), new GhostType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new FairyType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new SteelType()};
	}
}

