using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _positionVariants;
    [SerializeField] private GameObject[] _enemies;

    private float _timeBetweenSpawn;
    private float _startTimeBetweenSpawn = 1.5f;
    private float _decreaseTime = 0.05f;

    private float _minTime = 0.65f;

    private void Update()
    {
        int randomNumber = Random.Range(0, _positionVariants.Length - 1);
        int randomEnemiesIndex = Random.Range(0, _enemies.Length);
        if (_timeBetweenSpawn <= 0)
        {
            Instantiate(_enemies[randomEnemiesIndex], _positionVariants[randomNumber].transform.position, Quaternion.identity);
            _timeBetweenSpawn = _startTimeBetweenSpawn;
            if (_startTimeBetweenSpawn > _minTime)
            {
                _startTimeBetweenSpawn -= _decreaseTime;
            }
        }
        else
        {
            _timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
