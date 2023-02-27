using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public float checkPointPositionX, checkPointPositionY;

    public Animator animator;

    void Start()
    {
        if(PlayerPrefs.GetFloat("checkPointPositionX")!=0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
        
    }

    public void ReachedCheckPoint(float x, float y) 
    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);

        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }

    public void PLayerDamaged() 
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
