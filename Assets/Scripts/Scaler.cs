using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DOScale(_endValue, _duration).SetEase(_ease);
    }
}

