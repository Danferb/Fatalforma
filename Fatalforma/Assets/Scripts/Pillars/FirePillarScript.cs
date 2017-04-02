﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePillarScript : MonoBehaviour {
    public GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && StaticData.red == 1)
        {

			this.GetComponent<AudioSource> ().PlayOneShot (this.GetComponent<AudioSource>().clip,0.5f); 
            StaticData.firePillar = 1;
            Destroy(gameObject);
        }


    }
}
