using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePillarScript : MonoBehaviour {
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (StaticData.red == 1)
            {
                GetComponent<AudioSource>().PlayOneShot(this.GetComponent<AudioSource>().clip, 0.5f);
                StaticData.firePillar = 1;
                Destroy(gameObject);
            }
			
        }


    }
}
