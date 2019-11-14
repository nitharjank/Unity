using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Teleportal;
using System.Threading.Tasks;
using System;

public class EvanAnimator : MonoBehaviour
{
    public TPUser tpuser;

    void Start()
    {
        if (this.tpuser.isSelfUser) {
            this.enabled = false;
        }
        //Teleportal.GeoModule.Shared.Latitude = 0.0;
        //Teleportal.GeoModule.Shared.Longitude = 0.0;
    }

    void Update()
    {
        //transform.position += new Vector3(transform.forward.x, (transform.forward.y), 0.0f);
        transform.position += new Vector3(0.0f, (0.01f * Mathf.Sin(Time.time * 4)), 0.0f);
        //transform.position += transform.forward.x;
        //transform.position += TPObject.GetEarthTransform();
    }

    void OnCollisionEnter(Collision c)
    {

        if (c.gameObject.name == "Sale1")
        {
            Debug.Log("Collision detected");
        }

    }

 
    void OnCollisionExit(Collision c)
    {
        //this.DestroyLaser();
    }
}
