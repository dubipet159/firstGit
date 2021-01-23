using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim_Node : Node {
	PlayerAnimator anim;
	string animation;

	public PlayerAnim_Node(string _animation) {
		anim = PlayerStateControl.animator;
		animation = _animation;
	}

	public override NodeState Evaluate () {
		if (animation == "")
			_state = NodeState.Failed;
		else {
			anim.play (animation);
			_state = NodeState.Success;
		}
		return _state;
	}
}
