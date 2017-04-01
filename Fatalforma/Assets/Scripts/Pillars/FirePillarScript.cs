using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePillarScript : MonoBehaviour {

    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StaticData.firePillar = 1;
            Destroy(gameObject);
        }


    }
}
