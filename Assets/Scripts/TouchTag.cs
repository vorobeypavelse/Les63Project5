using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTag : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ghost"))
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log("GameOver");
        }
        else if (other.gameObject.CompareTag("Win"))
        {
            Debug.Log("Win Game");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
