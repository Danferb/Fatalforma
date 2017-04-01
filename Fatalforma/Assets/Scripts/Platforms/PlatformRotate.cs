<<<<<<< HEAD:Fatalforma/Assets/Scripts/Player/PlatformRotate.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour {

    public float speed = 36;
    public float delay = 5;
    private int change = 1;
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


}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformRotate : MonoBehaviour {

    private float speed = 36;
    private float delay = 5;
    private int change = 1;

    

    //Update is called once per frame

    void Start()
    {
        StartCoroutine(Rotator());
    }

    void FixedUpdate()
    {
        if (change < 1)
        {
            transform.Rotate(Time.deltaTime * speed, 0, 0);
            StartCoroutine(StopRotation());
        }
        else
        {

        }


    }

    

    IEnumerator Rotator ()
    {
        while (true)
        {
            change *= -1;
            yield return new WaitForSeconds(delay);
        
        }
        
    }

    IEnumerator StopRotation ()
    {
        yield return new WaitForSeconds(1);
        transform.Rotate(0, 0, 0);
    }


}
>>>>>>> bb8f4d0e969d03991c57ff1cf4880b83cd6415da:Fatalforma/Assets/Scripts/Platforms/PlatformRotate.cs
