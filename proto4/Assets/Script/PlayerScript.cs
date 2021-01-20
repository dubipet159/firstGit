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

	void Lock_Speed () {
		moveFunc.Lock_X_Velocity (maxMoveSpeed);
	}

	void frictioning () {
		moveFunc.Multiply_X_Velocity (frictionRate);
	}

	private void Start () {
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
	}

	private void Update () {
		groundCheck.Debug_ShowCast_Ground ();
		Lock_Speed ();
		frictioning ();
	}


}
