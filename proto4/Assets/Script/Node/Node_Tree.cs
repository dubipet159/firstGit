using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Node_Tree : Node
{
	Node root;

	public abstract Node SetUp_Tree ();


	public override NodeState Evaluate () {
		root = SetUp_Tree ();
		return root.Evaluate ();
	}

}
