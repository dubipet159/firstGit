using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idling : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_idling = new Is_Idling ();
		Node idleAction = new Idle_Blending ();
		return Node_Sequence.Create (is_idling, idleAction);
	}
}
public class Is_Idling : Node_Checker {
	public override bool Condition () { return PlayerStateControl.basic_Action == "idle"; }
}