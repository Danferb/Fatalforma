using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour {

    private readonly float speedFinal = 36;
    private bool fixedPlatform = false;
    private int change = 1;

    public float speed = 36;
    public float delay = 5;
    //Update is called once per frame
    void Start() {
        StartCoroutine(Rotator());
    }

    void FixedUpdate() {
        if (change < 1) {
            transform.Rotate(Time.deltaTime * speed, 0, 0);
            StartCoroutine(StopRotation());
        } else {

        }
    }

    IEnumerator Rotator() {
        while (true) {
            change *= -1;
            yield return new WaitForSeconds(delay);
        }
    }

    IEnumerator StopRotation() {
        yield return new WaitForSeconds(1);
        transform.Rotate(0, 0, 0);
    }
    
    public void SetMove(bool isMove) {
        if (isMove) {
            speed = speedFinal;
        } else {
            speed = 0;
        }
    }

    public void SetFixedPlatform(bool fixedPlat) {
        fixedPlatform = fixedPlat;
    }

    public bool isFixedPlatform() {
        return fixedPlatform;
    }

    private void OnTriggerEnter(Collider other) {
        print("Has entrado en: " + other.ToString());
        ManagerZonePlatform.ActivatePlatform(gameObject);
    }
}