using UnityEngine;
using System.Collections.Generic;

public class BrowserHistoryManager : MonoBehaviour
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();
    private string currentPage = "none";

    void Start()
    {
        Debug.Log("You are on " + currentPage);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            VisitPage("Page 1");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            VisitPage("Page 2");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            VisitPage("Page 3");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GoBack();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            GoForward();
        }
    }

    void VisitPage(string pageName)
    {
        backStack.Push(currentPage);
        forwardStack.Clear();
        currentPage = pageName;
        Debug.Log("Visited " + pageName);
    }

    void GoBack()
    {
        if (backStack.Count > 0)
        {
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            Debug.Log("Went back to " + currentPage);
        }
        else
        {
            Debug.Log("No pages in back history.");
        }
    }

    void GoForward()
    {
        if (forwardStack.Count > 0)
        {
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Debug.Log("Went forward to " + currentPage);
        }
        else
        {
            Debug.Log("No pages in forward history.");
        }
    }
}