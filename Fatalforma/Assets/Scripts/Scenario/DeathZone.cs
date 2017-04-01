using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter(Collider c){
		//Application.LoadLevel(Application.loadedLevel);
		int y = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadSceneAsync(y);
	}
}
