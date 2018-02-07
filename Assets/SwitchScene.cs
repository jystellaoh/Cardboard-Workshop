using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    void MuseumGrounds()
    {
        SceneManager.LoadScene("MuseumGrounds");
    }

    void Galleries()
    {
        SceneManager.LoadScene("Galleries");
    }
}