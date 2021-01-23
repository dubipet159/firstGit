using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStateControl : MonoBehaviour {
	public static PlayerScript player;
	public static PlayerAnimator animator;

	public static string basic_Action;
	public static string blend_Action;
	public static bool is_attacked;

	public static string debug;

	[SerializeField]
	Text debugText;

	Node root;

	void Init () {
		if (player.is_OnGround)
			basic_Action = blend_Action = "idle";
		else
			basic_Action = blend_Action = "fall";
	}

	Node SetUp_Behavior_Tree () {
		return new Basic_Action_Tree ();
	}



	private void Start () {
		player = GetComponent<PlayerScript> ();
		animator = new PlayerAnimator (GetComponent<Animator> ());
		Init ();
		root = SetUp_Behavior_Tree ();
	}

	private void Update () {
		root.Evaluate ();
		debugText.text += System.Environment.NewLine;
		debugText.text += debug;
		debugText.text += System.Environment.NewLine;
		debugText.text += basic_Action;
		debugText.text += System.Environment.NewLine;
		debugText.text += blend_Action;
	}
}