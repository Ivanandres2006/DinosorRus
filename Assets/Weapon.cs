using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Instantiate(projectile, shotPoint.position,transform.rotation);
            timeBtwShots = startTimeBtwShots;

            
        }

        else
        {
            timeBtwShots -= Time.deltaTime;    
        }
    }
}
