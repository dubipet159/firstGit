using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_jumping = new Is_Jumping ();
		Node jumpAction = new Jump_Blending ();
		return Node_Sequence.Create (is_jumping, jumpAction);
	}
}
public class Is_Jumping : Node_Checker {
	public override bool Condition () { return PlayerStateControl.basic_Action == "jump"; }
}