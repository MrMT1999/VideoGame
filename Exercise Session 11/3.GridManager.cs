using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject tilePrefab;
    public int rows;
    public int columns;
    private GameObject[,] grid;

    void Start()
    {
        grid = new GameObject[rows, columns];
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                GameObject tile = Instantiate(tilePrefab, new Vector3(x, y, 0), Quaternion.identity);
                tile.name = "Tile (" + x + "," + y + ")";
                tile.GetComponent<Renderer>().material.color = Color.white;
                grid[x, y] = tile;
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedTile = hit.collider.gameObject;
                clickedTile.GetComponent<Renderer>().material.color = Color.red;
                Debug.Log("Clicked on: " + clickedTile.name);
            }
        }
    }

    public void ToggleTile(int row, int column, bool isActive)
    {
        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            grid[row, column].SetActive(isActive);
        }
        else
        {
            Debug.LogWarning("Invalid tile coordinates!");
        }
    }
}