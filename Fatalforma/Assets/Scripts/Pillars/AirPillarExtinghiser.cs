using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPillarExtinghiser : MonoBehaviour {
	public AudioClip ac;
    public GameObject target;

	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player" && StaticData.yellow == 1)
        {
			this.GetComponent<AudioSource> ().PlayOneShot (ac, 0.5f); 
            StaticData.airPillar = 1;
            Destroy(gameObject);
        }

      
    }
}
