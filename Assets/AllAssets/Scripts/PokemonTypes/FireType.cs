using System;
using System.Collections.Generic;


public class FireType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new WaterType(), new RockType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}