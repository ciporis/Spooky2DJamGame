using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemies;

    private void Start()
    {
        int randomNumber = Random.Range(0, _enemies.Length - 1);
        Instantiate(_enemies[randomNumber], transform.position, Quaternion.identity);
    }
}
