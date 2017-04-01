using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour {

    public Transform instancier;
    public GameObject portal;
    private int controller = 0;
	
	// Update is called once per frame
	void Update ()
    {
        if (controller == 0)
        {
            if (StaticData.firePillar == 1)
            {
                if (StaticData.waterPillar == 1)
                {
                    if (StaticData.airPillar == 1)
                    {
                        if (StaticData.earthPillar == 1)
                        {
                            Instantiate(portal, instancier.position, Quaternion.AngleAxis(-90.0f, new Vector3(1, 0, 0)));
                            controller = 1;
                        }
                    }
                }
            }
        }
		

	}
}
