using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : Node {
	protected List<Node> nodes = new List<Node> ();
	public Selector (List<Node> nl) {
		this.nodes = nl;
	}

	public override NodeState Evaluate () {
		foreach (var node in nodes) {
			switch (node.Evaluate ()) {

				case NodeState.Running:
					_state = NodeState.Running;
					break;
				case NodeState.Success:
					_state = NodeState.Success;
					break;
				case NodeState.Fail:
					break;
			}
		}
		_state = NodeState.Fail;
		return _state;
	}
}
