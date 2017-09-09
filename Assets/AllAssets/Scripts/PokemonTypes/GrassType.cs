using System;
using System.Collections.Generic;

public class GrassType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new FireType(), new GrassType(), new PoisonType(), new FlyingType(), new BugType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () { new WaterType(), new GroundType(), new RockType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

