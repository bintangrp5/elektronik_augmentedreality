using UnityEngine;

public class TogglePanel : MonoBehaviour
{
    public GameObject panel;

    public void Toggle()
    {
        if (panel != null)
            panel.SetActive(!panel.activeSelf);
    }

    public void ShowPanel()
    {
        if (panel != null)
            panel.SetActive(true);
    }

    public void HidePanel()
    {
        if (panel != null)
            panel.SetActive(false);
    }
}