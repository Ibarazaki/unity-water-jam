using UnityEngine;
using UnityEngine.InputSystem;

public class WorldCursorFollow : MonoBehaviour
{
    private Camera mainCam;

    void Start()
    {
        mainCam = Camera.main;
    }

    void Update()
    {
        if (mainCam == null) return;
        if (Mouse.current == null) return;

        Vector2 mouseScreenPos = Mouse.current.position.ReadValue();

        Vector3 worldPos = mainCam.ScreenToWorldPoint(new Vector3(
            mouseScreenPos.x,
            mouseScreenPos.y,
            mainCam.nearClipPlane
        ));

        worldPos.z = 0f; // keep cursor on 2D plane
        transform.position = worldPos;
    }
}
