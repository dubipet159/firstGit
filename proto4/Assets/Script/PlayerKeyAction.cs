using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerKeyAction : MonoBehaviour
{
	PlayerScript player;
	moveFunctions moveFunc;
	GroundCheck groundCheck;
	[SerializeField]
	Text debugText;

	public static KeySet Keys;
	private void Awake () {
		Keys = new KeySet ();
		Keys.AddKey (new Key ("left", KeyCode.LeftArrow));
		Keys.AddKey (new Key ("right", KeyCode.RightArrow));
		Keys.AddKey (new Key ("down", KeyCode.DownArrow));
		Keys.AddKey (new Key ("up", KeyCode.UpArrow));
		Keys.AddKey (new Key ("jump", KeyCode.Space));
		Keys.AddKey (new Key ("attack", KeyCode.A));
		Keys.AddKey (new Key ("skill", KeyCode.S));
		Keys.AddKey (new Key ("dash", KeyCode.D));
		Keys.AddKey (new Key ("weaponSwap", KeyCode.Q));
		Keys.AddKey (new Key ("weaponSkill_1", KeyCode.W));
		Keys.AddKey (new Key ("weaponSkill_2", KeyCode.E));
		player = GetComponent<PlayerScript> ();
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
	}


	Key key (string s) {
		return Keys.GetKey (s);
	}

	float X_Input {
		get {
			float X_Axis = 0;
			if (key("right").is_keyActive) X_Axis += 1;
			if (key("left").is_keyActive) X_Axis -= 1;
			return X_Axis;
		}
	}

	void Input_Moving () {
		moveFunc.AddForce_X (X_Input, player.moveSpeed);
	}


	bool Check_Jumpable () {
		if (key("jump").is_keyActive) {
			if (groundCheck.is_OnGround) return true;
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
		Keys.Update_AllKey ();
		debugText.text = Keys.Return_AllKeyStatus ();
	}
}
