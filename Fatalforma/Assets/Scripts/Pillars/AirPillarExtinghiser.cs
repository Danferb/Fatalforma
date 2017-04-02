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
                GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip, 0.5f);
                StaticData.airPillar = 1;
                Destroy(gameObject);
            }
			
        }

      
    }
}
