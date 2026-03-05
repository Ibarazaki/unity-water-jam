using UnityEngine;

public class PlayerFaceCursor : MonoBehaviour
{
    [SerializeField] private Transform worldCursor;

    void Update()
    {
        if (worldCursor == null) return;

        Vector2 direction = worldCursor.position - transform.position;

        // Avoid weird rotation if cursor is exactly on player
        if (direction.sqrMagnitude < 0.0001f) return;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // -90f if your sprite's "forward" is UP.
        // Use 0f if your sprite's "forward" is RIGHT.
        transform.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
    }
}
