using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_falling = new Is_Falling ();
		Node fallAction = new Fall_Blending ();
		return Node_Sequence.Create (is_falling, fallAction);
	}
}
public class Is_Falling : Node_Checker {
    public override bool Condition () { return PlayerStateControl.basic_Action == "fall"; }
}
