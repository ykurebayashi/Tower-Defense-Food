using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public  Rigidbody rb;

    public GameObject enemyFocus;

    public  int bulletdmg;

    void    Awake(){
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        rb.AddForce(new Vector3 (0, 0, 500));
        StartCoroutine(CoroutineSuicide());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CoroutineSuicide(){
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }

    void    OnCollisionEnter (Collision collision){
        enemyFocus = collision.gameObject;
        if(collision.gameObject.CompareTag("Enemy")){
            enemyFocus.GetComponent<EneymScript>().healthPoints = enemyFocus.GetComponent<EneymScript>().healthPoints - bulletdmg;;
            Destroy(gameObject);
        }
    }
}
