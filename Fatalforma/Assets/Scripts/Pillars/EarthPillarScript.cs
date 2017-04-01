using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthPillarScript : MonoBehaviour {

    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StaticData.earthPillar = 1;
            Destroy(gameObject);
        }


    }
}
