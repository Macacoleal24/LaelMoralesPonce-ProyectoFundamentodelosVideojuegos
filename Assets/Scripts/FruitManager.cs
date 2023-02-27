using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{

    public TextMeshProUGUI levelCleaned;

    public GameObject transition;

    private void Update()
    {
        AllFruitsCollected();
    }

    public void AllFruitsCollected()
    {

        if (transform.childCount == 0)
        {
            Debug.Log("No quedan frutas, Victoria");
            levelCleaned.gameObject.SetActive(true);
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
