using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Inverter : Node {
	protected Node node;
	public Node_Inverter (Node n) {
		this.node = n;
	}


	public static Node_Inverter Create (Node n) {
		Node_Inverter newNode = new Node_Inverter (n);
		return newNode;
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