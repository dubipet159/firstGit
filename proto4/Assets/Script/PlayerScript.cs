using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
	moveFunctions moveFunc;
	GroundCheck groundCheck;

	[SerializeField]
	float moveSpeed;
	[SerializeField]
	float maxMoveSpeed;
	[SerializeField]
	float jumpPower;
	[SerializeField]
	float frictionRate = 0.925f;

	PlayerKey key;

	[SerializeField]
	Text debugText;

	bool is_Onground {
		get {
			return groundCheck.is_OnGround;
		}
	}




	float X_Input {
		get {
			float X_Axis = 0;
			if (key.right.is_keyActive) X_Axis += 1;
			if (key.left.is_keyActive) X_Axis -= 1;
			return X_Axis;
		}
	}

	void Input_Moving () {
		moveFunc.AddForce_X (X_Input, moveSpeed);
	}

	bool Check_Jumpable () {
		if (key.jump.is_keyActive) {
			if (is_Onground) return true;
		}
		return false;
	}

	void Input_Jumping () {
		if (Check_Jumpable()) {
			moveFunc.Reset_Y_Velocity ();
			moveFunc.Jump (jumpPower);
		}
	}
	void Lock_Speed () {
		moveFunc.Lock_X_Velocity (maxMoveSpeed);
	}

	void frictioning () {
		moveFunc.Multiply_X_Velocity (frictionRate);
	}
	void Input_Fliping () {
		moveFunc.Flip_X (X_Input);
	}

	private void Start () {
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
		key = new PlayerKey ();
	}

	private void FixedUpdate () {
		Input_Moving ();
		Input_Jumping ();
	}

	private void Update () {
		key.UpdateKey ();
		groundCheck.Debug_ShowCast_Ground ();
		groundCheck.BoxCast_Down_By_Ground ();
		debugText.text = key.ShowDebug ();
		Input_Fliping ();
		Lock_Speed ();
	}


}
