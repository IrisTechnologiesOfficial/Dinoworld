using UnityEngine;

public class ClickActivateDeactivate : MonoBehaviour
{
    public struct ActivateDeactivateElement
    {
        public RectTransform ElementWhichWillActivateOrDeactivate;

        public GameObject[] ObjectsToActivateOrDeactivate;

        public bool ActivateOrDeactivate;
    }

    private bool MousePressed = false;
    public ActivateDeactivateElement[] Elements;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            MousePressed = true;
        if (Input.GetMouseButtonUp(0))
            MousePressed = false;
        if (MousePressed)
            foreach (ActivateDeactivateElement element in Elements)
            {
                Vector2 localMousePosition = element.ElementWhichWillActivateOrDeactivate.InverseTransformPoint(Input.mousePosition);
                if (element.ElementWhichWillActivateOrDeactivate.rect.Contains(localMousePosition))
                {
                    if (element.ActivateOrDeactivate)
                        foreach (GameObject go in element.ObjectsToActivateOrDeactivate)
                            go.SetActive(true);
                    else
                        foreach (GameObject go in element.ObjectsToActivateOrDeactivate)
                            go.SetActive(false);
                }
            }
    }
}