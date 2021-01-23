using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Action_Tree : Node_Tree {

	public override Node SetUp_Tree () {
		Node idling = new Idling ();
		Node running = new Running ();
		Node crouching = new Crouching ();
		Node jumping = new Jumping ();
		Node falling = new Falling ();

		Node nonAttacked = Node_Selector.Create (crouching, running, idling, jumping, falling);

		Node attacked = new Attacked ();

		return Node_Selector.Create (attacked, nonAttacked);
	}
}