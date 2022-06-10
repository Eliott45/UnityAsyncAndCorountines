using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private Shape[] _shapes;

    private void Start()
    {
        //StartCoroutineTest();
        //StartAsyncTest();
        StartSequentiallyAsyncTest();
    }

    private void StartCoroutineTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            StartCoroutine(_shapes[i].RotateForSeconds(i + 1));
        }
    }
    
    private void StartAsyncTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            _shapes[i].RotateForSecondsAsync(i + 1);
        }
    }
    
    private async void StartSequentiallyAsyncTest()
    {
        for (var i = 0; i < _shapes.Length; i++)
        {
            await _shapes[i].RotateForSecondsTaskAsync(i + 1);
        }
    }
}
