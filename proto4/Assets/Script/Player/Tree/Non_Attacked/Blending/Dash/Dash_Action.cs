using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash_Action : Action_Node {
	public override bool Condition () {
		return PlayerKey.dash.ON;
	}
	public override void Excution () { }
	public override string SetName () { return "dash"; }
}
