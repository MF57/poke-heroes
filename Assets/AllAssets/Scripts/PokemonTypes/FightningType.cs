using System;
using System.Collections.Generic;

public class FightningType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new PoisonType(), new FlyingType(), new PsychicType(), new BugType(), new FairyType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {/*new NormalType(),*/ new IceType(), new RockType(), new SteelType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new GhostType()};
	}
}
