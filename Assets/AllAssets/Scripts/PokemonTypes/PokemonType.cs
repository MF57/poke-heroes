using System;
using System.Collections.Generic;
using UnityEngine;



public abstract class PokemonType : MonoBehaviour
{
	public abstract List<PokemonTypeEnum> notVeryEffectiveTypes();
	public abstract List<PokemonTypeEnum> superEffectiveTypes();
	public abstract List<PokemonTypeEnum> immuneTypes();
	public abstract PokemonTypeEnum typeEnum ();

		public double getEffectivnessMultiplier(PokemonType type) 
		{
			if (this.notVeryEffectiveTypes ().Contains (type.typeEnum())) {
				return 0.5;
			} else if (this.superEffectiveTypes ().Contains (type.typeEnum())) {
				return 2;
			} else if (this.immuneTypes ().Contains (type.typeEnum())) {
				return 0;
			} else {
				return 1;
			}
	
		}
}

public enum PokemonTypeEnum { NORMAL, WATER, GRASS, FIRE, ELECTRIC, GROUND, ROCK, STEEL, FLYING, ICE, BUG, POISON, FIGHTNING, PSYCHIC, GHOST, DARK, FAIRY, DRAGON}
	