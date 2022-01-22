#if UNITY_EDITOR

using UnityEditor;
using UnityEditorInternal;
using UnityEngine.Events;

namespace Genesis.Creation {
	[CustomPropertyDrawer(typeof(UnityEventBase), true)]
	public sealed class CustomUnityEventDrawer: UnityEventDrawer {
		protected override void SetupReorderableList(ReorderableList list) {
			base.SetupReorderableList(list);
			list.draggable = true;
		}
	}
}

#endif