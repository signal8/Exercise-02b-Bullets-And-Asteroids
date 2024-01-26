using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidMovement : MonoBehaviour
{
	private Rigidbody2D rb;
	public float initSpeed = 1.5f;

    	// Start is called before the first frame update
    	void Start()
    	{
        	rb = GetComponent<Rigidbody2D>();
		transform.rotation = Quaternion.Euler(0, 0, 
				Random.value * 360);

		rb.velocity = transform.up * initSpeed;
    	}

    	// Update is called once per frame
    	void Update()
    	{
        	
    	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "bullet")
		{
			Destroy(gameObject);
		}
	}
}
