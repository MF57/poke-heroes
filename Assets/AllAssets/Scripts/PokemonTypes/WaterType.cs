using System;
using System.Collections.Generic;

public class WaterType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new WaterType(), new GrassType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () { new FireType(), new GroundType(), new RockType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

