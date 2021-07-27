using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelButtonCollision : MonoBehaviour
{
    [SerializeField]
    string startTag;
   private void OnCollisionEnter(Collision collision)
   {
        if(collision.collider.tag == startTag)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
