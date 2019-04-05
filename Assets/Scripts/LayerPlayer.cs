using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerPlayer : MonoBehaviour
{
    public class MeshRendererSortOrder: MonoBehaviour {

        public int sortOrder;

        //Initialization

        void Start()
        {
            MeshRenderer MRmesh = GetComponent<MeshRenderer>();
            MRmesh.sortingLayerName = "3-Players";
            MRmesh.sortingOrder = sortOrder;
            
        }


    }

    
}
