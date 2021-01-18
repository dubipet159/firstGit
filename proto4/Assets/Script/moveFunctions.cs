using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFunctions : MonoBehaviour {
	Rigidbody2D rigid;

	// addforce
	protected void AddForce (Vector2 dir, float axis, float velocity) {
		rigid.AddForce (dir * axis * velocity, ForceMode2D.Impulse);
	}

	//수평 addforce
	protected void AddForce_X (float axis,float velocity) {
		AddForce (Vector2.right, axis, velocity);
	}

	//수직 addforce
	protected void AddForce_Y (float axis, float velocity) {
		AddForce (Vector2.up, axis, velocity);
	}

	// 수직수평 속도세팅
	protected void Set_Velocity (float X, float Y) {
		rigid.velocity = new Vector2 (X, Y);
	}
	//수평 속도 세팅
	protected void Set_X_Velocity (float X) {
		Set_Velocity (X, rigid.velocity.y);
	}
	//수직 속도 세팅
	protected void Set_Y_Velocity (float Y) {
		Set_Velocity (rigid.velocity.x, Y);
	}

	//수평 속도 락
	protected void Lock_X_Velocity (float maxVelocity) {
		float x = Mathf.Clamp (rigid.velocity.x, -maxVelocity, maxVelocity);
		Set_X_Velocity (x);
	}

	//수직 속도 0으로 초기화
	protected void Reset_Y_Velocity () {
		Set_Y_Velocity (0);
	}
	//수평 속도 0으로 초기화
	protected void Reset_X_Velocity () {
		Set_X_Velocity (0);
	}


	//수평 속도 비율로 감소
	protected void Multiply_X_Velocity (float rate) {
		Set_X_Velocity (rigid.velocity.x * rate);
	}

	//오차내에서 0으로 초기화
	protected void Stop_X_In_Margin (float margin) {
		if (Mathf.Abs (rigid.velocity.x) < margin)
			Reset_X_Velocity ();
	}

	protected void Jump (float jumpPower) {
		Reset_Y_Velocity ();
		AddForce_Y (1,1*jumpPower);
	}


	//플립
	protected void Flip_X (float axis) {
		if (axis == 0)
			return;
		else if (axis > 0)
			transform.localScale = new Vector3 (1, 1, 1);
		else
			transform.localScale = new Vector3 (-1, 1, 1);
	}

	private void Awake () {
		rigid = GetComponent<Rigidbody2D> ();
	}

}
