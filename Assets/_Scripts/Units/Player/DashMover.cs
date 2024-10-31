using System.Collections;
using UnityEngine;

public class DashMover : MonoBehaviour
{   
    [SerializeField] private float _speed;
    [SerializeField] private float _offsetY;
    [SerializeField] private Transform _topLine;
    [SerializeField] private Transform _bottomLine;

    private float _maxY;
    private float _minY;

    private Vector2 _targetPosition = new Vector2(0f, 0f);

    private void Start()
    {
        _maxY = _topLine.position.y;
        _minY = _bottomLine.position.y;
    }

    private PlayerPositionCondition _currntLine = PlayerPositionCondition.OnMiddleLine;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && (_currntLine == PlayerPositionCondition.OnMiddleLine || _currntLine == PlayerPositionCondition.OnBottomLine))
        {
            _currntLine++;
            _targetPosition.y += _offsetY;
        }
        else if (Input.GetKeyDown(KeyCode.S) && (_currntLine == PlayerPositionCondition.OnMiddleLine || _currntLine == PlayerPositionCondition.OnTopLine))
        {
            _currntLine--;
            _targetPosition.y -= _offsetY;
        }
    }
}   
