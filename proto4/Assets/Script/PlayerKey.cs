using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKey
{
	public string ShowDebug () {
		string s= "";
		if (Key.is_Active (left)) s += System.Environment.NewLine+"left";
		if (Key.is_Active (right)) s += System.Environment.NewLine+"right";
		if (Key.is_Active (down)) s += System.Environment.NewLine+"down";
		if (Key.is_Active (up)) s += System.Environment.NewLine+"up";
		if (Key.is_Active (jump)) s += System.Environment.NewLine+"jump";
		if (Key.is_Active (attack)) s += System.Environment.NewLine+"attack";
		if (Key.is_Active (skill)) s += System.Environment.NewLine+"skill";
		if (Key.is_Active (dash)) s += System.Environment.NewLine+"dash";
		if (Key.is_Active (weaponSwap)) s += System.Environment.NewLine+"weaponSwap";
		if (Key.is_Active (weaponSkill_1)) s += System.Environment.NewLine+"weaponSkill_1";
		if (Key.is_Active (weaponSkill_2)) s += System.Environment.NewLine+"weaponSkill_2";

		return s;
	}

	public Key left;
	public Key right;
	public Key down;
	public Key up;
	public Key jump;
	public Key attack;
	public Key skill;
	public Key dash;
	public Key weaponSwap;
	public Key weaponSkill_1;
	public Key weaponSkill_2;

	public PlayerKey () {
		left = new Key (KeyCode.LeftArrow);
		right = new Key (KeyCode.RightArrow);
		down = new Key (KeyCode.DownArrow);
		up = new Key (KeyCode.UpArrow);
		jump = new Key (KeyCode.Space);
		attack = new Key (KeyCode.A);
		skill = new Key (KeyCode.S);
		dash = new Key (KeyCode.D);
		weaponSwap = new Key (KeyCode.Q);
		weaponSkill_1 = new Key (KeyCode.W);
		weaponSkill_2 = new Key (KeyCode.E);
	}
}
