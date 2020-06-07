using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
[RequireComponent(typeof(CarLights))]
public class LRight : MonoBehaviour
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
		RightTurn();
	}

	void RightTurn()
	{
		float carRotation = Mathf.Floor(transform.eulerAngles.y);
		if (transform.localPosition.x > -90f && carRotation > 0)
		{
			if (carRotation >= 1 && carRotation <= 4)
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 1f, 0));
				return;
			}
			Debug.Log(carRotation);
			eulerAngleVelocity = GetComponent<MoveCar>().speed * 8.57f;
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation(rb.rotation * deltaRotation);
		}
	}

}