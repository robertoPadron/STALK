using System.Collections;
using UnityEngine;

public class Scene : MonoBehaviour {

    public void LoadScene(int level)
    {
        Application.LoadLevel(level);
    }
}