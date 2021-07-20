// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.UI
{
    [AddComponentMenu("Scripts/MRTK/SDK/ToggleHandVisualisation")]
    public class ToggleHandVisualisation : MonoBehaviour
    {
        private void Start()
        {
            MixedRealityHandTrackingProfile handTrackingProfile =gethandreference();
            handTrackingProfile.EnableHandMeshVisualization = false;
        }
        /// <summary>
        /// Toggles hand mesh visualization
        /// </summary>
        public void OnToggleHandMesh()
        {
           MixedRealityHandTrackingProfile handTrackingProfile = gethandreference();
            if (handTrackingProfile != null)
            {
                handTrackingProfile.EnableHandMeshVisualization = !handTrackingProfile.EnableHandMeshVisualization;
            }
        }

        /// <summary>
        /// Toggles hand joint visualization
        /// </summary>
        public void OnToggleHandJoint()
        {
            MixedRealityHandTrackingProfile handTrackingProfile = null;

            if (CoreServices.InputSystem?.InputSystemProfile != null)
            {
                handTrackingProfile = CoreServices.InputSystem.InputSystemProfile.HandTrackingProfile;
            }

            if (handTrackingProfile != null)
            {
                handTrackingProfile.EnableHandJointVisualization = !handTrackingProfile.EnableHandJointVisualization;
            }
        }
        private MixedRealityHandTrackingProfile gethandreference()
        {
            MixedRealityInputSystemProfile inputSystemProfile = CoreServices.InputSystem?.InputSystemProfile;
            if (inputSystemProfile == null)
            {
                return null;
            }

            return inputSystemProfile.HandTrackingProfile;
        }
    }
}
