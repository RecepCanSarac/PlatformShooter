using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskProducer : MonoBehaviour
{
    public static TaskProducer Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public Task task1 = new Task(1, "Easy Ques", "Kill 20 people");
    public Task task2 = new Task(2, "Normal Quest", "Capture opponent's barracks");
    public Task task3 = new Task(2, "Normal Quest", "Capture opponent's port");
    public Task task4 = new Task(3, "Main Ques", "Defeat your opponent's lord");


    public List<Task> tasks = new List<Task>();

    private IReadOnlyList<Task> taskList => tasks;

    private void Start()
    {
        tasks.Add(task1);
        tasks.Add(task2);
        tasks.Add(task3);
        tasks.Add(task4);
    }
    public void Setup(TextMeshProUGUI _level, TextMeshProUGUI _name, TextMeshProUGUI _desc, Task _task)
    {
        _level.text = _task.TaskLevel.ToString();
        _name.text = _task.TaskName;
        _desc.text = _task.TaskDescription;
    }
}


public class Task
{
    public int TaskLevel { get; set; }
    public string TaskName { get; set; }
    public string TaskDescription { get; set; }

    public bool isTaked;
    public bool isCompleted;
    public bool isCanceled;
    public Task(int _level, string _name, string _desc)
    {
        this.TaskLevel = _level;
        this.TaskName = _name;
        this.TaskDescription = _desc;
    }
}