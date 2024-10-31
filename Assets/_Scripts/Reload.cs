using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour
{
    [SerializeField] private Text _amountOfPoints;

    private void Start()
    {
        _amountOfPoints.text = $"Your score: {PointsManager.PointsAmount}";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            PointsManager.PointsAmount = 0;
        }
    }    
}
