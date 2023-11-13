using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayPlayer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Transform myTransform = this.transform;

            Vector3 worldPos = myTransform.position;

            worldPos.x =   0.0f;    
            worldPos.y =   0.5f;    
            worldPos.z = -15.0f;

            myTransform.position = worldPos;
        }
    }
}