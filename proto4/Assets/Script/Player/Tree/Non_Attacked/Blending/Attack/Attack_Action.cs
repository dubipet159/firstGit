using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.attack.ON;
	}
	public override void Excution () { }
	public override string SetName () { return "attack"; }
}
