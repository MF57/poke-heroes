using System;
using System.Collections.Generic;


public class IceType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new WaterType(), new IceType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new GrassType(), new GroundType(), new DragonType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

