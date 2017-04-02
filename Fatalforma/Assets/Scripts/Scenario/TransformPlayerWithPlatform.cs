using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPlayerWithPlatform : MonoBehaviour {

    public GameObject worldTarget;
    public float rotate = -20;
    private bool changed = false;

    private void OnTriggerEnter(Collider other) {
        if (!changed && other.tag.Equals(GameManager.TAG_PLAYER)) {
            Quaternion target = Quaternion.Euler(rotate, 0, rotate);
            worldTarget.transform.rotation = Quaternion.Slerp(worldTarget.transform.rotation, target, Time.deltaTime * 2.0f);
            other.transform.RotateAround(other.transform.position, other.transform.forward, rotate);
            changed = true;
        }
    }
}
