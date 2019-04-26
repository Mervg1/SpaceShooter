using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float enemyInitialVelocity = -5f;
    public int lives;


    private Rigidbody rigb;
    //private bool enemyInPlay;

    void Awake()
    {

        rigb = GetComponent<Rigidbody>();

    }

    void Update()
    {
    

        //StartCoroutine(move());
        transform.parent = null;
        //enemyInPlay = true;
        rigb.isKinematic = false;
        rigb.AddForce(new Vector3(enemyInitialVelocity, 0, 0));

        StartCoroutine(live());


    }


    IEnumerator live()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(lives < 1)
        {
            Destroy(this.gameObject);
        }

    }
}
