using System;
using System.Collections.Generic;

public class ElectricType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new ElectricType(), new GrassType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FlyingType(), new WaterType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new GroundType()};
	}
}

