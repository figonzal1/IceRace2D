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

	public float torque;
	public float maxSpeed;

	private float movement;

	void Update()
	{
		movement = Input.GetAxisRaw("Vertical");
	}

	private void FixedUpdate()
	{
		carRigid.AddTorque(movement * torque * Time.fixedDeltaTime);
		frontWheel.AddTorque(-movement * maxSpeed * Time.fixedDeltaTime);
		backWheel.AddTorque(-movement * maxSpeed * Time.fixedDeltaTime);
	}
}
