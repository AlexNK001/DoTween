using UnityEngine;
using DG.Tweening;

public class ColorChanger : AnimatedFigure
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _endValue;
    [SerializeField] private float _duration;

    private void Start()
    {
        _meshRenderer.material.DOColor(_endValue, _duration)
            .SetEase(Ease)
            .SetLoops(Repiats, LoopType);
    }
}

