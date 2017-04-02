using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static readonly string TAG_PLAYER = "Player";

    public GameObject fireFlame;
    public GameObject waterFlame;
    public GameObject airFlame;
    public GameObject earthFlame;
    public GameObject player;
    public GameObject skyBox;
    public Transform firePillar;
    public Transform waterPillar;
    public Transform airPillar;
    public Transform earthPillar;
    public Transform instancier;
    public Text timerText;
    public Text stateText;
    public float time = 0.0f;
    public List<Material> skyboxMaterial;
    public static int BLUE = 0;
    public static int RED = 1;
    public static int GREEN = 2;
    public static int YELLOW = 3;

    private GameObject actualPlayer;
    private float finalTime = 100;
    private int fire = 0;
    private int water = 0;
    private int earth = 0;
    private int air = 0;

	// Use this for initialization
	void Start ()
    {
        timerText.text = time + "";
        StartCoroutine(StateController());
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (air == 0)
        {
            if (StaticData.airPillar == 1)
            {
                Instantiate(airFlame, airPillar.position, Quaternion.identity);
                air = 1;
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


    IEnumerator StateController()
    {
        if (StaticData.firePillar == 0)
        {
            //rojo
            time = finalTime;
            stateText.text = "RED";
            StaticData.red = 1;
            // cambiar cielo
            CambiarCielo("RED");
            while (time > 0)
            {
                
                yield return new WaitForSeconds(1);
                time--;
                timerText.text = time + "";
            }
            actualPlayer = GameObject.FindGameObjectWithTag("Player");
            StaticData.red = 0;
            Destroy(actualPlayer);
            Instantiate(player, instancier.position, Quaternion.identity);
        }
        

        if (StaticData.earthPillar == 0)
        {
            //verde
            time = finalTime;
            stateText.text = "GREEN";
            StaticData.green = 1;
            CambiarCielo("GREEN");
            while (time > 0)
            {
                
                yield return new WaitForSeconds(1);
                time--;
                timerText.text = time + "";
            }
            actualPlayer = GameObject.FindGameObjectWithTag("Player");
            StaticData.green = 0;
            Destroy(actualPlayer);
            Instantiate(player, instancier.position, Quaternion.identity);
        }
        
        if (StaticData.waterPillar == 0)
        {
            //Azul
            time = finalTime;
            stateText.text = "BLUE";
            StaticData.blue = 1;
            CambiarCielo("BLUE");
            while (time > 0)
            {
                
                yield return new WaitForSeconds(1);
                time--;
                timerText.text = time + "";
            }
            actualPlayer = GameObject.FindGameObjectWithTag("Player");
            StaticData.blue = 0;
            Destroy(actualPlayer);
            Instantiate(player, instancier.position, Quaternion.identity);
        }
        
        if (StaticData.airPillar == 0)
        {
            //Amarillo
            time = finalTime;
            stateText.text = "YELLOW";
            StaticData.yellow = 1;
            CambiarCielo("YELLOW");
            while (time > 0)
            {
                
                yield return new WaitForSeconds(1);
                time--;
                timerText.text = time + "";
            }
            actualPlayer = GameObject.FindGameObjectWithTag("Player");
            StaticData.yellow = 0;
            Destroy(actualPlayer);
            Instantiate(player, instancier.position, Quaternion.identity);
        }

        if (StaticData.firePillar == 1)
        {
            if (StaticData.waterPillar == 1)
            {
                if (StaticData.airPillar == 1)
                {
                    if (StaticData.earthPillar == 1)
                    {
                        stateText.text = "EXIT";
                        timerText.text = "IN TIME";
                    }
                    else
                    {
                        StartCoroutine(StateController());
                    }
                }
                else
                {
                    StartCoroutine(StateController());
                }
            }
            else
            {
                StartCoroutine(StateController());
            }
        }
        else
        {
            StartCoroutine(StateController());
        }
        
        
    }

    void CambiarCielo(string color) {
        print(color);
        Material[] tempMaterial = new Material[1];
       switch (color) {
            case "RED":
                tempMaterial[0] = skyboxMaterial[RED];
                break;
            case "GREEN":
                tempMaterial[0] = skyboxMaterial[GREEN];
                break;
            case "YELLOW":
                tempMaterial[0] = skyboxMaterial[YELLOW];
                break;
            case "BLUE":
                tempMaterial[0] = skyboxMaterial[BLUE];
                break;
        }
        skyBox.GetComponent<MeshRenderer>().materials = tempMaterial;
    }

}
