﻿using KSP_Chroma_Control.ColorSchemes;
using UnityEngine;

namespace KSP_Chroma_Control.SceneManagers
{
    /// <summary>
    /// Contains the base color scheme for all VAB and SPH scenes.
    /// </summary>
    class VabScheme : ColorScheme
    {
        /// <summary>
        /// Overlays the defined key colors over the base color scheme.
        /// </summary>
        public VabScheme()
        {
            SetKeysToColor(new KeyCode[] {
                KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.Q, KeyCode.E
            }, new Color(1f, 1f, 0f));
            SetKeysToColor(new KeyCode[] {
                KeyCode.LeftShift, KeyCode.Space, KeyCode.F
            }, Color.magenta);
        }
    }
}