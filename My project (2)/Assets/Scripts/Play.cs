using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] KeyCode KeyOne;
    [SerializeField] KeyCode KeyTwo;
    [SerializeField] Vector3 moveDirection;

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyOne))
        {
            GetComponent<Rigidbody>().velocity += moveDirection;
        }
        if (Input.GetKey(KeyTwo))
        {
            GetComponent<Rigidbody>().velocity -= moveDirection;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            SceneManager.LoadScene(0);
        }

    }
    
    private void OnTriggerEnter (Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
