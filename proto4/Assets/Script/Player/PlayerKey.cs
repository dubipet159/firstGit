using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKey
{
	public static KeySet Set;

	public static Key left;
	public static Key right;
	public static Key down;
	public static Key up;
	public static Key jump;
	public static Key attack;
	public static Key skill;
	public static Key dash;
	public static Key weaponSwap;
	public static Key weaponSkill_1;
	public static Key weaponSkill_2;


	public static void Init () {
		Set = new KeySet ();
		Set.AddKey (left = new Key ("left", KeyCode.LeftArrow));
		Set.AddKey (right = new Key ("right", KeyCode.RightArrow));
		Set.AddKey (down = new Key ("down", KeyCode.DownArrow));
		Set.AddKey (up = new Key ("up", KeyCode.UpArrow));
		Set.AddKey (jump = new Key ("jump", KeyCode.Space));
		Set.AddKey (attack = new Key ("attack", KeyCode.A));
		Set.AddKey (skill = new Key ("skill", KeyCode.S));
		Set.AddKey (dash = new Key ("dash", KeyCode.D));
		Set.AddKey (weaponSwap = new Key ("weaponSwap", KeyCode.Q));
		Set.AddKey (weaponSkill_1 = new Key ("weaponSkill_1", KeyCode.W));
		Set.AddKey (weaponSkill_2 = new Key ("weaponSkill_2", KeyCode.E));
	}
}
