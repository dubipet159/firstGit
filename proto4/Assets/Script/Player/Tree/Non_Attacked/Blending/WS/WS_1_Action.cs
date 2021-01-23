using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WS_1_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.weaponSkill_1.ON;
	}
	public override void Excution () { }
	public override string SetName () { return "ws1"; }
}
