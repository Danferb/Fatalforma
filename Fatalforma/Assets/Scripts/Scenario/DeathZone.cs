using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour {

    public float delay;
    public GameObject player;
    public Transform instancier;

    private GameObject target;

    void OnTriggerEnter(Collider c) {
        //Application.LoadLevel(Application.loadedLevel);
        //int y = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadSceneAsync(y);
<<<<<<< HEAD
        if(c.tag == "Player")
        {
            
=======
        if (c.tag == "Player") {
>>>>>>> a2266c84b5ba33051b4a89383206045f1be50d4d
            c.gameObject.SetActive(false);
            StartCoroutine(respawn(c));

        }

    }

    IEnumerator respawn(Collider c) {
        yield return new WaitForSeconds(delay);
        Instantiate(player, instancier.position, Quaternion.identity);
        Destroy(c);

    }

}
