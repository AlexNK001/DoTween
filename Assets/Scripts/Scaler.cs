using UnityEngine;
using DG.Tweening;

public class Scaler : AnimatedFigure
{
    [SerializeField] private Vector3 _endValue;
    //[SerializeField] private Ease _ease;
    //[SerializeField] private float _duration;
    //[SerializeField] private int _repiats = -1;
    //[SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_endValue, Duration)
            .SetEase(Ease)
            .SetLoops(Repiats, LoopType);
    }
}

