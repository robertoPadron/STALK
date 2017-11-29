using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Character")
        {
            SceneManager.LoadScene("LEVEL_2");
        }
    }
}
