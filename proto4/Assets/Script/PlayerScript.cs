using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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



	private void Start () {
		groundCheck = GetComponent<GroundCheck> ();
		moveFunc = GetComponent<moveFunctions> ();
	}


}
