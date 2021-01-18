using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
	public static LayerMask ground_Layer = 0;
	public static float margin = 0.1f;

	CapsuleCollider2D collid;
	Rigidbody2D rigid;

	RaycastHit2D touchedGround;
	protected GameObject touchedGround_Obj {
		get {
			return touchedGround.collider.gameObject;
		}
	}
	protected bool is_OnGround {
		get {
			return (rigid.velocity.y == 0) && (touchedGround.collider != null);
		}
	}


	void BoxCast_Down_By_Ground () {
		//print ("casted");
		touchedGround = Physics2D.BoxCast (
		collid.bounds.center, //시작점
		collid.bounds.size - (new Vector3 (margin * 2, 0f, 0f)), // 사이즈
		0f, // 각도
		Vector2.down, // 방향
		collid.bounds.extents.y + margin, // 거리
		ground_Layer //레이어
		);
	}

	void Debug_ShowCast_Ground () {
		Color rayColor = is_OnGround ? Color.red : Color.green;
		Debug.DrawRay (
			collid.bounds.center - collid.bounds.extents + new Vector3 (margin, -margin, 0f), //시작점
			Vector2.right * (collid.bounds.size.x - margin * 2), //길이,방향
			rayColor // 레이컬러
			);
		Debug.DrawRay (
		collid.bounds.center - collid.bounds.extents + new Vector3 (margin, 0f, 0f), //시작점
		Vector2.right * (collid.bounds.size.x - margin * 2), //길이,방향
		rayColor // 레이컬러
		);
	}

	private void Awake () {
		if (ground_Layer == 0)
			LayerMask.GetMask ("Ground");

		collid = GetComponentInChildren<CapsuleCollider2D> ();
		rigid = GetComponent<Rigidbody2D> ();
	}
}
