using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementScript : MonoBehaviour
{
    public  Color   hoverColor;

    public bool  hasTurrent;

    public  GameObject  buyMenu;
    private Renderer    rend;
    private Color   startColor;

    public  int tableIndex;


    void    Start(){
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        hasTurrent = false;
    }

    void    OnMouseDown(){

        if(hasTurrent == false){
            buyMenu.SetActive(true);
        }
        if(hasTurrent == true){
            Debug.Log("Can't Build Here!");
        }
        buyMenu.GetComponent<BuyingScript>().buildIndex = tableIndex;
    }
    void    OnMouseEnter(){
        rend.material.color = hoverColor;
    }

    void    OnMouseExit(){
        rend.material.color = startColor;
    }
}
