using UnityEngine;
using System.Collections;

public class shootUp : MonoBehaviour
{

    public float upPower;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Trajectory();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Trajectory()
    {
        rb.AddForce(Vector2.up * upPower);
    }
}
