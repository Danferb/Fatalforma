using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporter : MonoBehaviour {
    
    public GameObject pointToTransport;

    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals(GameManager.TAG_PLAYER)) {
            other.transform.position = pointToTransport.transform.position;
        }
    }
}
