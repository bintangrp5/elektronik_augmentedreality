using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class ClickToShowPanel : MonoBehaviour
{
    [Header("Panel yang akan ditampilkan")]
    public GameObject targetPanel;

    private Camera arCamera;

    void Start()
    {
        if (targetPanel != null)
            targetPanel.SetActive(false);
    }

    void Update()
    {
        if (arCamera == null)
        {
            arCamera = Camera.main;
            return;
        }

        bool clicked = false;
        Vector2 clickPos = Vector2.zero;

        // Old Input System
        try
        {
            if (Input.GetMouseButtonDown(0))
            {
                clicked = true;
                clickPos = Input.mousePosition;
            }
        }
        catch { }

        // New Input System - Mouse
        try
        {
            if (UnityEngine.InputSystem.Mouse.current != null &&
                UnityEngine.InputSystem.Mouse.current.leftButton.wasPressedThisFrame)
            {
                clicked = true;
                clickPos = UnityEngine.InputSystem.Mouse.current.position.ReadValue();
            }
        }
        catch { }

        // New Input System - Touch
        try
        {
            if (UnityEngine.InputSystem.Touchscreen.current != null)
            {
                foreach (var touch in UnityEngine.InputSystem.Touchscreen.current.touches)
                {
                    if (touch.phase.ReadValue() == UnityEngine.InputSystem.TouchPhase.Began)
                    {
                        clicked = true;
                        clickPos = touch.position.ReadValue();
                    }
                }
            }
        }
        catch { }

        if (!clicked) return;

        // Cek apakah klik kena UI element (tombol, dll)
        if (IsPointerOverUIElement(clickPos))
        {
            Debug.Log("Klik kena UI element, diabaikan");
            return;
        }

        Ray ray = arCamera.ScreenPointToRay(clickPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f))
        {
            Debug.Log("Raycast kena: " + hit.transform.name);
            if (hit.transform == this.transform || hit.transform.IsChildOf(this.transform))
            {
                TogglePanel();
            }
        }
        else
        {
            Debug.Log("Raycast tidak kena apapun");
        }
    }

    // Cek apakah pointer kena UI element yang NYATA (bukan canvas kosong)
    private bool IsPointerOverUIElement(Vector2 screenPos)
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = screenPos;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        foreach (RaycastResult result in results)
        {
            GameObject go = result.gameObject;
            
            // Abaikan Canvas utama
            if (go.name == "Canvas") continue;
            
            // Abaikan jika parent panel tidak aktif
            if (!go.activeInHierarchy) continue;
            
            // Abaikan Text yang ada di dalam panel tidak aktif
            bool parentPanelActive = true;
            Transform parent = go.transform.parent;
            while (parent != null)
            {
                if (parent.name.Contains("Panel") && !parent.gameObject.activeSelf)
                {
                    parentPanelActive = false;
                    break;
                }
                parent = parent.parent;
            }
            if (!parentPanelActive) continue;

            if (go.GetComponent<UnityEngine.UI.Graphic>() != null)
                return true;
        }
        return false;
    }
    void TogglePanel()
    {
        bool isActive = targetPanel.activeSelf;
        targetPanel.SetActive(!isActive);
        Debug.Log("Panel: " + (!isActive ? "TAMPIL" : "SEMBUNYI"));
    }

    public void ClosePanel()
    {
        if (targetPanel != null)
            targetPanel.SetActive(false);
    }
}