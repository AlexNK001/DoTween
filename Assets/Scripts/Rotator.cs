using UnityEngine;
using DG.Tweening;

public class Rotator : AnimatedFigure
{
    [SerializeField] private Vector3 _endValue;
    //[SerializeField] private float _duration;
    [SerializeField] private RotateMode _mode;
    //[SerializeField] private Ease _ease;

    private void Start()
    {
        transform.DORotate(_endValue, Duration, _mode)
            .SetEase(Ease)
            .SetLoops(Repiats,LoopType);
    }
}

