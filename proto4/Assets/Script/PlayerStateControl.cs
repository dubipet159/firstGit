using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateControl
{
	enum State {
		idling,running,crouching,jumping,falling
	}

	enum Action {
		none, run, crouch, jump, attack, skill, dash, swap, weaponSkill_1, weaponSkill_2
	}
	State state;
	Action action;

	bool is_OnGround;

	bool running_Condition;
	bool crouching_Condition;
	bool falling_Condition;

	void StateUpdate () {
		if (is_OnGround) {
			if (running_Condition) state = State.running;
			else if (crouching_Condition) state = State.crouching;
			else state = State.idling;
		}
		else {
			if (falling_Condition) state = State.falling;
			else state = State.jumping;
		}
	}
}
