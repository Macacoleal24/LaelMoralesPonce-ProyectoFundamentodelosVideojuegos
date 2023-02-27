using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkground : MonoBehaviour
{
    //static puedes usar en otro script
    public static bool IsGrounded; 
    
    //Es local
    //public bool IsGrounded;

    //Cubito invisible entre en una geometria
    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsGrounded= true;
    }

    //Cuando no esta dentro de una geometria 
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsGrounded= false;
    }
}
