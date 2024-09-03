using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact_planets : MonoBehaviour
{
    private bool coll;
    //coInfo.collider.tag != "meteor" && coInfo.collider.tag != "player"
    void OnCollisionEnter(Collision coInfo)
    {
        if (coInfo.gameObject.tag == "meteor" && !coll)
        {
            coll = true;
            Destroy(gameObject);

        }
       
        

    }
}
