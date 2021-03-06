// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.


using UnityEngine;

namespace Academy
{
    public class AstronautManager : MonoBehaviour
    {
        [SerializeField]
        private float expandAnimationCompletionTime;

        // Store a bool for whether our astronaut model is expanded or not.
        private bool isModelExpanding = false;
        [SerializeField]
        private ExpandModel expandModel;
        
        private void Update()
        {
            if (isModelExpanding && Time.realtimeSinceStartup >= expandAnimationCompletionTime)
            {
                isModelExpanding = false;

                Animator[] expandedAnimators = expandModel.ExpandedModel.GetComponentsInChildren<Animator>();
                foreach (Animator animator in expandedAnimators)
                {
                    animator.enabled = false;
                }
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                ExpandModelCommand();
                Debug.Log("pressed");
            }
            if (Input.GetKeyDown(KeyCode.I))
            {
                ResetModelCommand();
                Debug.Log("pressed");
            }
        }

        public void ResetModelCommand()
        {
            // Reset local variables.
            isModelExpanding = false;

            GameObject currentModel = expandModel.gameObject;
            GameObject expandedModel = expandModel.ExpandedModel;

            // Disable the expanded model.
            expandedModel.SetActive(false);

            // Enable the idle model.
            currentModel.SetActive(true);

            // Enable the animators for the next time the model is expanded.
            Animator[] expandedAnimators = expandedModel.GetComponentsInChildren<Animator>();
            foreach (Animator animator in expandedAnimators)
            {
                animator.enabled = true;
            }

            expandModel.Reset();
        }

        public void ExpandModelCommand()
        {
            // Swap out the current model for the expanded model.
            GameObject currentModel = expandModel.gameObject;
            GameObject expandedModel = expandModel.ExpandedModel;

            expandedModel.transform.position = currentModel.transform.position;
            expandedModel.transform.rotation = currentModel.transform.rotation;
            expandedModel.transform.localScale = currentModel.transform.localScale;

            

            // Play animation.  Ensure the Loop Time check box is disabled in the inspector for this animation to play it once.
            Animator[] expandedAnimators = expandedModel.GetComponentsInChildren<Animator>();
            // Set local variables for disabling the animation.
            if (expandedAnimators.Length > 0)
            {
                expandAnimationCompletionTime = Time.realtimeSinceStartup + expandedAnimators[0].runtimeAnimatorController.animationClips[0].length * 0.05f;
            }
            currentModel.SetActive(false);
            expandedModel.SetActive(true);
            // Set the expand model flag.
            isModelExpanding = true;

           expandModel.Expand();
        }
    }
}
