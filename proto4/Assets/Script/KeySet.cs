using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySet
{
	List<Key> KeyList;

	public string Return_AllKeyStatus () {
		string s = "";
		for (int i = 0; i < KeyList.Count; i++) {
			s += KeyList[i].ReturnKeyStatus ();
		}
		return s;
	}

	public Key GetKey (string name) {
		for (int i = 0; i < KeyList.Count; i++) {
			if (KeyList[i].GetKeyName () == name) return KeyList[i];
		}
		return null;
	}

	public void Update_AllKey () {
		for (int i = 0; i < KeyList.Count; i++) {
			KeyList[i].UpdateKey ();
		}
	}

	public void AddKey (Key k) {
		if (KeyList == null) KeyList = new List<Key> ();
		KeyList.Add (k);
	}
}
