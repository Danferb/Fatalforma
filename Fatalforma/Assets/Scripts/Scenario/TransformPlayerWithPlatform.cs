using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPlayerWithPlatform : MonoBehaviour {

    public GameObject worldTarget;
    public float rotate = -20;
    private bool changed = false;

<<<<<<< HEAD
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
=======
    private void OnTriggerEnter(Collider other) {
        if (!changed && other.tag.Equals(GameManager.TAG_PLAYER)) {
            Quaternion target = Quaternion.Euler(rotate, 0, rotate);
            worldTarget.transform.rotation = Quaternion.Slerp(worldTarget.transform.rotation, target, Time.deltaTime * 2.0f);
            other.transform.RotateAround(other.transform.position, other.transform.forward, rotate);
            changed = true;
        }
    }
}
>>>>>>> 8f7b16469ef718bdb045a2629b5b5ba33ed5ced2
