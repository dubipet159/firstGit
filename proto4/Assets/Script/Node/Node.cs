using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public abstract class Node
{
	protected NodeState _state;
	public NodeState state { get { return _state; } }
	public abstract NodeState Evaluate ();

}
public enum NodeState {
	Failed, Success, Running
}
