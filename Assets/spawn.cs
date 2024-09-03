using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject spawnee;
    public Transform scaling;
    private float scale_number;
    private Vector3 destination;
    public Camera cam;

    public float firing_speed = 20;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            shootProjectile();
        }
       

        void shootProjectile()
        {
            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
                destination = hit.point;
            else
                destination = ray.GetPoint(1000);

            InstantiateProjectile();
        }
                    
         void InstantiateProjectile() 
         { 
            scale_number = Random.Range(1.0f, 5.0f);
            scaling.localScale = new Vector3(scale_number, scale_number, scale_number);
            var projectileObj = Instantiate(spawnee, spawnPos.position, spawnPos.rotation) as GameObject;
            projectileObj.GetComponent<Rigidbody>().velocity = (destination - spawnPos.position).normalized * firing_speed;
         }

    } 
                     
}
