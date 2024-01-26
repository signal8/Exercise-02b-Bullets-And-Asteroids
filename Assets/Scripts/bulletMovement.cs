using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
	private Rigidbody2D rb;
	private SpriteRenderer sr;
	public float countdown = 1.0f;
	public float speed = 3.0f;
	public int damage = 1;
	public float fadeSpeed = 1.1f;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer>();

		rb.velocity = transform.up * speed;
	}

    	// Update is called once per frame
    	void Update()
    	{
		if (countdown > 0)
		{
			Color lerpedColor = Color.Lerp(Color.black, Color.white,
					countdown);
			countdown -= Time.deltaTime;

			sr.color = lerpedColor;
			
		} else {
			Destroy(gameObject);
		}
    	}
}
