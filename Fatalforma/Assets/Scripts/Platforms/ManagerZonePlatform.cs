using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerZonePlatform : MonoBehaviour {

    public GameObject[] waypoints;
    public List<GameObject> plaformsFixed;

    void Start() {
        waypoints = new GameObject[transform.childCount];
        int i = 0;
        foreach (Transform t in transform) {
            waypoints[i] = t.gameObject;
            waypoints[i].SendMessage("SetMove", false);
            i++;
        }
        if (plaformsFixed != null && plaformsFixed.Count > 0) {
            foreach (GameObject gObjt in plaformsFixed) {
                gObjt.SendMessage("SetFixedPlatform", true);
            }
        }
    }

    // Update is called once per frame
    void Update() {

    }

    public static void ActivatePlatform(GameObject platform) {        
        if (!platform.GetComponent<PlatformRotate>().isFixedPlatform()) {
            platform.SendMessage("SetMove", true);
        }
    }
}
