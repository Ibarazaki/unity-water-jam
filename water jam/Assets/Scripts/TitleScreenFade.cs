using System.Collections;
using UnityEngine;

public class TitleScreenFade : MonoBehaviour
{
    [SerializeField] private CanvasGroup titleGroup;
    [SerializeField] private float fadeDuration = 0.6f;

    public void Play()
    {
        if (titleGroup == null) return;
        StartCoroutine(FadeOutAndDisable());
    }

    private IEnumerator FadeOutAndDisable()
    {
        titleGroup.interactable = false;
        titleGroup.blocksRaycasts = false;

        float startAlpha = titleGroup.alpha;
        float t = 0f;

        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float a = Mathf.Lerp(startAlpha, 0f, t / fadeDuration);
            titleGroup.alpha = a;
            yield return null;
        }

        titleGroup.alpha = 0f;
        titleGroup.gameObject.SetActive(false);
    }
}