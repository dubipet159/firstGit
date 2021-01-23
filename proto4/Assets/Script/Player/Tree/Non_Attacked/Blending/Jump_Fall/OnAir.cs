using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAir : Node_Tree {

	public override Node SetUp_Tree () {
		Node jump = new Jump_Action ();
		Node fall = new Fall_Action ();

		Node groundCheck = new GroundCheck_Node ();
		Node onAirCheck = Node_Inverter.Create (groundCheck);
		return Node_Sequence.Create (onAirCheck, jump, fall);
	}
}
