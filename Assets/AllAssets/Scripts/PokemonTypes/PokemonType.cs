using System;
using System.Collections.Generic;
using UnityEngine;



public abstract class PokemonType : MonoBehaviour
{
	public abstract List<PokemonType> notVeryEffectiveTypes();
	public abstract List<PokemonType> superEffectiveTypes();
	public abstract List<PokemonType> immuneTypes();

		public double getEffectivnessMultiplier(PokemonType type) 
		{
			if (this.notVeryEffectiveTypes ().Contains (type)) {
				return 0.5;
			} else if (this.superEffectiveTypes ().Contains (type)) {
				return 2;
			} else if (this.immuneTypes ().Contains (type)) {
				return 0;
			} else {
				return 1;
			}
	
		}
}
	