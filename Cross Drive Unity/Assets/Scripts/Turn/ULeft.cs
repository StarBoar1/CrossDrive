using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CarLights))]
[RequireComponent(typeof(MoveCar))]
public class ULeft : MonoBehaviour
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
		if (transform.localPosition.z < -2f )//&& carRotation < 270f)
		{
			Debug.Log(carRotation+"Left");
			if (carRotation >= 270 && carRotation < 274)
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 271, 0));
				return;

			}
			Debug.Log(carRotation);
			eulerAngleVelocity = GetComponent<MoveCar>().speed * -8.57f;
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation(rb.rotation * deltaRotation);
			Debug.Log(deltaRotation.eulerAngles + "Left");
		}
	}

}