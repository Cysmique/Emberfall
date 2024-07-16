using UnityEngine;
using DG.Tweening;

public class CardAnimator : MonoBehaviour
{
    [SerializeField] private float moveDuration = 0.5f;
    [SerializeField] private float scaleDuration = 0.3f;
    [SerializeField] private float hoverScale = 1.2f;

    private Vector3 originalScale;
    private Vector3 originalPosition;

    private void Awake()
    {
        originalScale = transform.localScale;
        originalPosition = transform.position;
    }

    public void PlayDrawAnimation(Vector3 targetPosition)
    {
        transform.DOMove(targetPosition, moveDuration).SetEase(Ease.OutBack);
    }

    public void PlayPlayAnimation(Vector3 targetPosition)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(originalScale * 1.5f, scaleDuration / 2));
        sequence.Append(transform.DOMove(targetPosition, moveDuration).SetEase(Ease.OutQuint));
        sequence.Append(transform.DOScale(originalScale, scaleDuration / 2));
    }

    public void PlayAttackAnimation(Vector3 targetPosition)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(targetPosition, moveDuration / 2).SetEase(Ease.OutQuad));
        sequence.Append(transform.DOMove(originalPosition, moveDuration / 2).SetEase(Ease.InQuad));
    }

    public void PlayHoverAnimation()
    {
        transform.DOScale(originalScale * hoverScale, scaleDuration);
    }

    public void PlayUnhoverAnimation()
    {
        transform.DOScale(originalScale, scaleDuration);
    }

    public void PlayDestroyAnimation()
    {
        transform.DOScale(Vector3.zero, scaleDuration).OnComplete(() => Destroy(gameObject));
    }
}
