using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator {
	Animator anim;
	public PlayerAnimator(Animator a) {
		anim = a;
	}

	public void SetAnimator (Animator a) {
		anim = a;
	}

	public void play (string animation) {
		if (animation == "") {
			return;
		}
		//anim.Play (animation);
		Debug.Log (animation);
		PlayerStateControl.debug = animation;
	}
}
