using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key
{
	//
	public static bool is_In (Key k) {
		return k.is_keyIn;
	}
	public static bool is_Active (Key k) {
		return k.is_keyActive;
	}
	public static bool is_Out (Key k) {
		return k.is_keyOut;
	}
	public static void Set (Key k,KeyCode code) {
		k.SetKey (code);
	}
	public static KeyCode Get (Key k) {
		return k.GetKey ();
	}
	//
	KeyCode value;
	string name;

	public string GetKeyName () {
		return name;
	}

	public string ReturnKeyStatus () {
		string s = name;
		if (is_keyIn) s += ": IN";
		else if (is_keyOut) s += ": OUT";
		else if (is_keyActive) s += ": ACTIVE";
		else s += ": ";
		s += System.Environment.NewLine;
		return s;
	}

	public bool is_keyIn {
		get {return Input.GetKeyDown (value);}
		set { }
	}
	public bool is_keyActive {
		get {return Input.GetKey (value);}
		set { }
	}
	public bool is_keyOut {
		get {return Input.GetKeyUp (value);}
		set { }
	}

	public void UpdateKey () {
		is_keyIn = Input.GetKeyDown (value);
		is_keyActive = Input.GetKey (value);
		is_keyOut = Input.GetKeyUp (value);
	}

	public void SetKey (KeyCode k) {
		value = k;
	}
	public KeyCode GetKey () {
		return value;
	}
	public Key (string n,KeyCode k) {
		name = n;
		value = k;
	}
}
