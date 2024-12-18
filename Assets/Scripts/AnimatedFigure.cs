using UnityEngine;
using DG.Tweening;

public abstract class AnimatedFigure : MonoBehaviour
{
    [SerializeField] protected float Duration = 3f;
    [SerializeField] protected int Repiats = -1;
    [SerializeField] protected LoopType LoopType = LoopType.Yoyo;
    [SerializeField] protected Ease Ease = Ease.Linear;
}

