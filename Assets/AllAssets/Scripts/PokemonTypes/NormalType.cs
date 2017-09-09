using System;
using UnityEngine;
using System.Collections.Generic;


public class NormalType : PokemonTypes {
	override public List<PokemonTypes> notVeryEffectiveTypes() {
		return new List<PokemonTypes> () { };
	}
	override public List<PokemonTypes> superEffectiveTypes() {
		return new List<PokemonTypes> () {};
	}

	override public List<PokemonTypes> immuneTypes(){
		return new List<PokemonTypes> () { };
	}
}

