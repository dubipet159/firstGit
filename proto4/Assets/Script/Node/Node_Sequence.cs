using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node_Sequence : Node {
	protected List<Node> nodeList;

	public Node_Sequence (params Node[] args) {
		nodeList = new List<Node> ();
		foreach (Node item in args) nodeList.Add (item);
	}


	public static Node_Sequence Create (params Node[] args) {
		return new Node_Sequence (args);
	}

	public override NodeState Evaluate () {
		bool isRunning = false;
		foreach (var node in nodeList) {
			switch (node.Evaluate ()) {

				case NodeState.Running:
					isRunning = true;
					break;
				case NodeState.Success:
					_state = NodeState.Success;
					break;
				case NodeState.Failed:
					_state = NodeState.Failed;
					return _state;
				default:
					break;
			}
		}
		_state = isRunning ? NodeState.Running : NodeState.Success;
		return _state;
	}
}
