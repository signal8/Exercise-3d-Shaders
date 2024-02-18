using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeScript : MonoBehaviour
{
	private Transform ball;
	// Start is called before the first frame update
	void Start()
	{
        	ball = GameObject.Find("Ball").transform;
	}

	// Update is called once per frame
	void Update()
	{
		Quaternion tmp = transform.rotation;
		tmp.SetLookRotation(Vector3.forward, 
				ball.position - transform.position);
		transform.rotation = tmp;
	}
}
