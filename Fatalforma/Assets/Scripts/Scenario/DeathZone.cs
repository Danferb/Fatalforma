using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {

    public GameObject player;
    public Transform world;
    public Transform instancier;

	private AudioSource asource;
    private GameObject target;

    private void Awake() {
        world = world.GetComponent<Transform>();
    }

    void OnTriggerEnter(Collider c) {
        if (c.tag == "Player") {
			asource = GetComponent<AudioSource>();
			asource.PlayOneShot (asource.clip);
			Instantiate(player, instancier.position, Quaternion.identity);
			Destroy(c.gameObject);
            world.Rotate(new Vector3(0, 0, 0));
        }
    }
}
