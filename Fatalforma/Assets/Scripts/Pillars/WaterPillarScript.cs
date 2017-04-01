using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPillarScript : MonoBehaviour {

    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StaticData.waterPillar = 1;
            Destroy(gameObject);
        }


    }
}
