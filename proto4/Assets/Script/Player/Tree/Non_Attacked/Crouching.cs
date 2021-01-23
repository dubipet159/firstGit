using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouching : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_crouching = new Is_Crouching ();
		Node crouchAction = new Crouch_Blending ();
		return Node_Sequence.Create (is_crouching, crouchAction);
	}
}
public class Is_Crouching : Node_Checker {
	public override bool Condition () { return PlayerStateControl.basic_Action == "crouch"; }
}