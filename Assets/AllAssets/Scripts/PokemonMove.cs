using System;
using UnityEngine;


public enum MoveKind { PSYCHICAL, SPECIAL }


public class PokemonMove : MonoBehaviour
{

	public MoveKind kind;
	public PokemonType Type;
	public int basePower;
	public String moveName;
	public double accuracy;

	public PokemonMove()
	{
		
	}
}


