﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skip : MonoBehaviour {
	public float delayTime = 3;
	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(delayTime);

		Application.LoadLevel ("Menu");
	}


}
