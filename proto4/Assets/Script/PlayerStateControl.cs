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

	PlayerKey key;

	bool run_ActionIn {
		get {
			float X_Axis = 0;
			if (key.right.is_keyActive) X_Axis += 1;
			if (key.left.is_keyActive) X_Axis -= 1;
			return X_Axis != 0;
		}
	}
	bool crouch_ActionIn {
		get {return key.down.is_keyActive;}
	}
	bool jump_ActionIn {
		get { return key.jump.is_keyActive; }
	}
	bool attack_ActionIn {
		get { return key.attack.is_keyActive; }
	}
	bool skill_ActionIn {
		get { return key.skill.is_keyActive; }
	}
	bool dash_ActionIn {
		get { return key.dash.is_keyActive; }
	}
	bool swap_ActionIn {
		get { return key.weaponSwap.is_keyActive; }
	}
	bool weapon_Skill_1_In {
		get { return key.weaponSkill_1.is_keyActive; }
	}
	bool weapon_Skill_2_In {
		get { return key.weaponSkill_2.is_keyActive; }
	}

	bool run_able;
	bool crouch_able;
	bool jump_able;
	bool attack_able;
	bool skill_able;
	bool dash_able;
	bool swap_able;
	bool weapon_Skill_1_able;
	bool weapon_Skill_2_able;

	

	void ActionUpdate () {
		
	}

	private void Awake () {

	}
}
