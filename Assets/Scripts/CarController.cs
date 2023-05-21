using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

	[SerializeField] private Rigidbody2D carRigid;

	[SerializeField]
	private Rigidbody2D frontWheel;

	[SerializeField]
	private Rigidbody2D backWheel;

	public float torque = 10f;
	public float speed = 100;

	private float movement;

	void Update()
	{
		movement = Input.GetAxis("Vertical");
	}

	private void FixedUpdate()
	{
		carRigid.AddTorque(movement * torque * Time.fixedDeltaTime);
		frontWheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
		backWheel.AddTorque(-movement * speed * Time.fixedDeltaTime);
	}
}
