using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Debug.Log("gagné");
        }
    }

}
