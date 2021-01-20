using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node {
	protected List<Node> nodeList = new List<Node> ();
	public Selector (List<Node> nl) {
		this.nodeList = nl;
	}

	public override NodeState Evaluate () {
		foreach (var node in nodeList) {
			switch (node.Evaluate ()) {

				case NodeState.Running:
					_state = NodeState.Running;
					break;
				case NodeState.Success:
					_state = NodeState.Success;
					break;
				case NodeState.Failed:
					break;
			}
		}
		_state = NodeState.Failed;
		return _state;
	}
}
