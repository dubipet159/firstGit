using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacked : Node_Tree {
	public override Node SetUp_Tree () {
		Node is_Attacked = new Is_Attacked ();
		Node attackedAction = new Attacked_Action ();

		return Node_Sequence.Create (is_Attacked, attackedAction);
	}
}
public class Is_Attacked : Node_Checker {
	public override bool Condition () { return PlayerStateControl.is_attacked; }
}

public class Attacked_Action:Node{
	Node attacked_OnGround = new PlayerAnim_Node ("attacked_onground");
	Node attacked_OnAir = new PlayerAnim_Node ("attacked_onAir");

	bool Condition () {
		return PlayerStateControl.player.is_OnGround;
	}
	public override NodeState Evaluate () {
		if (Condition ()) return attacked_OnGround.Evaluate ();
		else return attacked_OnAir.Evaluate ();
	}
}