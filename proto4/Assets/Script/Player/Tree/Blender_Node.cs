using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blender_Node : Node {
	string Blending () {
		string basic = PlayerStateControl.basic_Action;
		string blend = PlayerStateControl.blend_Action;
		string blended;
		if (basic == blend) {
			return basic;
		}
		else {
			blended = basic + "_to_" + blend;
		}
		return blended;
	}

	public override NodeState Evaluate () {
		Node anim = new PlayerAnim_Node (Blending ());
		return anim.Evaluate ();
	}
}
