using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneReloader : MonoBehaviour
{
    private void OnCollidionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
