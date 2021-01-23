using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Action : Action_Node {
	public override bool Condition () {
		return PlayerStateControl.player.is_Jumping;
	}
	public override void Excution () { PlayerStateControl.basic_Action = "jump"; }
	public override string SetName () { return "jump"; }
}
