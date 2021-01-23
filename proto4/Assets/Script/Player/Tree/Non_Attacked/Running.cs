using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_running = new Is_Running ();
		Node runAction = new Run_Blending ();
		return Node_Sequence.Create (is_running, runAction);
	}
}
public class Is_Running : Node_Checker {
    public override bool Condition () { return PlayerStateControl.basic_Action == "run"; }
}