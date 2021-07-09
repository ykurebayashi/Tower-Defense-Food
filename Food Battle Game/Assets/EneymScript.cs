using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneymScript : MonoBehaviour
{
    public  int healthPoints = 10;
    public  int moveSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * -1 * moveSpeed);
        if(healthPoints == 0){
            Destroy(gameObject);
        }
    }

    /*void    OnCollisionEnter (Collision collision){
        if(collision.gameObject.CompareTag("Bullet")){
            healthPoints--;
        }
    }*/
}
