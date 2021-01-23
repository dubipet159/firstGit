using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Selector : Node {
	protected List<Node> nodeList;

	public static Node_Selector Create (params Node[] args) {
		return new Node_Selector (args);
	}

	public Node_Selector (params Node[] args) {
		nodeList = new List<Node> ();
		foreach (Node item in args) nodeList.Add (item);
	}

	public override NodeState Evaluate () {
		foreach (var node in nodeList) {
			switch (node.Evaluate ()) {

				case NodeState.Running:
					_state = NodeState.Running;
					return _state;
				case NodeState.Success:
					_state = NodeState.Success;
					return _state;
				case NodeState.Failed:
					break;
				default:
					break;
			}
		}
		_state = NodeState.Failed;
		return _state;
	}
}
