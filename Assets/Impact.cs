using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour
{


    private bool collided;
    //coInfo.collider.tag != "meteor" && coInfo.collider.tag != "player"
    void OnCollisionEnter(Collision coInfo)
    {
        if(coInfo.gameObject.tag == "planet" && !collided )
        {
            collided = true;
            Destroy(gameObject);
            
        }
        else
        {
            Destroy(gameObject, 10f);
        } 
            
    }
    
}
