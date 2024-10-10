using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _counter;

    private void Start()
    {
        _text.text = string.Empty;
    }

    private void OnEnable()
    {
        _counter.NumberChanged += DisplayCount;
    }

    private void OnDisable()
    {
        _counter.NumberChanged -= DisplayCount;
    }

    private void DisplayCount()
    {
        int count = _counter.DisplayedNumber;
        _text.text = count.ToString();
    }
}
