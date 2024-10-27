using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSceneReloader : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            PointsManager.PointsAmount = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}