using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public int SceneNumber;
  public void Transition ()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}
