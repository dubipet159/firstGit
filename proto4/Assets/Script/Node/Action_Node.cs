using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action_Node : Node {
	Node blender = new Blender_Node ();
	protected string _name;
	public string name {
		get { return _name; }
	}
	public Action_Node () {
		_name = SetName ();
	}
	public abstract string SetName ();
	public abstract void Excution ();

	public abstract bool Condition ();

	public override NodeState Evaluate () {
		if (Condition ()) {
			PlayerStateControl.blend_Action = name;
			_state = blender.Evaluate ();
			Excution ();
		}
		else _state = NodeState.Failed;
		return _state;
	}

}
