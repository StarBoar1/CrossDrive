using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CarLights))]
[RequireComponent(typeof(MoveCar))]
public class DLeft : MonoBehaviour
{
	private Rigidbody rb;
	private float eulerAngleVelocity;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		GetComponent<CarLights>().showObject = 1;
	}

	void FixedUpdate()
	{

		RightTurn();
	}

	void RightTurn()
	{
		float carRotation = Mathf.Floor(transform.eulerAngles.y);
		if (transform.localPosition.z > -9f && carRotation > 91f)
		{
			if (carRotation >= 90 && carRotation < 94)
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 91, 0));
				return;
			}
			Debug.Log(carRotation);
			eulerAngleVelocity = GetComponent<MoveCar>().speed * -8.57f;
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation(rb.rotation * deltaRotation);
		}
	}

}
