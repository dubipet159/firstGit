using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequence : Node {
	protected List<Node> nodes = new List<Node> ();
	public Sequence (List<Node> nl) {
		this.nodes = nl; ;
	}

	public override NodeState Evaluate () {
		bool isRunning = false;
		foreach (var node in nodes) {
			switch (node.Evaluate ()) {

				case NodeState.Running:
					isRunning = true;
					break;
				case NodeState.Success:
					_state = NodeState.Success;
					break;
				case NodeState.Fail:
					_state = NodeState.Fail;
					break;
			}
		}
		_state = isRunning ? NodeState.Running : NodeState.Success;
		return _state;
	}
}
