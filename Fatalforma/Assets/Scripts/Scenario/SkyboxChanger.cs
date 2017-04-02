using UnityEngine;
using UnityEngine.UI;

public class SkyboxChanger : MonoBehaviour
{
    public Material[] Skyboxes;

    public void Awake()
    {

    }

    public void ChangeSkybox()
	{
		int columns = 0;
		if (StaticData.airPillar == 1) ++columns;
		if (StaticData.earthPillar == 1) ++columns;
		if (StaticData.waterPillar == 1) ++columns;
		if (StaticData.firePillar == 1) ++columns;
        RenderSettings.skybox = Skyboxes[columns];
    }
}