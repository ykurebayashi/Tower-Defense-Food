using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public  int currentStage;
    public  int money;
    public  int moneyTimer;
    public  int timer;
    // Start is called before the first frame update
    void Start()
    {
        //current stage = scene index;
        //money = 200
    }

    // Update is called once per frame
    void Update()
    {
        /*if(timer > moneyTimer){
            money = money + 100;
            timer = 0;
        }*/
    }
}
