using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float missInitialVelocity = 500f;


    private Rigidbody rigb;
    private bool missInPlay;

    void Awake()
    {

        rigb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && missInPlay == false)
        {
            shoot();
        }

        StartCoroutine(live());


    }

    public void shoot()
    {
        transform.parent = null;
        missInPlay = true;
        rigb.isKinematic = false;
        rigb.AddForce(new Vector3(missInitialVelocity, 0, 0));
    }

    IEnumerator live()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
