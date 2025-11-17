using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class CanvasRegistration : MonoBehaviour
{
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    private void OnEnable()
    {
        CursorManager.RegisterCanvas(canvas);
    }

    private void OnDisable()
    {
        CursorManager.UnregisterCanvas(canvas);
    }
}