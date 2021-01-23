using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key
{

	KeyCode value;
	string _name;

	public string name{get { return _name; }}

	public string ReturnKeyStatus () {
		string s = name;
		if (ON) s += ": ACTIVE";
		else s += ": ";
		s += System.Environment.NewLine;
		return s;
	}

	public bool OFF {
		get { return !Input.GetKey (value); }
		set { }
	}
	public bool ON {
		get {return Input.GetKey (value);}
		set { }
	}

	public void UpdateKey () {
		OFF = !Input.GetKey (value);
		ON = Input.GetKey (value);
	}

	public void SetKey (KeyCode k) {
		value = k;
	}
	public KeyCode GetKey () {
		return value;
	}
	public Key (string n,KeyCode k) {
		_name = n;
		value = k;
	}
}