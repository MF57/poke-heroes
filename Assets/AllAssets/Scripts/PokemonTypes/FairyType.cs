using System;
using System.Collections.Generic;

public class FairyType : PokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new PoisonType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new DragonType(), new GhostType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}
