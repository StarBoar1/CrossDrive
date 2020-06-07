using System.Collections;
using UnityEngine;
[RequireComponent(typeof(MoveCar))]
[RequireComponent(typeof(CarLights))]
public class LLeft : MonoBehaviour
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
	float carRotation = Mathf.Floor (transform.eulerAngles.y);
	if (transform.localPosition.x > -82f && carRotation >180)
	{
		if(carRotation>=180 && carRotation <= 184 )
			{
				transform.localRotation = Quaternion.Euler(new Vector3(0, 181, 0));
				return;
			}
		
		eulerAngleVelocity = GetComponent<MoveCar>().speed * -8.57f;
		Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
		rb.MoveRotation(rb.rotation * deltaRotation);
	}
}

}