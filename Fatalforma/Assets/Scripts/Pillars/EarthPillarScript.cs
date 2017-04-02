using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthPillarScript : MonoBehaviour {
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (StaticData.green == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip,0.5f);
                StaticData.earthPillar = 1;
                Destroy(gameObject);
            }
			
        }


    }
}
