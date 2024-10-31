using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{    
    [SerializeField] private Text _pointsDisplay;

    public static int PointsAmount;
   

    private void Update()
    {
        _pointsDisplay.text = $"Points: {PointsAmount}";
    }
}
