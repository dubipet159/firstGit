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

	Key[] KeyArr = new Key[11];

	public void UpdateKey () {
		for (int i = 0; i < KeyArr.Length; i++) {
			KeyArr[i].UpdateKey ();
		}
	}

	public PlayerKey () {
		KeyArr[0] = left = new Key ("left",KeyCode.LeftArrow);
		KeyArr[1] = right = new Key ("right", KeyCode.RightArrow);
		KeyArr[2] = down = new Key ("down", KeyCode.DownArrow);
		KeyArr[3] = up = new Key ("up", KeyCode.UpArrow);
		KeyArr[4] = jump = new Key ("jump", KeyCode.Space);
		KeyArr[5] = attack = new Key ("attack", KeyCode.A);
		KeyArr[6] = skill = new Key ("skill", KeyCode.S);
		KeyArr[7] = dash = new Key ("dash", KeyCode.D);
		KeyArr[8] = weaponSwap = new Key ("weaponSwap", KeyCode.Q);
		KeyArr[9] = weaponSkill_1 = new Key ("weaponSkill_1", KeyCode.W);
		KeyArr[10] = weaponSkill_2 = new Key ("weaponSkill_2", KeyCode.E);
	}
}
