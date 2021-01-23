using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	moveFunctions moveFunc;
	GroundCheck groundCheck;

	[SerializeField]
	public float moveSpeed;
	[SerializeField]
	public float maxMoveSpeed;
	[SerializeField]
	public float jumpPower;
	[SerializeField]
	public float frictionRate = 0.925f;

	public bool is_OnGround;
	public bool is_Jumping;

	void GroundCheck () {
		is_OnGround = groundCheck.Check_Is_OnGround ();
	}
	void JumpCheck () {
		is_Jumping = moveFunc.is_Jumping ();
	}


	void Lock_Speed () {
		moveFunc.Lock_X_Velocity (maxMoveSpeed);
	}

	void frictioning () {
		moveFunc.Multiply_X_Velocity (frictionRate);
	}

	private void Awake () {
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
	}

	private void Update () {
		groundCheck.Debug_ShowCast_Ground ();
		GroundCheck ();
		JumpCheck ();
		Lock_Speed ();
		frictioning ();
	}


}
