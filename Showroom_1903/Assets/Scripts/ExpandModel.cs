// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;


    /// <summary>
    /// Placeholder script for exploding the model.
    /// </summary>
    public class ExpandModel : MonoBehaviour
    {
        // We are using a different model for the expanded view.  Set it here so we can swap it out when we expand.
        [Tooltip("Game object for the exploded model.")]
        [SerializeField]
        private GameObject expandedModel;

        public GameObject ExpandedModel
        {
            get { return expandedModel; }
            set { expandedModel = value; }
        }

       public bool IsModelExpanded { get; private set; }

         void Awake()
        {
          IsModelExpanded = false;
        }

        public void Expand()
        {
            if (IsModelExpanded)
            {
                return;
            }

            IsModelExpanded = true;
        }

        public void Reset()
        {
            IsModelExpanded = false;
        }

       
    }

