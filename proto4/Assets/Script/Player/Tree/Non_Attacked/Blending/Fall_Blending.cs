﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_Blending : Node_Tree
{
	public override Node SetUp_Tree () {
		Node fall = new Fall_Action ();
		Node attack = new Attack_Action ();


		Node skill = new Skill_Action ();
		Node swap = new Swap_Action ();
		Node ws1 = new WS_1_Action ();
		Node ws2 = new WS_2_Action ();

		Node idle = new Idle_Action ();

		return Node_Selector.Create (attack, skill, swap, ws1, ws2, fall, idle);
	}
}
