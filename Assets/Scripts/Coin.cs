using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Coin has been collected");
        }
    }
}
