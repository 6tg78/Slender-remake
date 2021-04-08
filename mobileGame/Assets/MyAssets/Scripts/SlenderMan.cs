using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlenderMan : MonoBehaviour
{
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    { 
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //If we dont look at Slender for 8 seconds or we are too far from the range that
        //we are visivble for him, then his position is changing (hes teleporting)
        if (DistortionEffect.timeNotLooking > 8)
        {
            DistortionEffect.timeNotLooking = 0;
            Spawn();
        }

        //Keep on facing player
        transform.LookAt(new Vector3(mainCamera.transform.position.x, transform.position.y, mainCamera.transform.position.z));
    }

    //This function is spawning the Slender man with usage of RaycastHit to spawn Slender man in random place
    void Spawn()
    {
        //attribute which keeps place where slender spawns
        RaycastHit hit;
        //random distance from the range between 20 and 35
        float randomDistance = Random.Range(20, 35);
        //random angle from the range 0 to 360 degrees
        float randomAngle = Random.Range(0, 360);

        Vector3 raySpawnPosition = mainCamera.transform.position
                    + new Vector3(randomDistance * Mathf.Cos(randomAngle), 50, randomDistance * Mathf.Sin(randomAngle));

        Ray ray = new Ray(raySpawnPosition, Vector3.down);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider != null)
            {
                // this is where the gameobject is actually put on the ground
                transform.position = hit.point;
            }
        }
    }
}
