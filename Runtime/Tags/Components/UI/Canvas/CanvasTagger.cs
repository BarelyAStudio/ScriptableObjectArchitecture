﻿using UnityEngine;

namespace ScriptableObjectArchitecture.Tags.Components.UI
{
    [RequireComponent(typeof(Canvas))]
    [DisallowMultipleComponent]
    public class CanvasTagger : ComponentTagger<Canvas> { }
}
