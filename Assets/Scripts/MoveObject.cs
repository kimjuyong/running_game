﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

	public float speed;
    void Start()
    {
        Destroy(gameObject, 10f);
    }
	void Update(){
		transform.Translate (Vector2.left * speed);
	}

}
