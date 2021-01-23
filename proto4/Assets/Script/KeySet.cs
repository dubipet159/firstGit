using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class KeySet {

	List<Key> _KeyList;
	public List<Key> KeyList { get { return _KeyList; } }

	public KeySet newKeySet_Except (params Key[] keys) {
		List<Key> newKeyList = new List<Key> ();
		for (int i = 0; i < KeyList.Count; i++) {
			foreach (Key k in keys) {
				if (KeyList[i].name != k.name) newKeyList.Add (KeyList[i]);
			}
		}
		return new KeySet (newKeyList);
	}

	public KeySet () { _KeyList = new List<Key> (); }
	public KeySet (List<Key> kl) { _KeyList = kl; }

	public string Return_AllKeyStatus () {
		string s = "";
		for (int i = 0; i < _KeyList.Count; i++) {
			s += _KeyList[i].ReturnKeyStatus ();
		}
		return s;
	}

	public bool Check_AnyKey_In () {
		for (int i = 0; i < _KeyList.Count; i++) {
			if (_KeyList[i].ON) return true;
		}
		return false;
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
		_KeyList.Add (k);
	}
}
