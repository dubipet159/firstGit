using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.weaponSwap.ON;
	}
	public override void Excution () { }
	public override string SetName () { return "swap"; }
}
