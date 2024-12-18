using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _firstValue;
    [SerializeField] private string _secondValue;
    [SerializeField] private string _thirdValue;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay = 8f;
    [SerializeField] private ScrambleMode _scrambleMode;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_firstValue, _duration).SetDelay(_delay, true));
        sequence.Append(_text.DOText(_secondValue, _duration).SetRelative().SetDelay(_delay, true));
        sequence.Append(_text.DOText(_thirdValue, _duration, scrambleMode: _scrambleMode).SetDelay(_delay, true));
    }
}

