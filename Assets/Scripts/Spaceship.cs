using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{

    [SerializeField] private GameObject missile;

    public float maxSpeed = 5f;
    public int lives;
    //public float rotSpeed = 180f;

    private void Start()
    {
        lives = 5;
    }


    void Update()
    {
      

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        pos += velocity;

        transform.position = pos;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(lives >= 1)
        {
            Destroy(this.gameObject);
            lives--;
        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("Game Over");
        }
    }


}
