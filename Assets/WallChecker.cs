using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallChecker : MonoBehaviour {
    public bool Walled = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tilemap")
        {
            Walled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tilemap")
        {
            Walled = false;
        }
    }
}
