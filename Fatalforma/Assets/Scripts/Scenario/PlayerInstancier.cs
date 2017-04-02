using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstancier : MonoBehaviour {

    public GameObject player;
    public Transform instancier;

	// Use this for initialization
	void Start ()
    {
        Instantiate(player, instancier.position, Quaternion.Euler(new Vector3(0,180,0)));
	}
	
	
}
