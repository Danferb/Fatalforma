using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {

    public float delay;
    public GameObject player;
    public Transform instancier;

    private GameObject target;

	void OnTriggerEnter(Collider c){
        //Application.LoadLevel(Application.loadedLevel);
        //int y = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadSceneAsync(y);
        if(c.tag == "Player")
        {
            
            c.gameObject.SetActive(false);
            StartCoroutine(respawn(c));
            
        }
        
	}

    IEnumerator respawn (Collider c)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(player, instancier.position, Quaternion.identity);
        Destroy(c);

    }
    
}
