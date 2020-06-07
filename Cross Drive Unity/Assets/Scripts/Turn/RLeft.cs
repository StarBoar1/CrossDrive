using System.Collections;
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
[RequireComponent(typeof(CarLights))]
public class RLeft : MonoBehaviour
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
		leftTurn();
	}

	void leftTurn()
	{
		float carRotation = Mathf.Floor(transform.eulerAngles.y);
		if (transform.localPosition.x < -78f && carRotation > 0)
		{
			if (carRotation >= 1 && carRotation <= 4)
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 1, 0));
				return;
			}
			Debug.Log(carRotation);
			eulerAngleVelocity = GetComponent<MoveCar>().speed * -8.57f;
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation(rb.rotation * deltaRotation);
		}
	}

}