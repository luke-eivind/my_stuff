using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {


    public GameObject projectileUp;
    public GameObject projectileLeft;
    public GameObject projectileRight;
    public Transform upSpawn;
    public Transform leftSpawn;
    public Transform rightSpawn;
    public float delay;

	// Use this for initialization
	void Start () {
        StartCoroutine(Shoots());

	}
	
	// Update is called once per frame
	void Update () {
	
	}


    IEnumerator Shoots()
    {
        Instantiate(projectileRight, rightSpawn.position, transform.rotation);
        Instantiate(projectileLeft, leftSpawn.position, transform.rotation);
        Instantiate(projectileUp, upSpawn.position, transform.rotation);
        yield return new WaitForSeconds(2.0f);
        StartCoroutine(Shoots());

    }
}
