using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;
    [SerializeField] private RotateMode _mode;
    [SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DORotate(_endValue, _duration, _mode).SetEase(_ease);
    }
}

