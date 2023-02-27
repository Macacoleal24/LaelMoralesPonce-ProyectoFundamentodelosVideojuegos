using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCollected : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            //Al momento de agarrar la manzana se activa la animacion
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            FindObjectOfType<FruitManager>().AllFruitsCollected();

            //Toma la manzana y se destruye por completo
            Destroy(gameObject,0.5f);
        }


    }
}
