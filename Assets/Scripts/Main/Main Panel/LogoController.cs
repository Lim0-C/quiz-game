using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LogoController : MonoBehaviour
{
    [SerializeField] private RectTransform topLogoRectTransform;
    [SerializeField] private RectTransform middleLogoRectTransform;
    [SerializeField] private RectTransform bottomLogoRectTransform;

    private void Start()
    {
        topLogoRectTransform.DOAnchorPosY(15, 2f);
        bottomLogoRectTransform.DOAnchorPosY(-15, 2f);
    }

}
