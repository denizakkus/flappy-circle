using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UIElements.Experimental;

public class CanvasComponent : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    [SerializeField] private Transform startPosition;
    [SerializeField] private Transform endPosition;

    private void Awake()
    {
        canvasGroup = gameObject.GetComponent<CanvasGroup>();
    }

    public void Show ()
    {
        if (!canvasGroup) return;

        canvasGroup.alpha = 0;
        canvasGroup.transform.position = startPosition.position;

        canvasGroup.transform.DOMove(endPosition.position, 0.6f).SetEase(Ease.OutBack);

        canvasGroup.DOFade(1.0f, 0.4f).OnComplete(()=> {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        });

    }

    public void Hide()
    {
        if (!canvasGroup) return;

        canvasGroup.transform.position = endPosition.position;
        canvasGroup.transform.DOMove(startPosition.position, 0.6f).SetEase(Ease.InOutQuart);

        canvasGroup.alpha = 1;
        canvasGroup.DOFade(0.0f, 0.4f).OnComplete(() => {
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
        });
    }
}
