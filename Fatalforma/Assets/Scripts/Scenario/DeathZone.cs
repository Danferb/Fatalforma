using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {

    public GameObject player;
    public GameObject world;
    public Transform instancier;

	private AudioSource asource;
    private GameObject target;

    void OnTriggerEnter(Collider c) {
        if (c.tag == "Player") {
			asource = GetComponent<AudioSource>();
			asource.PlayOneShot (asource.clip);
			Instantiate(player, instancier.position, Quaternion.identity);
            //world.transform.rotation.Set(new Vector3(0,0,0));
            Destroy(c.gameObject);
        }
    }
}
