using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPillarExtinghiser : MonoBehaviour {
    public GameObject target;

	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            if (StaticData.yellow == 1)
            {
                GetComponent<AudioSource>().Play();
                StaticData.airPillar = 1;
                Destroy(gameObject);
            }
			
        }

      
    }
}
