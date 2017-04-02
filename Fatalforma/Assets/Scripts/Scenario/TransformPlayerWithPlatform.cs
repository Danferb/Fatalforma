using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPlayerWithPlatform : MonoBehaviour {

    public GameObject worldTarget;
    public GameObject playerTarget;
    public float rotate = -20;
    private bool changed = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {
        if (!changed && other.tag.Equals(GameManager.TAG_PLAYER)) {
            worldTarget.transform.Rotate(new Vector3(rotate,0,0));
            changed = true;
        }
    }
}
