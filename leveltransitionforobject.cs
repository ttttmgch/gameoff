using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class leveltransitionforobject : MonoBehaviour
{
    void OnCollisionEnter2D (Collision2D other)
    {
        SceneManager.LoadScene (1);
    }
}
