using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Action : Action_Node {
	public override bool Condition () {
		return !PlayerStateControl.player.is_OnGround && !PlayerStateControl.player.is_Jumping;
	}
	public override void Excution () { PlayerStateControl.basic_Action = "fall"; }
	public override string SetName () { return "fall"; }
}
