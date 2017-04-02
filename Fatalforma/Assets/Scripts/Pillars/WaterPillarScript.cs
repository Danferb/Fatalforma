using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPillarScript : MonoBehaviour {
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (StaticData.blue == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip, 0.5f);
                StaticData.waterPillar = 1;
                Destroy(gameObject);
            }
			
        }


    }
}
