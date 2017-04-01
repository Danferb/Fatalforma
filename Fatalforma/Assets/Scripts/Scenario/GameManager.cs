using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject fireFlame;
    public GameObject waterFlame;
    public GameObject airFlame;
    public GameObject earthFlame;
    public Transform firePillar;
    public Transform waterPillar;
    public Transform airPillar;
    public Transform earthPillar;

    private int fire = 0;
    private int water = 0;
    private int earth = 0;
    private int air = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (air == 0)
        {
            if (StaticData.airPillar == 1)
            {
                Instantiate(airFlame, airPillar.position, Quaternion.identity);
                fire = 1;
            }
        }
        if (earth == 0)
        {
            if (StaticData.earthPillar == 1)
            {
                Instantiate(earthFlame, earthPillar.position, Quaternion.identity);
                earth = 1;
            }
        }
        
        if (fire == 0)
        {
            if (StaticData.firePillar == 1)
            {
                Instantiate(fireFlame, firePillar.position, Quaternion.identity);
                fire = 1;
            }
        }
        if (water == 0)
        {
            if (StaticData.waterPillar == 1)
            {
                Instantiate(waterFlame, waterPillar.position, Quaternion.identity);
                water = 1;
            }
        }
        
		
	}
}
