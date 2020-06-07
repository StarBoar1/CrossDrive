using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
[RequireComponent(typeof(CarLights))]
public class DRight : MonoBehaviour
{
	private Rigidbody rb;
	private float eulerAngleVelocity;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		GetComponent<CarLights>().showObject = 0;
	}

	void FixedUpdate()
	{
		Debug.Log(Mathf.Floor(transform.eulerAngles.y));
		RightTurn();
	}

	void RightTurn()
	{
		float carRotation = Mathf.Floor(transform.eulerAngles.y);
		if (transform.localPosition.z > -15f )//&& carRotation < 270)
		{
			if (carRotation >= 270 && carRotation < 274)
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 271, 0));
				return;
			}
			Debug.Log(carRotation);
			eulerAngleVelocity = GetComponent<MoveCar>().speed * 8.57f;
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation(rb.rotation * deltaRotation);
		}
	}

}
