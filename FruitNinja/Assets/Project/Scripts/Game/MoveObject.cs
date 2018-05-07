using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    [Header("Speed variables")]
    public float minimumXSpeed;
    public float maximumXSpeed;
    public float minimumYSpeed;
    public float maximumYSpeed;

    [Header("Gameplay")]
    public float lifetime;

	// Use this for initialization
	void Start () {
        // Throw the moveobject upwards.
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            Random.Range(minimumXSpeed, maximumXSpeed),
            Random.Range(minimumYSpeed, maximumYSpeed)
        );

        // Wait and destroy.
        Destroy(gameObject, lifetime);
	}
	
}
