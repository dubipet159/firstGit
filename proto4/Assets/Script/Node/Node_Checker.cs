using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node_Checker : Node
{
	public abstract bool Condition ();

	public override NodeState Evaluate () {
		if (Condition ()) _state = NodeState.Success;
		else _state = NodeState.Failed;
		return _state;
	}
}
