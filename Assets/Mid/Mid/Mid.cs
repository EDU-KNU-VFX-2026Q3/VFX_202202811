using UnityEngine;

public class WaterSwitch : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToTurnOff = System.Array.Empty<GameObject>();
    [SerializeField] private GameObject[] objectsToTurnOn = System.Array.Empty<GameObject>();

    private void Awake()
    {
        SetObjectsActive(objectsToTurnOn, false);
    }

    public void StopWater()
    {
        SetObjectsActive(objectsToTurnOff, false);
        SetObjectsActive(objectsToTurnOn, true);
    }

    private void SetObjectsActive(GameObject[] targets, bool active)
    {
        foreach (GameObject target in targets)
        {
            // Keep the switch and its parents active.
            if (target != null && !transform.IsChildOf(target.transform))
            {
                target.SetActive(active);
            }
        }
    }
}
