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
			Instantiate(player, instancier.position, Quaternion.identity); Quaternion target = Quaternion.Euler(-20, 0, -20);
            world.transform.rotation = Quaternion.Slerp(world.transform.rotation, target, Time.deltaTime * 2.0f);
            Destroy(c.gameObject);
        }
    }
}
