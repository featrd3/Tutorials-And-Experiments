using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HighlightManager : MonoBehaviour
{
    public float sightDistance;

    private RaycastHit hit;

    private Renderer selectionRenderer;
    private Mesh selectionMesh;
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private GameObject highlightBox;

    private Vector3 defaultHighlightBoxPosition;

    private Ray ray;

    void Start()
    {
        defaultHighlightBoxPosition = highlightBox.transform.position;
    }

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, sightDistance))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {
                selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    highlightBox.transform.position = selection.transform.position;
                    selectionMesh = selection.GetComponent<MeshFilter>().mesh;

                    highlightBox.GetComponent<MeshFilter>().mesh = selectionMesh;

                    highlightBox.transform.position = selection.transform.position;
                    highlightBox.transform.rotation = selection.transform.rotation;
                    highlightBox.transform.localScale = selection.transform.localScale;

                }
            }
        }
        else
        {
            highlightBox.transform.position = defaultHighlightBoxPosition;
        }
    }
}
