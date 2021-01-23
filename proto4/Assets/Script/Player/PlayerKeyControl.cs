using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerKeyControl : MonoBehaviour
{
	PlayerScript player;
	moveFunctions moveFunc;
	[SerializeField]
	Text debugText;


	public float X_Input {
		get {
			float X_Axis = 0;
			if (PlayerKey.right.ON) X_Axis += 1;
			if (PlayerKey.left.ON) X_Axis -= 1;
			return X_Axis;
		}
	}

	public bool is_runKeyActive {
		get {
			return X_Input != 0;
		}
	}

	private void Awake () {
		PlayerKey.Init ();
		player = GetComponent<PlayerScript> ();
		moveFunc = GetComponent<moveFunctions> ();
	}



	void Input_Moving () {
		moveFunc.AddForce_X (X_Input, player.moveSpeed);
	}


	bool Check_Jumpable () {
		if (PlayerKey.jump.ON) {
			if (player.is_OnGround) return true;
		}
		return false;
	}
	void Input_Jumping () {
		if (Check_Jumpable ()) {
			moveFunc.Reset_Y_Velocity ();
			moveFunc.Jump (player.jumpPower);
		}
	}

	void Input_Fliping () {
		moveFunc.Flip_X (X_Input);
	}


	private void FixedUpdate () {
		Input_Moving ();
		Input_Jumping ();
		Input_Fliping ();
	}


	private void Update () {
		PlayerKey.Set.Update_AllKey ();
		debugText.text = PlayerKey.Set.Return_AllKeyStatus ();
	}
}
