using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Action : Action_Node {
	public override bool Condition () {
		bool left = PlayerKey.left.ON;
		bool right = PlayerKey.right.ON;
		return left != right;
	}
	public override void Excution () { PlayerStateControl.basic_Action = "run"; }
	public override string SetName () {return "run";}
}