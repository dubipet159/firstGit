using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle_Action : Action_Node {

	public override bool Condition () {
		return PlayerStateControl.player.is_OnGround;
	}
	public override void Excution () { PlayerStateControl.basic_Action = "idle"; }
	public override string SetName () { return "idle"; }
}

