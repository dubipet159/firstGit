using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inverter : Node {
	protected Node node;
	public Inverter (Node n) {
		this.node = n;
	}

	public override NodeState Evaluate () {
		switch (node.Evaluate ()) {

			case NodeState.Running:
				_state = NodeState.Running;
				break;
			case NodeState.Success:
				_state = NodeState.Failed;
				break;
			case NodeState.Failed:
				_state = NodeState.Success;
				break;
		}
		return _state;
	}
}