using UnityEngine;

public class PlayerSceneReloader : MonoBehaviour
{
    [SerializeField] private GameObject _pannel;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            _pannel.SetActive(true);
        }
    }
}