using System;
using System.Collections.Generic;

public class DragonType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new DragonType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new FairyType()};
	}
}

