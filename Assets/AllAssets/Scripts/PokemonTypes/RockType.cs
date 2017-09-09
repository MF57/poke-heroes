using System;
using System.Collections.Generic;

public class RockType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new GroundType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new FlyingType(), new IceType(), new BugType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

