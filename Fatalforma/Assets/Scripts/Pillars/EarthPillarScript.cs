using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthPillarScript : MonoBehaviour {
	public AudioClip ac;
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && StaticData.green == 1)
        {

			this.GetComponent<AudioSource> ().PlayOneShot (ac, 0.5f); 
            StaticData.earthPillar = 1;
            Destroy(gameObject);
        }


    }
}
