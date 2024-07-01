using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{

    public Button[] TakeButtons;
    public Button[] ComplatedButtons;
    public Button[] CancelsButtons;


    public static Action<Task> Take;
    public static Action<Task> Complate;
    public static Action<Task> Cancel;


    private void Start()
    {
        for (int i = 0; i < TakeButtons.Length; i++)
        {
            TakeButtons[i].interactable = true;
            ComplatedButtons[i].interactable = false;
            CancelsButtons[i].interactable = false;
            int index = i;
            TakeButtons[index].onClick.AddListener(() => TakeTask(TaskProducer.Instance.tasks[index], TakeButtons[index], ComplatedButtons[index], CancelsButtons[index]));
            ComplatedButtons[index].onClick.AddListener(() => TaskComplate(TaskProducer.Instance.tasks[index], TakeButtons[index], ComplatedButtons[index], CancelsButtons[index]));
            CancelsButtons[index].onClick.AddListener(() => TaskCanceled(TaskProducer.Instance.tasks[index], TakeButtons[index], ComplatedButtons[index], CancelsButtons[index]));
        }
    }

    public void TakeTask(Task task, Button takeButton, Button complateButton, Button CancelButton)
    {
        task.isTaked = true;
        Debug.Log(task.isTaked);
        takeButton.interactable = !task.isTaked;
        task.isCompleted = true;
        Debug.Log(task.isCompleted);
        complateButton.interactable = task.isCompleted;
        task.isCanceled = false;
        Debug.Log(task.isCanceled);
        CancelButton.interactable = !task.isCanceled;
        Take?.Invoke(task);
    }

    public void TaskComplate(Task task, Button takeButton, Button complateButton, Button CancelButton)
    {
        task.isTaked = true;
        Debug.Log(task.isTaked);
        takeButton.interactable = !task.isTaked;
        task.isCompleted = true;
        Debug.Log(task.isCompleted);
        complateButton.interactable = !task.isCompleted;
        task.isCanceled = false;
        Debug.Log(task.isCanceled);
        CancelButton.interactable = task.isCanceled;
        Complate?.Invoke(task);
    }

    public void TaskCanceled(Task task, Button takeButton, Button complateButton, Button CancelButton)
    {
        task.isTaked = false;
        Debug.Log(task.isTaked);
        takeButton.interactable = !task.isTaked;
        task.isCompleted = false;
        Debug.Log(task.isCompleted);
        complateButton.interactable = task.isCompleted;
        task.isCanceled = true;
        Debug.Log(task.isCanceled);
        CancelButton.interactable = !task.isCanceled;
        Cancel?.Invoke(task);
    }
}
