using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEditorInternal;
using Unity.Mathematics;

public class ButtonsManager : MonoBehaviour
{
    public Image leaf;
    private bool isZoomOut = false;
    private bool isScaleOut = false;
    private bool isFadeOut = false;
    private bool isDropOut = false;
    
    public void Zoom()
    {
        float zoomVal = 0;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        leaf.transform.DOScale(targetZoom, 0.25f);
        isZoomOut = !isZoomOut;
    }

    public void Scale()
    {
        float scaleVal = 0;
        float targetScale = isScaleOut ? 1.0f : scaleVal;
        leaf.DOFade(targetScale, 0.25f);
        isScaleOut = !isScaleOut;
        float zoomVal = 0.9f;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        leaf.transform.DOScale(targetZoom, 0.25f);
        isZoomOut = !isZoomOut;
    }

    public void Fade()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        leaf.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;

    }

    public void FadeDown()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        leaf.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;
        float dropVal = 26.7f;
        float targetDrop = isDropOut ? 28.7f : dropVal;
        leaf.transform.DOMoveY(targetDrop, 0.21f);
        isDropOut = !isDropOut;

    }

    public void FadeUp()
    {
        float fadeVal = 0;
        float targetFade = isFadeOut ? 1.0f : fadeVal;
        leaf.DOFade(targetFade, 0.3f);
        isFadeOut = !isFadeOut;
        float dropVal = 30.7f;
        float targetDrop = isDropOut ? 28.7f : dropVal;
        leaf.transform.DOMoveY(targetDrop, 0.21f);
        isDropOut = !isDropOut;

    }

    public void Drop()
    {
        float dropVal = 50.0f;
        float targetDrop = isDropOut ? 28.7f : dropVal;
        leaf.transform.DOMoveY(targetDrop, 0.2f);
        isDropOut = !isDropOut;
        float zoomVal = 0;
        float targetZoom = isZoomOut ? 1.0f : zoomVal;
        leaf.transform.DOScale(targetZoom, 0.21f);
        isZoomOut = !isZoomOut;
    }
}