using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SpatialTracking;

namespace Assets.Teleportal.Scripts
{
    class TpCollision : MonoBehaviour
    {
        public bool enter = true;
        void Update()
        {
            
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("WTF");
            //if (other.gameObject.name == "Sale1")
            //{
            //    Debug.Log("Collision detected");
            //}

        }


    }
    
}
