using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node {
	protected List<Node> nodeList = new List<Node> ();
	public Sequence (List<Node> nl) {
		this.nodeList = nl; ;
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
					break;
			}
		}
		_state = isRunning ? NodeState.Running : NodeState.Success;
		return _state;
	}
}
