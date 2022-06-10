using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Shape[] _shapes;

    private void Start()
    {
        StartTest();
    }

    private void StartTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            StartCoroutine(_shapes[i].RotateForSeconds(i + 1));
        }
    }
}
