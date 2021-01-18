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
	//[SerializeField]
	//float frictionRate = 0.925f;

	PlayerKey key;

	[SerializeField]
	Text debugText;

	bool is_Onground {
		get {
			return groundCheck.is_OnGround;
		}
	}

	private void Start () {
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
		key = new PlayerKey ();
	}




	private void FixedUpdate () {
		//물리연산
	}

	private void Update () {
		groundCheck.Debug_ShowCast_Ground ();
		groundCheck.BoxCast_Down_By_Ground ();
		debugText.text = key.ShowDebug ();
	}


}
