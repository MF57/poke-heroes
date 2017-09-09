using System;
using System.Collections.Generic;
using UnityEngine;



public abstract class PokemonTypes : MonoBehaviour
{
	public abstract List<PokemonTypes> notVeryEffectiveTypes();
	public abstract List<PokemonTypes> superEffectiveTypes();
	public abstract List<PokemonTypes> immuneTypes();
}

public interface PokemonType
{
	List<PokemonType> notVeryEffectiveTypes();
	List<PokemonType> superEffectiveTypes();
	List<PokemonType> immuneTypes();
}


public abstract class AbstractPokemonType : PokemonType
{
//	public double getEffectivnessMultiplier(PokemonType type) 
//	{
//		if (((PokemonType)this).notVeryEffectiveTypes ().Contains (type)) {
//			return 0.5;
//		} else if (((PokemonType)this).superEffectiveTypes ().Contains (type)) {
//			return 2;
//		} else if (((PokemonType)this).immuneTypes ().Contains (type)) {
//			return 0;
//		} else {
//			return 1;
//		}
//
//	}

	public abstract List<PokemonType> notVeryEffectiveTypes ();
	public abstract List<PokemonType> superEffectiveTypes ();
	public abstract List<PokemonType> immuneTypes ();
}
	

public class WaterType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new WaterType(), new GrassType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () { new FireType(), new GroundType(), new RockType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class GrassType : AbstractPokemonType {
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

public class FireType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new WaterType(), new RockType(), new DragonType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class ElectricType : AbstractPokemonType {
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

public class GroundType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () { new GrassType(), new BugType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new ElectricType(), new PoisonType(), new RockType(), new SteelType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new FlyingType()};
	}
}

public class RockType : AbstractPokemonType {
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

public class PoisonType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new PoisonType(), new GroundType(), new RockType(), new GhostType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new FairyType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new SteelType()};
	}
}

public class BugType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new BugType(), new FightningType(), new PoisonType(), new FlyingType(), new GhostType(), new SteelType(), new FairyType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new PsychicType(), new DarkType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class FlyingType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new ElectricType(), new RockType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new FightningType(), new BugType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class SteelType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new ElectricType(), new SteelType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new IceType(), new RockType(), new FairyType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class FightningType : AbstractPokemonType {
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

public class IceType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FireType(), new WaterType(), new IceType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new GrassType(), new GrassType(), new GroundType(), new DragonType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class PsychicType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new PsychicType(), new SteelType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new PoisonType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {new DarkType()};
	}
}

public class GhostType : AbstractPokemonType {
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

public class DarkType : AbstractPokemonType {
	override public List<PokemonType> notVeryEffectiveTypes() {
		return new List<PokemonType> () {new FightningType(), new DarkType(), new FairyType()};
	}
	override public List<PokemonType> superEffectiveTypes() {
		return new List<PokemonType> () {new PsychicType(), new GhostType()};
	}

	override public List<PokemonType> immuneTypes(){
		return new List<PokemonType> () {};
	}
}

public class DragonType : AbstractPokemonType {
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

public class FairyType : AbstractPokemonType {
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