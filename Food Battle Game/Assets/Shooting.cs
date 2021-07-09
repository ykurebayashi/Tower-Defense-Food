using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float timer;
    public  int waitingTime;
    public  GameObject  ammo;

    public  int healthPoints;
    public  int value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waitingTime){
            Instantiate(ammo, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            timer = 0;
         }
    }
}
