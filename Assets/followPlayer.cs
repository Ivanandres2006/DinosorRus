using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class followPlayer : MonoBehaviour
{ 
	public float speed;
	public float rayDist;
	private bool MovingRight;
	public Transform groundDetect;

	// Use this for initialization
	void Update()
	{
		transform.Translate(Vector2.right * speed * Time.deltaTime);
		RaycastHit2D groundCheck = Physics2D.Raycast(groundDetect.position, Vector2.down, rayDist);

		if (groundCheck.collider == false)
        {
			if (MovingRight)
            {
				transform.eulerAngles = new Vector3(0f, -180f, 0f);
				MovingRight = false;
            }
			else
            {
				transform.eulerAngles = new Vector3(0f, 0f, 0f);
				MovingRight = true;
			}
        }
	}
	
}