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

>>>>>>> 7e26b74c7f901181678ef1436309d30684796e07
            c.gameObject.SetActive(false);
            StartCoroutine(respawn(c));

        }

    }

    IEnumerator respawn(Collider c) {
        yield return new WaitForSeconds(delay);
        Instantiate(player, instancier.position, Quaternion.identity);
        Destroy(c.gameObject);

    }

}
