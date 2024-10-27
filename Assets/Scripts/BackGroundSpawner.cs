using UnityEngine;

public class BackGroundSpawner : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private GameObject[] _images;
    [SerializeField] private Transform _indexingImage;
    [SerializeField] private float _offsetX;

    private float _offsetForSpawning = 19f;

    private int _currentImageForSpawnIndex = 0;

    private void Update()
    {
        if(_player.position.x >= _indexingImage.position.x - _offsetX)
        {
            Instantiate(_images[_currentImageForSpawnIndex], new Vector2(_indexingImage.position.x + _offsetForSpawning, _indexingImage.position.y), Quaternion.identity);
            _currentImageForSpawnIndex++;
            if(_currentImageForSpawnIndex > 1 )
                _currentImageForSpawnIndex = 0;
        }
    }
}
