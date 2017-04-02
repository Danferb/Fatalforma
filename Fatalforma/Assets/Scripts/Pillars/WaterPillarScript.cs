using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPillarScript : MonoBehaviour {
	public AudioClip ac;
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (StaticData.blue == 1)
            {
                this.GetComponent<AudioSource>().PlayOneShot(ac, 0.5f);
                StaticData.waterPillar = 1;
                Destroy(gameObject);
            }
			
        }


    }
}
