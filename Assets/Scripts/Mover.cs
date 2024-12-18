using UnityEngine;
using DG.Tweening;

public class Mover : AnimatedFigure
{
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private float _duration;

    private void Start()
    {
        _endValue += transform.position;
        transform.DOMove(_endValue, _duration)
            .SetEase(Ease)
            .SetLoops(Repiats,LoopType);
    }
}

