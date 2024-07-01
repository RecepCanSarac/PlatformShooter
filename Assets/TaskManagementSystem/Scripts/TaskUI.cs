using TMPro;
using UnityEngine;

public class TaskUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] taskName;
    [SerializeField] private TextMeshProUGUI[] taskDescription;
    [SerializeField] private TextMeshProUGUI[] taskLevel;


    private void Start()
    {
        for (int i = 0; i < taskLevel.Length; i++)
        {
            TaskProducer.Instance.Setup(taskLevel[i], taskName[i], taskDescription[i], TaskProducer.Instance.tasks[i]);
        }
    }
}
