using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPointScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name);
        // Destroy(other.gameObject.transform.parent.gameObject);

        var parent =
             other           // 
            .gameObject     // 
            .transform      // 
            .parent;        // 
                            //.
        if (parent != null && parent.CompareTag("Pipe"))
        {
            GameObject.Destroy(parent.gameObject);
        }
        else
        {
            GameObject.Destroy(other.gameObject);
        }
    }
}
