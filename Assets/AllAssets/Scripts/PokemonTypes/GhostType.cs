using System;
using System.Collections.Generic;

public class GhostType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new DarkType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GhostType(), new PsychicType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {/*new NormalType()*/};
	}
}

