﻿using System.Collections;
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
	public bool is_keyIn {
		get {
			return Input.GetKeyDown (value);
		}
	}
	public bool is_keyActive {
		get {
			return Input.GetKey (value);
		}
	}
	public bool is_keyOut {
		get {
			return Input.GetKeyUp (value);
		}
	}
	public void SetKey (KeyCode k) {
		value = k;
	}
	public KeyCode GetKey () {
		return value;
	}
	public Key (KeyCode k) {
		value = k;
	}
}