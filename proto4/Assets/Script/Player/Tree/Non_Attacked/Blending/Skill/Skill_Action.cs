using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.skill.ON;
	}
	public override void Excution () { }
	public override string SetName () { return "skill"; }
}
