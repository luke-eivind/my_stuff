using UnityEngine;
using System.Collections;

public class shootLeft : MonoBehaviour
{

    public float power;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Trajectory();
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void Trajectory()
    {
        rb.AddForce((Vector2.left + Vector2.up) * power);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
