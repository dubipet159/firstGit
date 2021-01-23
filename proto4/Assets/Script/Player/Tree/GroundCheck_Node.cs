using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck_Node : Node_Checker {
	public override bool Condition () {
		return PlayerStateControl.player.is_OnGround;
	}
}
