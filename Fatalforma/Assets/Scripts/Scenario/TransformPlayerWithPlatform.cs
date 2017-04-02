using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPlayerWithPlatform : MonoBehaviour {

    public GameObject worldTarget;
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
            other.GetComponent<Rigidbody>().useGravity = false;
            //other.GetComponent<Rigidbody>().AddForce(-other.transform.up * 1000, ForceMode.Force);
            other.GetComponent<Rigidbody>().ResetInertiaTensor();

            Quaternion target = Quaternion.Euler(rotate, 0, 0);
            worldTarget.transform.rotation = Quaternion.Slerp(
                worldTarget.transform.rotation, 
                target, 
                Time.deltaTime
            );
            other.transform.RotateAround(other.transform.position, other.transform.forward, rotate);
            changed = true;

            Physics.gravity = target.eulerAngles;
        }
    }
}
