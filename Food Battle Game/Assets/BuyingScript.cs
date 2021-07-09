using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyingScript : MonoBehaviour
{
    public  int buildIndex;
    public  GameObject[]  placements;
    public  GameObject[]  turrents;


    public  void    buyDonuts(){
        Instantiate(turrents[0], new    Vector3(placements[buildIndex].transform.position.x, placements[buildIndex].transform.position.y, placements[buildIndex].transform.position.z), Quaternion.identity);
        placements[buildIndex].GetComponent<PlacementScript>().hasTurrent = true;
        gameObject.SetActive(false);
    }
    public  void    buyCookie(){
        Instantiate(turrents[1], new    Vector3(placements[buildIndex].transform.position.x, placements[buildIndex].transform.position.y + 0.5f, placements[buildIndex].transform.position.z), Quaternion.identity);
        placements[buildIndex].GetComponent<PlacementScript>().hasTurrent = true;
        gameObject.SetActive(false);
    }
}
