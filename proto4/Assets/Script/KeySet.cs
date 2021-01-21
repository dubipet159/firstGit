using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeySet
{

	List<Key> _KeyList;
	public List<Key> KeyList {get { return _KeyList; }}

	public string Return_AllKeyStatus () {
		string s = "";
		for (int i = 0; i < _KeyList.Count; i++) {
			s += _KeyList[i].ReturnKeyStatus ();
		}
		return s;
	}

	public Key GetKey (string name) {
		for (int i = 0; i < _KeyList.Count; i++) {
			if (_KeyList[i].name == name) return _KeyList[i];
		}
		return null;
	}

	public void Update_AllKey () {
		for (int i = 0; i < _KeyList.Count; i++) {
			_KeyList[i].UpdateKey ();
		}
	}

	public void AddKey (Key k) {
		if (_KeyList == null) _KeyList = new List<Key> ();
		_KeyList.Add (k);
	}
}
