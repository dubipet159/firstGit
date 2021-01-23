using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.down.ON;
	}
	public override void Excution () { PlayerStateControl.basic_Action = "crouch"; }
	public override string SetName () { return "crouch"; }
}
