using UnityEngine;

public class UIFloat : MonoBehaviour
{
    [SerializeField] private float amplitude = 8f;   // pixels
    [SerializeField] private float speed = 0.6f;     // cycles per second-ish
    [SerializeField] private float phaseOffset = 0f; // lets you stagger items

    private RectTransform rt;
    private Vector2 startPos;

    void Awake()
    {
        rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
    }

    void OnEnable()
    {
        if (rt == null) rt = GetComponent<RectTransform>();
        startPos = rt.anchoredPosition;
    }

    void Update()
    {
        float y = Mathf.Sin((Time.unscaledTime * speed * Mathf.PI * 2f) + phaseOffset) * amplitude;
        rt.anchoredPosition = new Vector2(startPos.x, startPos.y + y);
    }
}