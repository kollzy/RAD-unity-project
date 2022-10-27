using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carbalance : MonoBehaviour
{
	// i got this code from the internet and i modified it a bit (https://www.youtube.com/watch?v=BwL3Dm8GJtQ)
	// Start is called before the first frame update



	public WheelCollider WheelL;
	public WheelCollider WheelR;
	public float balance = 3000.0f;

	private Rigidbody car;

	void Start()
	{
		car = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		WheelHit hit;
		float travelL = 1.0f;
		float travelR = 1.0f;


		bool groundedL = WheelL.GetGroundHit(out hit);
		if (groundedL)
		{
			travelL = (-WheelL.transform.InverseTransformPoint(hit.point).y - WheelL.radius) / WheelL.suspensionDistance;
		}

		bool groundedR = WheelR.GetGroundHit(out hit);
		if (groundedR)
		{
			travelR = (-WheelR.transform.InverseTransformPoint(hit.point).y - WheelR.radius) / WheelR.suspensionDistance;
		}

		float balanceForce = (travelL - travelR) * balance;

		if (groundedL)
			car.AddForceAtPosition(WheelL.transform.up * -balanceForce, WheelL.transform.position);

		if (groundedR)
			car.AddForceAtPosition(WheelR.transform.up * balanceForce, WheelR.transform.position);
	}
}
    
        
    
