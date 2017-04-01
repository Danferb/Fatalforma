using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerZonePlatform : MonoBehaviour {

    public GameObject[] waypoints;

    void Start() {
        waypoints = new GameObject[transform.childCount];
        int i = 0;
        foreach (Transform t in transform) {
            waypoints[i] = t.gameObject;
            waypoints[i].SendMessage("SetMove",false);
            i++;
        }
        print("Hijos: " + waypoints.Length);

    }

    // Update is called once per frame
    void Update() {

    }
}
